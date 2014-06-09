using System;
using System.Collections.Generic;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using WowPacketParser.Store;
using WowPacketParser.Store.Objects;
using WowPacketParserModule.V5_4_7_18019.Enums;

namespace WowPacketParserModule.V5_4_7_18019.Parsers
{
    public static class QuestHandler
    {
        [Parser(Opcode.CMSG_QUEST_POI_QUERY)]
        public static void HandleQuestPoiQuery(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.CMSG_QUESTGIVER_ACCEPT_QUEST)]
        public static void HandleQuestgiverAcceptQuest(Packet packet)
        {
            var guid = new byte[8];

            packet.ReadInt32("QuestID");

            guid[3] = packet.ReadBit();
            guid[2] = packet.ReadBit();
            guid[7] = packet.ReadBit();
            packet.ReadBit("Unk");
            guid[5] = packet.ReadBit();
            guid[0] = packet.ReadBit();
            guid[6] = packet.ReadBit();
            guid[1] = packet.ReadBit();
            guid[4] = packet.ReadBit();

            packet.ParseBitStream(guid, 3, 4, 7, 2, 5, 1, 6, 0);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.CMSG_QUESTGIVER_CHOOSE_REWARD)]
        public static void HandleQuestgiverChooseReward(Packet packet)
        {
            packet.ReadInt32("Reward");
            packet.ReadInt32("QuestID");

            var guid = packet.StartBitStream(2, 0, 7, 5, 6, 4, 1, 3);
            packet.ParseBitStream(guid, 7, 2, 4, 5, 3, 6, 1, 0);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.CMSG_QUESTGIVER_COMPLETE_QUEST)]
        public static void HandleQuestgiverCompleteQuest(Packet packet)
        {
            var guid = new byte[8];

            packet.ReadInt32("QuestID");

            guid[6] = packet.ReadBit();
            guid[5] = packet.ReadBit();
            guid[7] = packet.ReadBit();
            guid[4] = packet.ReadBit();
            guid[3] = packet.ReadBit();
            guid[0] = packet.ReadBit();
            packet.ReadBit("AutoCompleteMode");
            guid[1] = packet.ReadBit();
            guid[2] = packet.ReadBit();

            packet.ParseBitStream(guid, 0, 5, 3, 2, 4, 6, 1, 7);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.CMSG_QUESTGIVER_HELLO)]
        public static void HandleQuestgiverHello(Packet packet)
        {
            var guid = packet.StartBitStream(2, 3, 5, 4, 7, 6, 0, 1);
            packet.ParseBitStream(guid, 7, 1, 2, 6, 3, 5, 0, 4);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.CMSG_QUESTGIVER_QUERY_QUEST)]
        public static void HandleQuestgiverQueryQuest(Packet packet)
        {
            var guid = new byte[8];

            packet.ReadInt32("QuestID");

            guid[6] = packet.ReadBit();
            guid[3] = packet.ReadBit();
            guid[1] = packet.ReadBit();
            packet.ReadBit("Unk");
            guid[5] = packet.ReadBit();
            guid[4] = packet.ReadBit();
            guid[2] = packet.ReadBit();
            guid[7] = packet.ReadBit();
            guid[0] = packet.ReadBit();

            packet.ParseBitStream(guid, 5, 6, 2, 0, 1, 4, 3, 7);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.SMSG_QUESTGIVER_QUEST_COMPLETE)]
        public static void HandleQuestCompleted(Packet packet)
        {
            packet.AsHex();
            packet.ReadToEnd();
        }

        [Parser(Opcode.SMSG_QUESTGIVER_QUEST_DETAILS)]
        public static void HandleQuestgiverDetails510(Packet packet)
        {
            packet.AsHex();
            packet.ReadToEnd();
        }

        [Parser(Opcode.CMSG_QUESTGIVER_REQUEST_REWARD)]
        public static void HandleQuestgiverRequestReward(Packet packet)
        {
            packet.ReadInt32("QuestID");

            var guid = packet.StartBitStream(4, 1, 7, 0, 3, 2, 6, 5);
            packet.ParseBitStream(guid, 7, 2, 6, 4, 3, 1, 5, 0);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY)]
        public static void HandleQuestgiverStatusMultipleQuery(Packet packet)
        {
        }

        [Parser(Opcode.CMSG_QUESTGIVER_STATUS_QUERY)]
        public static void HandleQuestgiverStatusQuery(Packet packet)
        {
            var guid = packet.StartBitStream(2, 7, 3, 1, 6, 0, 4, 5);
            packet.ParseBitStream(guid, 2, 3, 6, 5, 4, 1, 0, 7);

            packet.WriteGuid("NPC Guid", guid);
        }

        [Parser(Opcode.CMSG_QUESTLOG_REMOVE_QUEST)]
        public static void HandleQuestlogRemoveQuest(Packet packet)
        {
            packet.ReadByte("Slot");
        }

        [Parser(Opcode.CMSG_QUEST_QUERY)]
        public static void HandleQuestQuery(Packet packet)
        {
            if (packet.Direction == Direction.ClientToServer)
            {
                packet.ReadInt32("QuestID");

                var guid = packet.StartBitStream(2, 3, 5, 1, 7, 0, 6, 4);
                packet.ParseBitStream(guid, 4, 2, 1, 3, 5, 7, 0, 6);

                packet.WriteGuid("NPC Guid", guid);
            }
            else
            {
                packet.WriteLine("              : SMSG_???");
                //packet.Opcode = (int)Opcode.CMSG_MOUNTSPECIAL_ANIM;
                packet.ReadToEnd();
            }
        }

        [Parser(Opcode.CMSG_REFORGE_ITEM)]
        public static void HandleReforgeItem(Packet packet)
        {
            packet.ReadInt32("Slot");
            packet.ReadInt32("ReforgeEntry");
            packet.ReadInt32("Bag");

            var guid = packet.StartBitStream(3, 5, 4, 6, 1, 0, 7, 2);
            packet.ParseBitStream(guid, 2, 0, 6, 4, 3, 5, 1, 7);

            packet.WriteGuid("NPC Guid", guid);
        }

        [HasSniffData]
        [Parser(Opcode.SMSG_QUEST_QUERY_RESPONSE)]
        public static void HandleQuestQueryResp(Packet packet)
        {
            var id = packet.ReadEntry("Quest ID");
            if (id.Value) // entry is masked
                return;

            bool QuestIsntAutoComplete = packet.ReadBit("Quest Isn't AutoComplete");

            if (QuestIsntAutoComplete)
            {
                var QuestEndTextLen = packet.ReadBits(9);
                var QuestTitleLen = packet.ReadBits(9);
                var QuestGiverTextWindowLen = packet.ReadBits(10);
                var QuestTurnTargetNameLen = packet.ReadBits(8);
                var QuestObjectivesLen = packet.ReadBits(12);
                var QuestGiverTargetNameLen = packet.ReadBits(8);
                var QuestDetailsLen = packet.ReadBits(12);
                var QuestTurnTextWindowLen = packet.ReadBits(10);
                var QuestCompletedTextLen = packet.ReadBits(11);
                var QuestObjectivesCount = packet.ReadBits("Objectives Count", 19);
                uint[,] ObjectivesCounts = new uint[QuestObjectivesCount,2];

                for (var i = 0; i < QuestObjectivesCount; ++i)
                {
                    ObjectivesCounts[i,0] = packet.ReadBits(22);
                    ObjectivesCounts[i,1] = packet.ReadBits(8);
                }


                packet.ResetBitReader();

                for (var i = 0; i < QuestObjectivesCount; ++i)
                {
                    packet.ReadUInt32("Unk UInt32", i);
                    packet.ReadWoWString("Objective Text", ObjectivesCounts[i, 1], i);
                    var reqType = packet.ReadEnum<QuestRequirementType>("Requirement Type", TypeCode.Byte, i);
                    packet.ReadByte("Unk Byte5", i);
                    packet.ReadUInt32("Requirement Count ", i);

                    for (var j = 0; j < ObjectivesCounts[i, 0]; j++)
                    {
                        packet.ReadUInt32("Unk Looped DWROD", i, j);
                    }

                    packet.ReadUInt32("Unk2 UInt32", i);

                    switch (reqType)
                    {
                        case QuestRequirementType.Creature:
                        case QuestRequirementType.Unknown3:
                            packet.ReadEntryWithName<Int32>(StoreNameType.Unit, "Required Creature ID", i);
                            break;
                        case QuestRequirementType.Item:
                            packet.ReadEntryWithName<Int32>(StoreNameType.Item, "Required Item ID", i);
                            break;
                        case QuestRequirementType.GameObject:
                            packet.ReadEntryWithName<Int32>(StoreNameType.GameObject, "Required GameObject ID", i);
                            break;
                        case QuestRequirementType.Currency:
                            packet.ReadUInt32("Required Currency ID", i);
                            break;
                        case QuestRequirementType.Spell:
                            packet.ReadEntryWithName<Int32>(StoreNameType.Spell, "Required Spell ID", i);
                            break;
                        case QuestRequirementType.Faction:
                            packet.ReadUInt32("Required Faction ID", i);
                            break;
                        default:
                            packet.ReadInt32("Required ID", i);
                            break;
                    }
                }

                packet.ReadUInt32("Reward ItemID Count4");
                packet.ReadUInt32("dword2E50");
                packet.ReadUInt32("Rewarded Spell");
                packet.ReadSingle("Point X");
                packet.ReadUInt32("NextQuestInChain");
                packet.ReadUInt32("dword2E68");
                packet.ReadSingle("RewardHonorMultiplier");
                packet.ReadUInt32("Reward ItemID 4");
                var type = packet.ReadEnum<QuestType>("Type", TypeCode.Int32);
                packet.ReadUInt32("dword2E94");
                packet.ReadUInt32("Reward ItemID Count2");
                var QuestGiverTargetName = packet.ReadWoWString("QuestGiverTargetName", QuestGiverTargetNameLen);
                packet.ReadUInt32("dword2E84");
                packet.ReadUInt32("RepObjectiveValue2");
                packet.ReadUInt32("dword2E58");
                packet.ReadUInt32("dword2E40");

                var quest = new QuestTemplate
                {
                    Method = QuestIsntAutoComplete ? QuestMethod.Normal : QuestMethod.AutoComplete,
                    Level = packet.ReadInt32("Level")
                };

                packet.ReadUInt32("BonusTalents");
                quest.CompletedText = packet.ReadWoWString("QuestCompletedText", QuestCompletedTextLen);
                quest.EndText = packet.ReadWoWString("QuestEndText", QuestEndTextLen);
                packet.ReadUInt32("dword2E08");
                packet.ReadUInt32("dword2E04");
                packet.ReadUInt32("XPId");
                packet.ReadUInt32("dword2E60");
                packet.ReadUInt32("dword2E0C");
                packet.ReadSingle("Point Y");
                quest.RewardMoneyMaxLevel = packet.ReadUInt32("Reward Money Max Level");
                packet.ReadUInt32("PointOpt");
                quest.QuestGiverTextWindow = packet.ReadWoWString("QuestGiverTextWindow", QuestGiverTextWindowLen);

                quest.RewardCurrencyId = new uint[4];
                quest.RewardCurrencyCount = new uint[4];
                for (var i = 0; i < 4; ++i)
                {
                    quest.RewardCurrencyId[i] = packet.ReadUInt32("Reward Currency ID", i);
                    quest.RewardCurrencyCount[i] = packet.ReadUInt32("Reward Currency Count", i);
                }

                quest.Objectives = packet.ReadWoWString("QuestObjectives", QuestObjectivesLen);
                packet.ReadUInt32("dword2E4C");
                packet.ReadUInt32("dword2E54");
                packet.ReadUInt32("RewardSpellCasted");

                const int repCount = 5;
                quest.RewardFactionId = new uint[repCount];
                quest.RewardFactionValueId = new int[repCount];
                quest.RewardFactionValueIdOverride = new uint[repCount];

                for(var i = 0; i < repCount; i++)
                {
                    quest.RewardFactionValueId[i] = packet.ReadInt32("Reward Reputation ID", i);
                    quest.RewardFactionValueIdOverride[i] = packet.ReadUInt32("Reward Reputation ID Override", i);
                    quest.RewardFactionId[i] = packet.ReadUInt32("Reward Faction ID", i);  
                }

                quest.QuestTurnTargetName = packet.ReadWoWString("QuestTurnTargetName", QuestTurnTargetNameLen);
                packet.ReadUInt32("dword2E78");
                packet.ReadUInt32("RewSkillID");
                packet.ReadUInt32("CharTittleID");
                packet.ReadUInt32("Reward Item1 ID");
                quest.ZoneOrSort = packet.ReadEnum<QuestSort>("Sort", TypeCode.Int32);
                packet.ReadUInt32("RewardHonorAddition");
                packet.ReadUInt32("dword2E8C");
                quest.RewardOrRequiredMoney = packet.ReadInt32("Reward Money");
                packet.ReadUInt32("dword2E48");
                quest.Details = packet.ReadWoWString("QuestDetails", QuestDetailsLen);
                packet.ReadUInt32("RewSkillPoints");
                packet.ReadUInt32("RepObjectiveFaction");
                packet.ReadUInt32("dword2E7C");
                packet.ReadUInt32("SoundAccept");
                packet.ReadUInt32("dword2E74");
                packet.ReadUInt32("MinimapTargetMask");
                packet.ReadUInt32("MinLevel");
                packet.ReadUInt32("dword2E44");
                packet.ReadUInt32("PlayersSlain");
                packet.ReadUInt32("Unk");
                packet.ReadUInt32("RequiredSpellID");
                packet.ReadUInt32("dword2E90");
                packet.ReadUInt32("SourceItemID");
                packet.ReadUInt32("dword2E80");
                packet.ReadUInt32("Reward ItemID Count1");
                packet.ReadUInt32("dword2E70");
                quest.SuggestedPlayers = packet.ReadUInt32("Suggested Players");             
                packet.ReadUInt32("PointMapId");
                quest.Title = packet.ReadWoWString("QuestTitle", QuestTitleLen);
                packet.ReadUInt32("Reward ItemID 3");
                packet.ReadUInt32("dword2E98");
                packet.ReadUInt32("dword2E5C");
                packet.ReadUInt32("SoundTurnIn");
                packet.ReadWoWString("QuestTurnTextWindow", QuestTurnTextWindowLen);
                packet.ReadUInt32("dword2E9C");
                packet.ReadUInt32("Reward ItemID 2");
                packet.ReadUInt32("Reward ItemID Count3");
                packet.ReadUInt32("dword2E64");
                quest.Flags = packet.ReadEnum<QuestFlags>("Flags", TypeCode.UInt32);
                packet.ReadUInt32("RewArenaPoints");
                packet.ReadUInt32("dword2E6C");
                packet.ReadUInt32("RepObjectiveFaction2");
                packet.ReadUInt32("dword2E88");

                packet.AddSniffData(StoreNameType.Quest, id.Key, "QUERY_RESPONSE");

                Storage.QuestTemplates.Add((uint)id.Key, quest, packet.TimeSpan);
            }
        }   
    }
}
