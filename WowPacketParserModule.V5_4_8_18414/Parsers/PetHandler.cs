using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;
using Guid = WowPacketParser.Misc.WowGuid;
using PetModeFlags = WowPacketParserModule.V5_4_8_18414.Enums.PetModeFlags;
using ReactState = WowPacketParserModule.V5_4_8_18414.Enums.ReactState;
using CommandState = WowPacketParserModule.V5_4_8_18414.Enums.CommandState;

namespace WowPacketParserModule.V5_4_8_18414.Parsers
{
    public static class PetHandler
    {
        public static void ReadPetFlags(ref Packet packet)
        {
            var petModeFlag = packet.ReadUInt32();
            packet.AddValue("React state", (ReactState)((petModeFlag) & 0xFF));
            packet.AddValue("Command state", (CommandState)((petModeFlag >> 8) & 0xFF));
            packet.AddValue("Flag", (PetModeFlags)((petModeFlag >> 16) & 0xFFFF));
        }

        [Parser(Opcode.CMSG_PET_ABANDON)]
        public static void HandlePetMiscGuid(Packet packet)
        {
            var guid = packet.StartBitStream(7, 3, 4, 2, 5, 6, 1, 0);
            packet.ParseBitStream(guid, 0, 2, 5, 6, 7, 1, 4, 3);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.CMSG_PET_ACTION)]
        public static void HandlePetAction(Packet packet)
        {
            var guid1 = new byte[8];
            var guid2 = new byte[8];

            packet.ReadUInt32("Data");
            packet.ReadSingle("Y");
            packet.ReadSingle("Z");
            packet.ReadSingle("X");

            guid2[1] = packet.ReadBit();
            guid2[0] = packet.ReadBit();
            guid2[6] = packet.ReadBit();
            guid2[7] = packet.ReadBit();
            guid2[5] = packet.ReadBit();
            guid1[7] = packet.ReadBit();
            guid2[2] = packet.ReadBit();
            guid2[3] = packet.ReadBit();
            guid1[6] = packet.ReadBit();
            guid1[3] = packet.ReadBit();
            guid1[0] = packet.ReadBit();
            guid1[2] = packet.ReadBit();
            guid1[5] = packet.ReadBit();
            guid2[4] = packet.ReadBit();
            guid1[4] = packet.ReadBit();
            guid1[1] = packet.ReadBit();

            packet.ReadXORByte(guid2, 7);
            packet.ReadXORByte(guid2, 6);
            packet.ReadXORByte(guid2, 1);
            packet.ReadXORByte(guid2, 2);
            packet.ReadXORByte(guid2, 5);
            packet.ReadXORByte(guid2, 4);
            packet.ReadXORByte(guid1, 5);
            packet.ReadXORByte(guid2, 3);
            packet.ReadXORByte(guid1, 0);
            packet.ReadXORByte(guid1, 1);
            packet.ReadXORByte(guid1, 7);
            packet.ReadXORByte(guid1, 4);
            packet.ReadXORByte(guid1, 6);
            packet.ReadXORByte(guid1, 2);
            packet.ReadXORByte(guid1, 3);
            packet.ReadXORByte(guid2, 0);

            packet.WriteGuid("Guid1", guid1);
            packet.WriteGuid("Guid2", guid2);
        }

