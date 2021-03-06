using System;
using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V5_4_8_18414.Parsers
{
    public static class TaxiHandler
    {
        [Parser(Opcode.CMSG_ACTIVATE_TAXI)]
        public static void HandleActivateTaxi(Packet packet)
        {
            packet.ReadUInt32("Node 2 ID"); // 28
            packet.ReadUInt32("Node 1y ID"); // 24
            var guid = packet.StartBitStream(4, 0, 1, 2, 5, 6, 7, 3);
            packet.ReadXORBytes(guid, 1, 0, 6, 5, 2, 4, 3, 7);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.CMSG_ACTIVATE_TAXI_EXPRESS)]
        public static void HandleActivateTaxiExpress(Packet packet)
        {
            var guid = new byte[8];
            packet.StartBitStream(guid, 6, 7);
            var count = packet.ReadBits("Count", 22);
            packet.StartBitStream(guid, 2, 0, 4, 3, 1, 5);

            packet.ParseBitStream(guid, 2, 7, 1);
            for (var i = 0; i < count; i++)
                packet.ReadUInt32("Node", i);

            packet.ParseBitStream(guid, 0, 5, 3, 6, 4);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.CMSG_ENABLE_TAXI_NODE)]
        public static void HandleEnableTaxiMode(Packet packet)
        {
            var guid = packet.StartBitStream(3, 1, 6, 0, 4, 7, 2, 5);
            packet.ParseBitStream(guid, 1, 6, 3, 0, 4, 5, 7, 2);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.CMSG_TAXI_NODE_STATUS_QUERY)]
        public static void HandleTaxiStatusQuery(Packet packet)
        {
            var guid = packet.StartBitStream(7, 4, 1, 3, 0, 5, 2, 6);
            packet.ParseBitStream(guid, 7, 1, 5, 2, 4, 0, 6, 3);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.CMSG_TAXI_QUERY_AVAILABLE_NODES)]
        public static void HandleTaxiQuery(Packet packet)
        {
            var guid = packet.StartBitStream(7, 1, 0, 4, 2, 5, 6, 3);
            packet.ParseBitStream(guid, 0, 3, 7, 5, 2, 6, 4, 1);
            packet.WriteGuid("Guid", guid);
        }

        [Parser(Opcode.CMSG_SET_TAXI_BENCHMARK_MODE)]
        public static void HandleSetTaxiBenchmarkMode(Packet packet)
        {
            packet.ReadBool("Activate");
        }

        [Parser(Opcode.SMSG_ACTIVATE_TAXI_REPLY)]
        public static void HandleActivateTaxiReply(Packet packet)
        {
            packet.ReadBitsE<TaxiError>("Result", 4);
        }

        [Parser(Opcode.SMSG_SHOW_TAXI_NODES)]
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

        [Parser(Opcode.SMSG_TAXI_NODE_STATUS)]
        public static void HandleTaxiStatus(Packet packet)
        {
            var guid = new byte[8];
            guid[6] = packet.ReadBit();
            guid[2] = packet.ReadBit();
            guid[7] = packet.ReadBit();
            guid[5] = packet.ReadBit();
            guid[4] = packet.ReadBit();
            guid[1] = packet.ReadBit();
            packet.ReadBits("Status", 2);
            guid[3] = packet.ReadBit();
            guid[0] = packet.ReadBit();

            packet.ParseBitStream(guid, 0, 5, 2, 1, 4, 6, 7, 3);
            packet.WriteGuid("Guid", guid);
        }
    }
}
