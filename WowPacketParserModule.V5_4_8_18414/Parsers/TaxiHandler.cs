using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;
using CoreParsers = WowPacketParser.Parsing.Parsers;

namespace WowPacketParserModule.V5_4_7_18019.Parsers
{
    public static class TaxiHandler
    {
        [Parser(Opcode.CMSG_ACTIVATETAXI)]
        public static void HandleActivateTaxi(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.CMSG_ACTIVATETAXIEXPRESS)]
        public static void HandleActivateTaxiExpress(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.CMSG_TAXINODE_STATUS_QUERY)]
        public static void HandleTaxiStatusQuery(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.CMSG_TAXIQUERYAVAILABLENODES)]
        public static void HandleTaxiQuery(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.CMSG_SET_TAXI_BENCHMARK_MODE)]
        public static void HandleSetTaxiBenchmarkMode(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.SMSG_ACTIVATETAXIREPLY)]
        public static void HandleActivateTaxiReply(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.SMSG_SHOWTAXINODES)]
        public static void HandleShowTaxiNodes(Packet packet)
        {
            var guid = new byte[8];

            var u = packet.ReadBit("Unk 1");

            if (u != 0)
            {
                guid = packet.StartBitStream(3, 0, 4, 2, 1, 7, 6, 5);
            }

            var count = packet.ReadBits("count", 24);

            if (u != 0)
            {
                packet.ParseBitStream(guid, 0, 3);
                packet.ReadInt32("unk6");
                packet.ParseBitStream(guid, 5, 2, 6, 1, 7, 4);
                packet.WriteGuid("Guid", guid);
            }

            for (int i = 0; i < count; i++)
                packet.ReadByte("NodeMask", i);
        }

        [Parser(Opcode.SMSG_TAXINODE_STATUS)]
        public static void HandleTaxiStatus(Packet packet)
        {
            packet.ReadToEnd();
        }

        [Parser(Opcode.SMSG_NEW_TAXI_PATH)]
        public static void HandleTaxiNull(Packet packet)
        {
        }
    }
}