        [Parser(Opcode.CMSG_PET_CAST_SPELL)]
        public static void HandlePetCastSpell(Packet packet)
        {
            var guid1 = new byte[8];
            var guid2 = new byte[8];
            var guid3 = new byte[8];
            var guid4 = new byte[8];
            var petGuid = new byte[8];

            var transportGUID = new byte[8];
            var guid20 = new byte[8];

            var bit388 = false;
            var bit389 = false;
            var bit412 = false;
            var hasUnkMovementField = false;
            var hasTransport = false;
            var hasTransportTime2 = false;
            var hasTransportTime3 = false;
            var hasMovementFlags = false;
            var hasMovementFlags2 = false;
            var hasFallDirection = false;
            var hasFallData = false;
            var hasPitch = false;
            var hasOrientation = false;
            var hasSplineElevation = false;
            var hasTimestamp = false;

            var targetString = 0u;

            var hasDestLocation = packet.ReadBit();         // v2 + 112
            petGuid[7] = packet.ReadBit();
            var hasMissileSpeed = !packet.ReadBit();
            var hasSrcLocation = packet.ReadBit();          // v2 + 80
            petGuid[1] = packet.ReadBit();
            var archeologyCounter = packet.ReadBits(2);     // v2 + 424
            var hasTargetMask = !packet.ReadBit();          // v2 + 32
            petGuid[4] = packet.ReadBit();
            packet.ReadBit();
            petGuid[6] = packet.ReadBit();
            var hasTargetString = !packet.ReadBit();        // v2 + 120
            packet.ReadBit();
            var hasMovement = packet.ReadBit();             // v2 + 416
            var hasCastFlags = !packet.ReadBit();           // v2 + 28
            var hasSpellId = !packet.ReadBit();             // v2 + 20
            petGuid[0] = packet.ReadBit();
            petGuid[5] = packet.ReadBit();
            petGuid[2] = packet.ReadBit();
            for (var i = 0; i < archeologyCounter; ++i)
                packet.ReadBits("archeologyType", 2, i);
            petGuid[3] = packet.ReadBit();
            var hasGlyphIndex = !packet.ReadBit();          // v2 + 24
            var hasCastCount = !packet.ReadBit();           // v2 + 16
            var hasElevation = !packet.ReadBit();

            var unkMovementLoopCounter = 0u;
            if (hasMovement)
            {
                hasOrientation = !packet.ReadBit();
                hasSplineElevation = !packet.ReadBit();
                bit388 = packet.ReadBit(); // v2 + 388
                guid20[5] = packet.ReadBit();               // v2 + 261
                guid20[7] = packet.ReadBit();               // v2 + 263
                hasMovementFlags2 = !packet.ReadBit();
                hasTimestamp = !packet.ReadBit();           // v2 + bit272
                hasFallData = packet.ReadBit();
                hasMovementFlags = !packet.ReadBit();       // v2 + 264
                hasUnkMovementField = !packet.ReadBit();    // v2 + 408

                if (hasMovementFlags)
                    packet.ReadBits("hasMovementFlags", 30);
                bit389 = packet.ReadBit();                  // v2 + 389
                guid20[6] = packet.ReadBit();               // v2 + 263
                hasTransport = packet.ReadBit(); // v2 + 344
                guid20[0] = packet.ReadBit();               // v2 + 263
                unkMovementLoopCounter = packet.ReadBits(22);

                if (hasTransport)
                {
                    hasTransportTime2 = packet.ReadBit();   // v2 + 332
                    hasTransportTime3 = packet.ReadBit();   // v2 + 340
                    transportGUID[5] = packet.ReadBit();    // v2 + 300
                    transportGUID[6] = packet.ReadBit();    // v2 + 302
                    transportGUID[4] = packet.ReadBit();    // v2 + 301
                    transportGUID[0] = packet.ReadBit();    // v2 + 296
                    transportGUID[1] = packet.ReadBit();    // v2 + 297
                    transportGUID[2] = packet.ReadBit();    // v2 + 2980
                    transportGUID[7] = packet.ReadBit();    // v2 + 303
                    transportGUID[3] = packet.ReadBit();    // v2 + 299
                }

                guid20[1] = packet.ReadBit();               // v2 + 257

                if (hasMovementFlags2)
                    packet.ReadBits("hasMovementFlags2", 13);

                guid20[3] = packet.ReadBit();               // v2 + 259
                guid20[2] = packet.ReadBit();               // v2 + 258
                bit412 = packet.ReadBit();                  // v2 + 412
                hasPitch = !packet.ReadBit();
                guid20[4] = packet.ReadBit(); // v2 + 260

                if (hasFallData)
                    hasFallDirection = packet.ReadBit();
            }

            if (hasDestLocation)
                packet.StartBitStream(guid2, 2, 0, 1, 4, 5, 6, 3, 7);

            if (hasCastFlags)
                packet.ReadBits("hasCastFlags", 5);

            packet.StartBitStream(guid1, 2, 4, 7, 0, 6, 1, 5, 3);

            if (hasTargetMask)
                packet.ReadEnum<TargetFlag>("Target Flags", 20);

            if (hasTargetString)
                targetString = packet.ReadBits("hasTargetString", 7);

            if (hasSrcLocation)
                packet.StartBitStream(guid4, 2, 0, 3, 1, 6, 7, 4, 5);

            packet.StartBitStream(guid3, 6, 0, 3, 4, 2, 1, 5, 7);

            //resetbitreader

            packet.ReadXORBytes(petGuid, 2, 6, 3);

            for (var i = 0; i < archeologyCounter; ++i)
            {
                packet.ReadUInt32("unk1", i); // +4
                packet.ReadUInt32("unk2", i); // +8
            }
            packet.ReadXORBytes(petGuid, 1, 7, 0, 4, 5);

            if (hasDestLocation)
            {
                packet.ReadXORByte(guid2, 4);
                packet.ReadXORByte(guid2, 1);
                packet.ReadXORByte(guid2, 7);
                packet.ReadSingle("Position Z");
                packet.ReadSingle("Position Y");
                packet.ReadXORByte(guid2, 6);
                packet.ReadXORByte(guid2, 3);
                packet.ReadSingle("Position X");
                packet.ReadXORByte(guid2, 2);
                packet.ReadXORByte(guid2, 5);
                packet.ReadXORByte(guid2, 0);

                packet.WriteGuid("Guid2", guid2);
            }

            if (hasMovement)
            {
                if (hasPitch)
                    packet.ReadSingle("Pitch");     // v2 + 352

                if (hasTransport)
                {
                    if (hasTransportTime3)
                        packet.ReadInt32("hasTransportTime3");

                    if (hasTransportTime2)
                        packet.ReadInt32("hasTransportTime2");

                    packet.ReadByte("Transport Seat");      // v2 + 320
                    packet.ReadSingle("O");          // v2 + 304
                    packet.ReadSingle("Z");          // v2 + 312
                    packet.ReadXORByte(transportGUID, 2);   // v2 + 298
                    packet.ReadInt32("Transport Time");     // v2 + 324
                    packet.ReadXORByte(transportGUID, 3);   // v2 + 299
                    packet.ReadSingle("X");          // v2 + 308
                    packet.ReadXORByte(transportGUID, 6);   // v2 + 302
                    packet.ReadXORByte(transportGUID, 5);   // v2 + 301
                    packet.ReadXORByte(transportGUID, 7);   // v2 + 303
                    packet.ReadXORByte(transportGUID, 0);   // v2 + 296
                    packet.ReadSingle("Y");          // v2 + 316
                    packet.ReadXORByte(transportGUID, 4);   // v2 + 300
                    packet.ReadXORByte(transportGUID, 1);   // v2 + 297

                    packet.WriteGuid("Transport GUID", transportGUID);
                }

                if (hasUnkMovementField)
                    packet.ReadInt32("Int408");     // v2 + 408

                for (var i = 0; i < unkMovementLoopCounter; ++i)
                    packet.ReadInt32("MovementLoopCounter", i);

                packet.ReadXORByte(guid20, 3);      // v2 + 260

                if (hasOrientation)
                    packet.ReadSingle("Orientation");   // v2 + 288

                packet.ReadXORByte(guid20, 5);      // v2 + 256

                if (hasFallData)
                {
                    packet.ReadSingle("Z Speed");

                    if (hasFallDirection)
                    {
                        packet.ReadSingle("CosAngle");
                        packet.ReadSingle("XY Speed");
                        packet.ReadSingle("SinAngle");
                    }
                    packet.ReadInt32("FallTime");
                }

                if (hasTimestamp)
                    packet.ReadInt32("hasTimestamp");   // v2 + 288

                packet.ReadXORByte(guid20, 6);      // v2 + 262
                packet.ReadSingle("Position X");      // v2 + 276
                packet.ReadXORByte(guid20, 1);      // v2 + 257
                packet.ReadSingle("Position Z");    // v2 + 284
                packet.ReadXORByte(guid20, 2);      // v2 + 258
                packet.ReadXORByte(guid20, 7);      // v2 + 260
                packet.ReadXORByte(guid20, 0);      // v2 + 256
                packet.ReadSingle("Position Y");    // v2 + 280
                packet.ReadXORByte(guid20, 4);      // v2 + 260

                if (hasSplineElevation)
                    packet.ReadSingle("SplineElevation");   // v2 + 384

                packet.WriteGuid("Guid20", guid20);
            }

            if (hasSrcLocation)
            {
                packet.ReadXORByte(guid4, 3);
                packet.ReadXORByte(guid4, 4);
                packet.ReadXORByte(guid4, 2);
                packet.ReadXORByte(guid4, 1);
                packet.ReadXORByte(guid4, 0);
                packet.ReadXORByte(guid4, 7);
                packet.ReadSingle("Position Z");
                packet.ReadXORByte(guid4, 6);
                packet.ReadXORByte(guid4, 5);
                packet.ReadSingle("Position X");
                packet.ReadSingle("Position Y");

                packet.WriteGuid("Guid4", guid4);
            }

            if (hasMissileSpeed)
                packet.ReadSingle("missileSpeed");

            packet.ParseBitStream(guid1, 1, 2, 5, 7, 4, 6, 3, 0);
            packet.WriteGuid("Guid1", guid1);

            packet.ParseBitStream(guid3, 1, 5, 7, 3, 0, 2, 4, 6);
            packet.WriteGuid("Guid3", guid3);

            if (hasElevation)
                packet.ReadSingle("hasElevation");

            if (hasCastCount)
                packet.ReadByte("Cast Count");

            if (hasTargetString)
                packet.ReadWoWString("TargetString", targetString);

            if (hasGlyphIndex)
                packet.ReadInt32("hasGlyphIndex");

            if (hasSpellId)
                packet.ReadEntry<Int32>(StoreNameType.Spell, "Spell ID");
            packet.WriteGuid("PetGuid", petGuid);
        }

