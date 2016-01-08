using WowPacketParser.Enums;
using WowPacketParser.Misc;
using WowPacketParser.Parsing;

namespace WowPacketParserModule.V5_4_8_18414.Parsers
{
    public static class CurrencyHandler
    {
        [Parser(Opcode.SMSG_RESET_WEEKLY_CURRENCY)]
        public static void HandleCurrencyZero(Packet packet)
        {
        }
    }
}
