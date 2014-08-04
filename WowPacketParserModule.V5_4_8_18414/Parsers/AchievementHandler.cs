using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V5_4_8_18414.Parsers
{
    public static class AchievementHandler
    {
        [Parser(Opcode.SMSG_ALL_ACHIEVEMENT_DATA_ACCOUNT)]
        public static void HandleAllAchievementDataAccount(Packet packet)
        {
            var count = packet.ReadBits("count", 19);
            var guid = new byte[count][];
            var guid2 = new byte[count][];
            var cnt = new uint[count];
            for (var i = 0; i < count; i++)
            {
                guid[i] = new byte[8];
                guid2[i] = new byte[8];

                guid[i][0] = packet.ReadBit();
                guid2[i][7] = packet.ReadBit();

                cnt[i] = packet.ReadBits(4);

                guid2[i][4] = packet.ReadBit();
                guid[i][6] = packet.ReadBit();
                guid2[i][5] = packet.ReadBit();
                guid2[i][2] = packet.ReadBit();
                guid2[i][0] = packet.ReadBit();
                guid2[i][6] = packet.ReadBit();
                guid[i][5] = packet.ReadBit();
                guid[i][7] = packet.ReadBit();
                guid2[i][1] = packet.ReadBit();
                guid2[i][3] = packet.ReadBit();
                guid[i][4] = packet.ReadBit();
                guid[i][3] = packet.ReadBit();
                guid[i][2] = packet.ReadBit();
                guid[i][1] = packet.ReadBit();
            }
            for (var i = 0; i < count; i++)
            {
                packet.ParseBitStream(guid[i], 2);
                packet.ParseBitStream(guid2[i], 2, 4);
                packet.ParseBitStream(guid[i], 4);
                packet.ParseBitStream(guid2[i], 6, 0);
                packet.ReadInt32("unk276", i); // 276
                packet.ParseBitStream(guid2[i], 1, 7);
                packet.ReadPackedTime("Time", i);
                packet.ParseBitStream(guid[i], 7, 6, 5, 1);
                packet.ParseBitStream(guid2[i], 3);
                packet.ReadInt32("unk260", i); // 260
                packet.ParseBitStream(guid2[i], 5);
                packet.ParseBitStream(guid[i], 3, 0);
                packet.ReadInt32("Criteria ID", i); // 20
                packet.WriteGuid("Guid", guid[i], i);
                packet.WriteGuid("Guid2", guid2[i], i);
            }
        }

        [Parser(Opcode.SMSG_ALL_ACHIEVEMENT_DATA_PLAYER)]
        public static void HandleAllAchievementDataPlayer(Packet packet)
        {
            var count = packet.ReadBits("Criteria count", 19);
            var guid = new byte[count][];
            var counter = new byte[count][];
            var flags = new uint[count];
            for (var i = 0; i < count; i++)
            {
                guid[i] = new byte[8];
                counter[i] = new byte[8];

                guid[i][3] = packet.ReadBit();
                counter[i][3] = packet.ReadBit();
                counter[i][6] = packet.ReadBit();
                guid[i][0] = packet.ReadBit();
                counter[i][7] = packet.ReadBit();
                guid[i][1] = packet.ReadBit();
                guid[i][5] = packet.ReadBit();
                counter[i][2] = packet.ReadBit();
                counter[i][1] = packet.ReadBit();
                guid[i][7] = packet.ReadBit();
                counter[i][4] = packet.ReadBit();
                counter[i][0] = packet.ReadBit();
                guid[i][2] = packet.ReadBit();
                counter[i][5] = packet.ReadBit();
                guid[i][4] = packet.ReadBit();
                flags[i] = packet.ReadBits(4);
                guid[i][6] = packet.ReadBit();
            }
            var cnt16 = packet.ReadBits("Achievement count", 20); // 16
            var guid3 = new byte[cnt16][];
            for (var i = 0; i < cnt16; i++)
            {
                guid3[i] = new byte[8];
                guid3[i] = packet.StartBitStream(0, 7, 1, 5, 2, 4, 6, 3);
            }
            for (var i = 0; i < cnt16; i++)
            {
                packet.ReadInt32("Achievement Id", i); // 20
                packet.ReadInt32("Realm Id", i); // 208
                packet.ParseBitStream(guid3[i], 5, 7);
                packet.ReadInt32("unk212", i); // 212
                packet.ReadPackedTime("Time", i);
                packet.ParseBitStream(guid3[i], 0, 4, 1, 6, 2, 3);
                packet.WriteGuid("guid3", guid3[i], i);
            }
            for (var i = 0; i < count; i++)
            {
                packet.ParseBitStream(guid[i], 7);
                packet.ReadInt32("Timer 1", i); // 292
                packet.ParseBitStream(guid[i], 6);
                packet.ParseBitStream(counter[i], 1);
                packet.ReadInt32("Criteria ID", i); // 36
                packet.ParseBitStream(guid[i], 4);
                packet.ParseBitStream(counter[i], 0, 4, 6);
                packet.ParseBitStream(guid[i], 1, 5);
                packet.ParseBitStream(counter[i], 7, 2);
                packet.ParseBitStream(guid[i], 2, 0);
                packet.ParseBitStream(counter[i], 3);
                packet.ReadInt32("Timer 2", i); // 236
                packet.ParseBitStream(guid[i], 3);
                packet.ParseBitStream(counter[i], 5);
                packet.ReadPackedTime("Time", i);

                packet.WriteGuid("Guid", guid[i], i);
                packet.WriteLine("[{0}] Counter: {1}", i, BitConverter.ToUInt64(counter[i], 0));
                packet.WriteLine("[{0}] Flags: {1}", i, flags[i]);
            }
        }

        [Parser(Opcode.SMSG_CRITERIA_UPDATE_ACCOUNT)]
        public static void HandleCriteriaUpdateAccount(Packet packet)
        {
            var counter = new byte[8];
            var accountId = new byte[8];

            counter[4] = packet.ReadBit();
            accountId[2] = packet.ReadBit();
            counter[2] = packet.ReadBit();
            accountId[4] = packet.ReadBit();
            counter[0] = packet.ReadBit();
            counter[5] = packet.ReadBit();
            accountId[3] = packet.ReadBit();
            counter[3] = packet.ReadBit();
            accountId[6] = packet.ReadBit();
            counter[6] = packet.ReadBit();
            accountId[1] = packet.ReadBit();
            accountId[7] = packet.ReadBit();
            counter[1] = packet.ReadBit();

            packet.ReadBits("Flags", 4); // some flag... & 1 -> delete

            accountId[5] = packet.ReadBit();
            counter[7] = packet.ReadBit();
            accountId[0] = packet.ReadBit();

            packet.ReadXORByte(accountId, 7);
            packet.ReadUInt32("Timer 2"); // 80
            packet.ReadInt32("Criteria ID"); // 16
            packet.ReadXORByte(counter, 7);
            packet.ReadUInt32("Timer 1"); // 76
            packet.ReadXORByte(accountId, 4);
            packet.ReadXORByte(accountId, 3);
            packet.ReadPackedTime("Time");
            packet.ReadXORByte(counter, 0);
            packet.ReadXORByte(counter, 1);
            packet.ReadXORByte(counter, 2);
            packet.ReadXORByte(counter, 3);
            packet.ReadXORByte(accountId, 1);
            packet.ReadXORByte(counter, 4);
            packet.ReadXORByte(counter, 5);
            packet.ReadXORByte(accountId, 5);
            packet.ReadXORByte(accountId, 2);
            packet.ReadXORByte(counter, 6);
            packet.ReadXORByte(accountId, 0);
            packet.ReadXORByte(accountId, 6);

            packet.WriteLine("Account: {0}", BitConverter.ToUInt64(accountId, 0));
            packet.WriteLine("Counter: {0}", BitConverter.ToInt64(counter, 0));
        }

        [Parser(Opcode.SMSG_CRITERIA_UPDATE_PLAYER)]
        public static void HandleCriteriaPlayer(Packet packet)
        {
            var guid = packet.StartBitStream(4, 6, 2, 3, 7, 1, 5, 0);
            packet.ParseBitStream(guid, 3, 6, 2);
            packet.ReadUInt32("Criteria ID"); // 72
            packet.ReadUInt32("Flags"); // 76
            packet.ParseBitStream(guid, 5, 1);
            packet.ReadPackedTime("Time"); // 28
            packet.ParseBitStream(guid, 4);
            packet.ReadUInt32("Timer 1"); // 24
            packet.ReadUInt32("Timer 2"); // 80
            packet.ParseBitStream(guid, 7, 0);
            packet.WriteGuid("Guid", guid);
            packet.ReadUInt64("Counter"); // 16
            packet.WriteGuid("Guid", guid);
        }
    }
}