        [HasSniffData]
        [Parser(Opcode.CMSG_PET_NAME_QUERY)]
        public static void HandlePetNameQuery(Packet packet)
        {
            var guid1 = new byte[8];
            var guid2 = new byte[8];

            guid2[0] = packet.ReadBit();
            guid2[5] = packet.ReadBit();
            guid1[1] = packet.ReadBit();
            guid1[7] = packet.ReadBit();
            guid2[7] = packet.ReadBit();
            guid1[6] = packet.ReadBit();
            guid1[4] = packet.ReadBit();
            guid1[5] = packet.ReadBit();
            guid1[0] = packet.ReadBit();
            guid2[3] = packet.ReadBit();
            guid2[6] = packet.ReadBit();
            guid2[2] = packet.ReadBit();
            guid1[3] = packet.ReadBit();
            guid1[2] = packet.ReadBit();
            guid2[1] = packet.ReadBit();
            guid2[4] = packet.ReadBit();

            packet.ReadXORByte(guid2, 2);
            packet.ReadXORByte(guid2, 1);
            packet.ReadXORByte(guid2, 0);
            packet.ReadXORByte(guid2, 7);
            packet.ReadXORByte(guid1, 5);
            packet.ReadXORByte(guid1, 0);
            packet.ReadXORByte(guid2, 6);
            packet.ReadXORByte(guid1, 4);
            packet.ReadXORByte(guid2, 5);
            packet.ReadXORByte(guid1, 2);
            packet.ReadXORByte(guid1, 6);
            packet.ReadXORByte(guid2, 3);
            packet.ReadXORByte(guid1, 3);
            packet.ReadXORByte(guid2, 4);
            packet.ReadXORByte(guid1, 1);
            packet.ReadXORByte(guid1, 7);

            packet.WriteGuid("Pet Guid", guid1);
            packet.WriteGuid("Pet Number", guid2);

            var PetGuid = new WowGuid64(BitConverter.ToUInt64(guid1, 0));
            var PetNumberGuid = new WowGuid64(BitConverter.ToUInt64(guid2, 0));
            var PetNumber = PetNumberGuid.GetEntry().ToString(CultureInfo.InvariantCulture); // Not sure about this.

            // Store temporary name from Pet Number GUID (will be retrieved as uint64 in SMSG_PET_NAME_QUERY_RESPONSE)
            StoreGetters.AddName(PetGuid, PetNumber);
        }

        [Parser(Opcode.CMSG_PET_RENAME)]
        public static void HandlePetRename(Packet packet)
        {
            packet.ReadInt32("unk16"); // 16
            var unk20 = packet.ReadBit("unk20"); // 20
            var unk149 = packet.ReadBit("unk149"); // 149
            uint unk150 = 0;
            uint unk22 = 0;
            if (unk149 == 1)
                unk150 = packet.ReadBits(7);
            if (unk20)
                unk22 = packet.ReadBits(8);
            if (unk20)
                packet.ReadWoWString("str1", unk22);
            if (unk149==1)
                packet.ReadWoWString("str2", unk150);
        }

        [Parser(Opcode.CMSG_PET_SET_ACTION)]
        public static void HandlePetSetAction(Packet packet)
        {
            var i = 0;
            packet.ReadUInt32("Position", i);
            var action = (uint)packet.ReadUInt16() + (packet.ReadByte() << 16);
            packet.AddValue("Action", action, i);
            packet.ReadEnum<ActionButtonType>("Type", TypeCode.Byte, i++);
            var guid = packet.StartBitStream(1, 0, 5, 3, 2, 7, 6, 4);
            packet.ParseBitStream(guid, 5, 6, 7, 3, 2, 1, 4, 0);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.SMSG_PET_ACTION_FEEDBACK)]
        public static void HandlePetActionFeedback(Packet packet)
        {
            var hasData = !packet.ReadBit("!hasData"); // 16
            var state = packet.ReadEnum<PetFeedback>("Pet state", TypeCode.Byte); // 20
            if (hasData)
                packet.ReadEntry<Int32>(StoreNameType.Spell, "Spell ID"); // 16
        }

        [Parser(Opcode.SMSG_PET_ACTION_SOUND)]
        public static void HandlePetActionSound(Packet packet)
        {
            var guid = packet.StartBitStream(2, 7, 6, 0, 5, 1, 3, 4);
            packet.ParseBitStream(guid, 7, 4, 6, 1);
            packet.ReadEnum<PetTalk>("Talk Type", TypeCode.UInt32); // 24
            packet.ParseBitStream(guid, 2, 3, 5, 0);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.SMSG_PET_DISMISS_SOUND)]
        public static void HandlePetDismissSound(Packet packet)
        {
            /* ����� ���������� ��� ����� ������� ������ ���������.
             ���� unk28=110, ���� ����� ��� �����
             ServerToClient: SMSG_DESTROY_OBJECT (0x14C2) Length: 9
             Despawn Animation: False
             Object Guid: Full: 0xF141743FAE000E1D Type: Pet Low: 2919239197 Name: 0
             ���� unk28=2201,  ���� ����� ��� �����
             ServerToClient: SMSG_CANCEL_AUTO_REPEAT (0x1E0F) Length: 8
             Guid: Full: 0xF150D53C000573CC Type: Vehicle Entry: 54588 Low: 357324
             */
            var point = new Vector3();
            packet.ReadInt32("Sound ID"); // CreatureSoundData.dbc - iRefID_soundPetDismissID // 28  110 / 2201
            point.X = packet.ReadSingle(); // 16
            point.Z = packet.ReadSingle(); // 24
            point.Y = packet.ReadSingle(); // 20
            packet.AddValue("Position", point);
        }

        [Parser(Opcode.SMSG_PET_GUIDS)]
        public static void HandlePetGuids(Packet packet)
        {
            var count = packet.ReadBits("count", 24);
            var guid = new byte[count][];
            for (var i = 0; i < count; i++)
            {
                guid[i] = new byte[8];
                guid[i] = packet.StartBitStream(1, 6, 0, 4, 5, 7, 2, 3);
            }
            for (var i = 0; i < count; i++)
            {
                packet.ParseBitStream(guid[i], 5, 2, 3, 0, 6, 1, 4, 7);
                packet.WriteGuid("Guid", guid[i], i);
            }
        }

        [Parser(Opcode.SMSG_PET_MODE)]
        public static void HandlePetMode(Packet packet)
        {
            var guid = packet.StartBitStream(5, 0, 6, 3, 7, 2, 4, 1);
            ReadPetFlags(ref packet); // 24
            packet.ParseBitStream(guid, 2, 5, 4, 0, 1, 7, 3, 6);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.SMSG_PET_NAME_QUERY_RESPONSE)]
        public static void HandlePetNameQueryResponse(Packet packet)
        {
            var hasData = packet.ReadBit();
            if (!hasData)
            {
                packet.ReadUInt64("Pet number");
                return;
            }

            const int maxDeclinedNameCases = 5;
            var declinedNameLen = new int[maxDeclinedNameCases];
            for (var i = 0; i < maxDeclinedNameCases; i++)
                declinedNameLen[i] = (int)packet.ReadBits(7);

            packet.ReadBit("Declined");

            var len = packet.ReadBits(8);

            for (var i = 0; i < maxDeclinedNameCases; i++)
                if (declinedNameLen[i] != 0)
                    packet.ReadWoWString("Declined name", declinedNameLen[i], i);

            var petName = packet.ReadWoWString("Pet name", len);
            packet.ReadTime("Time");
            var number = packet.ReadUInt64("Pet number");

            var guidArray = (from pair in StoreGetters.NameDict where Equals(pair.Value, number) select pair.Key).ToList();
            foreach (var guid in guidArray)
                StoreGetters.NameDict[guid] = petName;
        }

        [Parser(Opcode.SMSG_PET_SPELLS)]
        public static void HandlePetSpells(Packet packet)
        {
            var guid = new byte[8];
            guid[7] = packet.ReadBit();
            guid[4] = packet.ReadBit();
            var count68 = packet.ReadBits("unk68", 21);
            var count40 = packet.ReadBits("unk40", 22);
            guid[2] = packet.ReadBit();
            var count16 = packet.ReadBits("unk16", 20);
            guid[5] = packet.ReadBit();
            guid[3] = packet.ReadBit();
            guid[6] = packet.ReadBit();
            guid[0] = packet.ReadBit();
            guid[1] = packet.ReadBit();

            const int maxCreatureSpells = 10;
            var spells = new List<uint>(maxCreatureSpells);
            for (var i = 0; i < maxCreatureSpells; i++) // Read pet/vehicle spell ids
            {
                var spell16 = packet.ReadUInt16();
                var spell8 = packet.ReadByte();
                var spellId = spell16 + (spell8 << 16);
                var slot = packet.ReadByte();

                if (spellId <= 4)
                    packet.AddValue("Action", spellId, i);
                else
                    packet.AddValue("Spell", StoreGetters.GetName(StoreNameType.Spell, spellId), i);
            }

            for (var i = 0; i < count16; i++)
            {
                packet.ReadInt32("unk28", i);
                packet.ReadInt32("unk20", i);
                packet.ReadInt16("unk32", i);
                packet.ReadInt32("unk24", i);
            }
            packet.ReadXORByte(guid, 2);
            for (var i = 0; i < count40; i++)
                packet.ReadInt32("unk44", i);
            packet.ReadXORByte(guid, 7);
            packet.ReadXORByte(guid, 0);
            packet.ReadXORByte(guid, 3);
            packet.ReadInt16("unk66");
            for (var i = 0; i < count68; i++)
            {
                packet.ReadInt32("unk76", i);
                packet.ReadByte("unk80", i);
                packet.ReadInt32("unk72", i);
            }
            packet.ReadInt16("unk64");
            packet.ReadXORByte(guid, 1);
            packet.ReadXORByte(guid, 4);
            packet.ReadXORByte(guid, 6);
            packet.ReadInt32("unk36");
            packet.ReadXORByte(guid, 5);
            packet.ReadInt32("unk32");
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.SMSG_STABLE_RESULT)]
        public static void HandleStableResult(Packet packet)
        {
            var guid = packet.StartBitStream(3, 0, 4, 7, 2, 1, 6, 5);
            var count = packet.ReadBits("count", 19);
            var cnt = new uint[count];
            for (var i = 0; i < count; i++)
            {
                cnt[i] = packet.ReadBits("unk192", 8, i);
            }
            for (var i = 0; i < count; i++)
            {
                packet.ReadInt32("unk144", i);
                packet.ReadInt32("unk176", i);
                packet.ReadByte("unk261", i);
                packet.ReadInt32("unk160", i);
                packet.ReadWoWString("PetName", cnt[i], i);
                packet.ReadInt32("PetNumber", i);
                packet.ReadInt32("unk112", i);
            }
            packet.ParseBitStream(guid, 3, 5, 7, 2, 0, 4, 1, 6);
            packet.WriteGuid("Guid", guid);
        }
    }
}
