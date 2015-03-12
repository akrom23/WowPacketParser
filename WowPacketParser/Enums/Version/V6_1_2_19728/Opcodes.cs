﻿using System;
using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V6_1_2_19750
{
    public static class Opcodes_6_1_2
    {
        public static BiDictionary<Opcode, int> Opcodes(Direction direction)
        {
            switch (direction)
            {
                case Direction.ClientToServer:
                case Direction.BNClientToServer:
                    return ClientOpcodes;
                case Direction.ServerToClient:
                case Direction.BNServerToClient:
                    return ServerOpcodes;
            }
            return MiscOpcodes;
        }

        private static readonly BiDictionary<Opcode, int> ClientOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.CMSG_ADD_FRIEND, 0x039E},
            {Opcode.CMSG_ADD_IGNORE, 0x16A0},
            {Opcode.CMSG_AREATRIGGER, 0x0BDB},
            {Opcode.CMSG_AREA_SPIRIT_HEALER_QUERY, 0x1825},
            {Opcode.CMSG_ATTACKSTOP, 0x0A01},
            {Opcode.CMSG_ATTACKSWING, 0x0BF4},
            {Opcode.CMSG_AUCTION_HELLO_REQUEST, 0x1F82},
            {Opcode.CMSG_AUCTION_LIST_BIDDER_ITEMS, 0x1821},
            {Opcode.CMSG_AUCTION_PLACE_BID, 0x1822},
            {Opcode.CMSG_AUTH_CONTINUED_SESSION, 0x0485},
            {Opcode.CMSG_AUTH_SESSION, 0x03DD},
            {Opcode.CMSG_AUTOSTORE_LOOT_ITEM, 0x1BAC},
            {Opcode.CMSG_BANKER_ACTIVATE, 0x0CA5},
            {Opcode.CMSG_BATTLEMASTER_HELLO, 0x1605},
            {Opcode.CMSG_BATTLE_PAY_GET_PRODUCT_LIST_QUERY, 0x1616},
            {Opcode.CMSG_BATTLE_PET_MODIFY_NAME, 0x0B37},
            {Opcode.CMSG_BATTLE_PET_REQUEST_JOURNAL_LOCK, 0x0396},
            {Opcode.CMSG_BATTLE_PET_REQUEST_JOURNAL, 0x0F37},
            {Opcode.CMSG_BATTLE_PET_SUMMON, 0x0A9D},
            {Opcode.CMSG_BATTLEFIELD_JOIN, 0x1D36},
            {Opcode.CMSG_BATTLEFIELD_JOIN_RATED, 0x01AA},             // Unconfirmed
            {Opcode.CMSG_BATTLEFIELD_LEAVE, 0x0272},                  // Unconfirmed
            {Opcode.CMSG_BATTLEFIELD_PORT, 0x1D32},                   // Unconfirmed
            {Opcode.CMSG_BINDER_ACTIVATE, 0x1C71},
            {Opcode.CMSG_BLACK_MARKET_OPEN, 0x0F84},
            {Opcode.CMSG_BUY_BACK_ITEM, 0x1E84},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x1DE2},
            {Opcode.CMSG_BUY_ITEM, 0x1CE5},
            {Opcode.CMSG_CANCEL_AURA, 0x12FB},
            {Opcode.CMSG_CANCEL_CAST, 0x058A},
            {Opcode.CMSG_CANCEL_MOUNT_AURA, 0x012D},
            {Opcode.CMSG_CANCEL_TRADE, 0x0E0F},
            {Opcode.CMSG_CAN_DUEL, 0x0A38},
            {Opcode.CMSG_CAST_SPELL, 0x1274},
            {Opcode.CMSG_CHANGE_SUB_GROUP, 0x0AB7},                   // Unconfirmed
            {Opcode.CMSG_CHANNEL_BAN, 0x187E},
            {Opcode.CMSG_CHANNEL_INVITE, 0x142D},
            {Opcode.CMSG_CHANNEL_KICK, 0x153D},
            {Opcode.CMSG_CHANNEL_MODERATOR, 0x152D},
            {Opcode.CMSG_CHANNEL_MUTE, 0x1909},
            {Opcode.CMSG_CHANNEL_PASSWORD, 0x193A},
            {Opcode.CMSG_CHANNEL_SET_OWNER, 0x14CA},
            {Opcode.CMSG_CHANNEL_UNBAN, 0x155D},
            {Opcode.CMSG_CHANNEL_UNMODERATOR, 0x10AE},
            {Opcode.CMSG_CHANNEL_UNMUTE, 0x109A},
            {Opcode.CMSG_CHAR_CREATE, 0x1636},
            {Opcode.CMSG_CHAR_DELETE, 0x12B8},
            {Opcode.CMSG_CHAR_ENUM, 0x1696},
            {Opcode.CMSG_CLOSE_INTERACTION, 0x1C36},
            {Opcode.CMSG_CONVERT_RAID, 0x0A98},
            {Opcode.CMSG_CREATURE_QUERY, 0x0FD3},
            {Opcode.CMSG_DB_QUERY_BULK, 0x039F},
            {Opcode.CMSG_DELETE_EQUIPMENT_SET, 0x014A},
            {Opcode.CMSG_DEL_FRIEND, 0x163F},
            {Opcode.CMSG_DEL_IGNORE, 0x03C0},
            {Opcode.CMSG_DEPOSIT_REAGENT_BANK, 0x002A},
            {Opcode.CMSG_DESTROY_ITEM, 0x0A72},
            {Opcode.CMSG_DISCARDED_TIME_SYNC_ACKS, 0x0103},
            {Opcode.CMSG_DO_READY_CHECK, 0x139E},                     // Unconfirmed
            {Opcode.CMSG_DUEL_RESPONSE, 0x0C62},
            {Opcode.CMSG_EMOTE, 0x0E03},
            {Opcode.CMSG_ENABLE_NAGLE, 0x0B55},
            {Opcode.CMSG_ENABLE_TAXI_NODE, 0x0926},
            {Opcode.CMSG_EQUIPMENT_SET_SAVE, 0x09E2},
            {Opcode.CMSG_GAMEOBJ_REPORT_USE, 0x18B2},
            {Opcode.CMSG_GAMEOBJ_USE, 0x08B1},
            {Opcode.CMSG_GARRISON_REQUEST_BLUEPRINT_AND_SPECIALIZATION_DATA, 0x0B8C},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x06C8},
            {Opcode.CMSG_GARRISON_MISSION_BONUS_ROLL, 0x07D2},        // Unconfirmed
            {Opcode.CMSG_GARRISON_REQUEST_UPGRADEABLE, 0x12FA},
            {Opcode.CMSG_GET_GARRISON_INFO, 0x072D},
            {Opcode.CMSG_GET_ITEM_PURCHASE_DATA, 0x016E},
            {Opcode.CMSG_GET_MAIL_LIST, 0x1F04},
            {Opcode.CMSG_GET_UNDELETE_COOLDOWN_STATUS, 0x063D},
            {Opcode.CMSG_GM_TICKET_CREATE, 0x0A1E},
            {Opcode.CMSG_GM_TICKET_DELETE_TICKET, 0x129E},
            {Opcode.CMSG_GM_TICKET_GET_STATUS, 0x0A18},
            {Opcode.CMSG_GM_TICKET_GET_TICKET, 0x0717},
            {Opcode.CMSG_GM_TICKET_GET_WEB_TICKET, 0x1A3F},
            {Opcode.CMSG_GM_TICKET_RESPONSE_RESOLVE, 0x0217},
            {Opcode.CMSG_GM_TICKET_UPDATE_TEXT, 0x13A0},
            {Opcode.CMSG_GOSSIP_HELLO, 0x1C22},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x1E0C},
            {Opcode.CMSG_GUILD_BANK_ACTIVATE, 0x0DE2},
            {Opcode.CMSG_GUILD_BANK_REMAINING_WITHDRAW_MONEY_QUERY, 0x1417},
            {Opcode.CMSG_GUILD_PERMISSIONS_QUERY, 0x1878},
            {Opcode.CMSG_GUILD_BANK_BUY_TAB, 0x0F09},
            {Opcode.CMSG_GUILD_BANK_DEPOSIT_MONEY, 0x0832},           // Unconfirmed
            {Opcode.CMSG_GUILD_DECLINE_INVITATION, 0x1967},           // Unconfirmed
            {Opcode.CMSG_GUILD_QUERY, 0x12BE},
            {Opcode.CMSG_GUILD_REQUEST_PARTY_STATE, 0x0B5B},
            {Opcode.CMSG_GUILD_SET_ACHIEVEMENT_TRACKING, 0x1977},
            {Opcode.CMSG_INSPECT, 0x1C21},
            {Opcode.CMSG_JOIN_ARENA, 0x0865},                         // Unconfirmed
            {Opcode.CMSG_JOIN_ARENA_SKIRMISH, 0x1E01},
            {Opcode.CMSG_JOIN_CHANNEL, 0x152A},
            {Opcode.CMSG_LEARN_TALENTS, 0x0AAA},
            {Opcode.CMSG_LEAVE_CHANNEL, 0x113D},
            {Opcode.CMSG_LEAVE_GROUP, 0x179E},
            {Opcode.CMSG_LF_GUILD_BROWSE, 0x1A37},
            {Opcode.CMSG_LF_GUILD_DECLINE_RECRUIT, 0x1023},           // Unconfirmed
            {Opcode.CMSG_LFG_SET_COMMENT, 0x0615},                    // Unconfirmed
            {Opcode.CMSG_LIST_INVENTORY, 0x1922},
            {Opcode.CMSG_LOAD_SCREEN, 0x13C0},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x0F8C},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x0CA6},
            {Opcode.CMSG_LOG_DISCONNECT, 0x12D5},
            {Opcode.CMSG_LOG_STREAMING_ERROR, 0x12D6},
            {Opcode.CMSG_LOOT, 0x0BF1},
            {Opcode.CMSG_LOOT_METHOD, 0x0E3E},                        // Unconfirmed
            {Opcode.CMSG_LOOT_MONEY, 0x050A},
            {Opcode.CMSG_LOOT_RELEASE, 0x1A25},
            {Opcode.CMSG_MESSAGECHAT_AFK, 0x185E},
            {Opcode.CMSG_MESSAGECHAT_CHANNEL, 0x1D8A},
            {Opcode.CMSG_MESSAGECHAT_DND, 0x183E},
            {Opcode.CMSG_MESSAGECHAT_EMOTE, 0x1DAA},
            {Opcode.CMSG_MESSAGECHAT_GUILD, 0x14E9},
            {Opcode.CMSG_MESSAGECHAT_OFFICER, 0x155A},
            {Opcode.CMSG_MESSAGECHAT_SAY, 0x192A},
            {Opcode.CMSG_MESSAGECHAT_WHISPER, 0x103A},
            {Opcode.CMSG_MESSAGECHAT_YELL, 0x1CB9},
            {Opcode.CMSG_MOUNT_SET_FAVORITE, 0x061E},
            {Opcode.CMSG_MOVE_FALL_LAND, 0x095F},
            {Opcode.CMSG_MOVE_FALL_RESET, 0x0448},
            {Opcode.CMSG_MOVE_FORCE_FLIGHT_SPEED_CHANGE_ACK, 0x004F},
            {Opcode.CMSG_MOVE_FORCE_ROOT_ACK, 0x0008},
            {Opcode.CMSG_MOVE_FORCE_RUN_BACK_SPEED_CHANGE_ACK, 0x044C},
            {Opcode.CMSG_MOVE_FORCE_RUN_SPEED_CHANGE_ACK, 0x0407},
            {Opcode.CMSG_MOVE_FORCE_SWIM_SPEED_CHANGE_ACK, 0x0517},
            {Opcode.CMSG_MOVE_FORCE_UNROOT_ACK, 0x054C},
            {Opcode.CMSG_MOVE_FORCE_WALK_SPEED_CHANGE_ACK, 0x0813},
            {Opcode.CMSG_MOVE_HEARTBEAT, 0x055C},
            {Opcode.CMSG_MOVE_JUMP, 0x0158},
            {Opcode.CMSG_MOVE_REMOVE_MOVEMENT_FORCES, 0x0913},
            {Opcode.CMSG_MOVE_SET_COLLISION_HEIGHT_ACK, 0x0018},
            {Opcode.CMSG_MOVE_SET_FACING, 0x0803},
            {Opcode.CMSG_MOVE_SET_PITCH, 0x080F},
            {Opcode.CMSG_MOVE_SPLINE_DONE, 0x0514},
            {Opcode.CMSG_MOVE_START_ASCEND, 0x0510},
            {Opcode.CMSG_MOVE_START_BACKWARD, 0x0147},
            {Opcode.CMSG_MOVE_START_DESCEND, 0x0117},
            {Opcode.CMSG_MOVE_START_FORWARD, 0x0004},
            {Opcode.CMSG_MOVE_START_STRAFE_LEFT, 0x0844},
            {Opcode.CMSG_MOVE_START_STRAFE_RIGHT, 0x0957},
            {Opcode.CMSG_MOVE_START_SWIM, 0x0157},
            {Opcode.CMSG_MOVE_START_TURN_LEFT, 0x0918},
            {Opcode.CMSG_MOVE_START_TURN_RIGHT, 0x094B},
            {Opcode.CMSG_MOVE_STOP, 0x044B},
            {Opcode.CMSG_MOVE_STOP_ASCEND, 0x011C},
            {Opcode.CMSG_MOVE_STOP_STRAFE, 0x084B},
            {Opcode.CMSG_MOVE_STOP_SWIM, 0x081B},
            {Opcode.CMSG_MOVE_STOP_TURN, 0x0854},
            {Opcode.CMSG_MOVE_TIME_SKIPPED, 0x0903},
            {Opcode.CMSG_MOVE_WATER_WALK_ACK, 0x0C07},
            {Opcode.CMSG_NAME_QUERY, 0x0BBD},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x1E24},
            {Opcode.CMSG_OBJECT_UPDATE_FAILED, 0x0B2D},
            {Opcode.CMSG_OBJECT_UPDATE_RESCUED, 0x0A89},
            {Opcode.CMSG_OPEN_GARRISON_MISSION_NPC, 0x0BA9},
            {Opcode.CMSG_OPEN_SHIPMENT_NPC, 0x074F},
            {Opcode.CMSG_OPT_OUT_OF_LOOT, 0x1F89},                    // Unconfirmed
            {Opcode.CMSG_PARTY_INVITE, 0x12BD},
            {Opcode.CMSG_PARTY_INVITE_RESPONSE, 0x16BF},
            {Opcode.CMSG_PARTY_UNINVITE, 0x02B6},                     // Unconfirmed
            {Opcode.CMSG_PETITION_SHOW_LIST, 0x0CF5},
            {Opcode.CMSG_PET_ABANDON, 0x01CA},                        // Unconfirmed
            {Opcode.CMSG_PET_ACTION, 0x09F5},
            {Opcode.CMSG_PET_BATTLE_QUEUE_PROPOSE_MATCH_RESULT, 0x1ACF}, // Unconfirmed
            {Opcode.CMSG_PET_BATTLE_REQUEST_PVP, 0x16C8},             // Unconfirmed
            {Opcode.CMSG_PET_BATTLE_REQUEST_WILD, 0x1FAC},
            {Opcode.CMSG_PET_RENAME, 0x1618},
            {Opcode.CMSG_PET_SPELL_AUTOCAST, 0x0C75},                 // Unconfirmed
            {Opcode.CMSG_PET_STOP_ATTACK, 0x09A6},                    // Unconfirmed
            {Opcode.CMSG_PING, 0x12DE},
            {Opcode.CMSG_PLAYED_TIME, 0x0750},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0E98},
            {Opcode.CMSG_PORT_GRAVEYARD, 0x0C65},                     // Unconfirmed
            {Opcode.CMSG_QUERY_NEXT_MAIL_TIME, 0x08B6},
            {Opcode.CMSG_QUEST_POI_QUERY, 0x1240},
            {Opcode.CMSG_QUEST_QUERY, 0x0FA9},
            {Opcode.CMSG_QUESTGIVER_STATUS_MULTIPLE_QUERY, 0x0DA5},
            {Opcode.CMSG_QUESTGIVER_STATUS_QUERY, 0x0836},
            {Opcode.CMSG_QUEUED_MESSAGES_END, 0x027E},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x0B3E},
            {Opcode.CMSG_READY_CHECK_RESPONSE, 0x07B5},               // Unconfirmed
            {Opcode.CMSG_REAGENT_BANK_BUY_TAB, 0x1D75},
            {Opcode.CMSG_REALM_NAME_QUERY, 0x0F9F},
            {Opcode.CMSG_REORDER_CHARACTERS, 0x17B7},
            {Opcode.CMSG_REPAIR_ITEM, 0x19A2},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x0798},
            {Opcode.CMSG_REQUEST_CEMETERY_LIST, 0x0FD0},
            {Opcode.CMSG_REQUEST_PVP_OPTIONS_ENABLED, 0x029E},        // Unconfirmed
            {Opcode.CMSG_REQUEST_PVP_REWARDS, 0x06DC},                // Unconfirmed
            {Opcode.CMSG_REQUEST_RAID_INFO, 0x0A96},                  // Unconfirmed
            {Opcode.CMSG_REQUEST_RATED_INFO, 0x0A40},                 // Unconfirmed
            {Opcode.CMSG_REQUEST_STABLED_PETS, 0x01CA},
            {Opcode.CMSG_REQUEST_VEHICLE_EXIT, 0x054D},
            {Opcode.CMSG_RIDE_VEHICLE_INTERACT, 0x1ED0},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x0EC7},
            {Opcode.CMSG_SCENE_PLAYBACK_CANCELED, 0x0A8C},
            {Opcode.CMSG_SCENE_PLAYBACK_COMPLETE, 0x0BD0},
            {Opcode.CMSG_SELL_ITEM, 0x1931},
            {Opcode.CMSG_SET_ACHIEVEMENTS_HIDDEN, 0x16D0},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x133F},
            {Opcode.CMSG_SET_ACTIVE_MOVER, 0x0108},
            {Opcode.CMSG_SET_ASSISTANT_LEADER, 0x0395},               // Unconfirmed
            {Opcode.CMSG_SET_CONTACT_NOTES, 0x0B3D},
            {Opcode.CMSG_SET_DUNGEON_DIFFICULTY, 0x0E16},
            {Opcode.CMSG_SET_EVERYONE_IS_ASSISTANT, 0x1716},          // Unconfirmed
            {Opcode.CMSG_SET_FACTION_AT_WAR, 0x1C66},
            {Opcode.CMSG_SET_FACTION_INACTIVE, 0x1862},
            {Opcode.CMSG_SET_LOOT_SPECIALIZATION, 0x00D72},
            {Opcode.CMSG_SET_PARTY_LEADER, 0x131D},
            {Opcode.CMSG_SET_PVP, 0x1BC7},
            {Opcode.CMSG_SET_RAID_DIFFICULTY, 0x0397},
            {Opcode.CMSG_SET_ROLE, 0x0398},
            {Opcode.CMSG_SET_SELECTION, 0x0E8C},
            {Opcode.CMSG_SET_SPECIALIZATION, 0x0759},
            {Opcode.CMSG_SET_TITLE, 0x1650},
            {Opcode.CMSG_SET_TRADE_CURRENCY, 0x06F2},
            {Opcode.CMSG_SET_WATCHED_FACTION, 0x1E82},
            {Opcode.CMSG_SHOWING_CLOAK, 0x0F04},
            {Opcode.CMSG_SHOWING_HELM, 0x0C36},
            {Opcode.CMSG_SHOW_FRIENDS, 0x0EC0},
            {Opcode.CMSG_SORT_BAGS, 0x0AF1},
            {Opcode.CMSG_SORT_BANK_BAGS, 0x659},
            {Opcode.CMSG_SORT_REAGENT_BANK_BAGS, 0x06D2},
            {Opcode.CMSG_SPELLCLICK, 0x1DB2},
            {Opcode.CMSG_SPIRIT_HEALER_ACTIVATE, 0x1E8A},
            {Opcode.CMSG_SPLIT_ITEM, 0x052B},
            {Opcode.CMSG_START_SPECTATOR_WAR_GAME, 0x16B5},           // Unconfirmed
            {Opcode.CMSG_START_WARGAME, 0x012BF},                     // Unconfirmed
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_BUG, 0x06B6},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_COMPLAINT, 0x16C0},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_SUGGESTION, 0x1A16},
            {Opcode.CMSG_SUSPEND_COMMS_ACK, 0x1375},
            {Opcode.CMSG_SUSPEND_TOKEN_RESPONSE, 0x1255},
            {Opcode.CMSG_SWAP_INV_ITEM, 0x003C},
            {Opcode.CMSG_SWAP_ITEM, 0x0438},
            {Opcode.CMSG_SWAP_SUB_GROUPS, 0x0F98},                    // Unconfirmed
            {Opcode.CMSG_TABARD_VENDOR_ACTIVATE, 0x07FC},
            {Opcode.CMSG_TAXI_NODE_STATUS_QUERY, 0x0CF1},
            {Opcode.CMSG_TEXT_EMOTE, 0x01EE},
            {Opcode.CMSG_TIME_SYNC_RESPONSE, 0x0550},
            {Opcode.CMSG_TOGGLE_PVP, 0x1BAB},
            {Opcode.CMSG_TOTEM_DESTROYED, 0x19B5},
            {Opcode.CMSG_TRAINER_LIST, 0x0D21},
            {Opcode.CMSG_TRANSMOGRIFY_ITEMS, 0x03F1},
            {Opcode.CMSG_UI_TIME_REQUEST, 0x0316},
            {Opcode.CMSG_UNLEARN_SPECIALIZATION, 0x0708},             // Unconfirmed
            {Opcode.CMSG_UNLEARN_TALENTS, 0x0FA9},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x1637},
            {Opcode.CMSG_USE_EQUIPMENT_SET, 0x083C},
            {Opcode.CMSG_USE_ITEM, 0x06D0},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x0F48},
            {Opcode.CMSG_VOID_STORAGE_QUERY, 0x03D3},
            {Opcode.CMSG_VOID_STORAGE_TRANSFER, 0x0E07},
            {Opcode.CMSG_VOID_STORAGE_UNLOCK, 0x0AA1},
            {Opcode.CMSG_WARDEN_DATA, 0x02B8},
            {Opcode.CMSG_WARGAME_RESPONSE, 0x0E3F},                   // Unconfirmed
            {Opcode.CMSG_WHO, 0x079E},
        };

        private static readonly BiDictionary<Opcode, int> ServerOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.SMSG_ACCOUNT_CRITERIA_UPDATE, 0x1635},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x16B8},
            {Opcode.SMSG_ACCOUNT_MOUNT_UPDATE, 0x079D},
            {Opcode.SMSG_ACHIEVEMENT_DELETED, 0x1CF2},
            {Opcode.SMSG_ACHIEVEMENT_EARNED, 0x06C0},
            {Opcode.SMSG_ACTION_BUTTONS, 0x03C0},
            {Opcode.SMSG_ADDON_INFO, 0x1715},
            {Opcode.SMSG_ADJUST_SPLINE_DURATION, 0x0E97},
            {Opcode.SMSG_AE_LOOT_TARGET_ACK, 0x1C72},
            {Opcode.SMSG_AE_LOOT_TARGETS, 0x1835},
            {Opcode.SMSG_AI_REACTION, 0x1739},
            {Opcode.SMSG_ALL_ACCOUNT_CRITERIA, 0x0392},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x163D},
            {Opcode.SMSG_ALL_GUILD_ACHIEVEMENTS, 0x14AB},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x0EBD},
            {Opcode.SMSG_ATTACKSTART, 0x1971},
            {Opcode.SMSG_ATTACKSTOP, 0x17C0},
            {Opcode.SMSG_ATTACKSWING_ERROR, 0x1D66},
            {Opcode.SMSG_ATTACKSWING_LANDED_LOG, 0x1865},
            {Opcode.SMSG_AUCTION_CLOSED_NOTIFICATION, 0x0EA0},
            {Opcode.SMSG_AUCTION_COMMAND_RESULT, 0x13B6},
            {Opcode.SMSG_AUCTION_HELLO_RESPONSE, 0x1338},
            {Opcode.SMSG_AUCTION_LIST_BIDDER_ITEMS_RESULT, 0x02B9},
            {Opcode.SMSG_AUCTION_LIST_ITEMS_RESULT, 0x0E01},
            {Opcode.SMSG_AUCTION_LIST_OWNER_ITEMS_RESULT, 0x0FA0},
            {Opcode.SMSG_AUCTION_LIST_PENDING_SALES_RESULT, 0x0E1F},
            {Opcode.SMSG_AUCTION_OUTBID_NOTIFICATION, 0x073E},
            {Opcode.SMSG_AUCTION_OWNER_BID_NOTIFICATION, 0x0612},
            {Opcode.SMSG_AUCTION_REPLICATE_RESPONSE, 0x161D},
            {Opcode.SMSG_AUCTION_WON_NOTIFICATION, 0x161A},
            {Opcode.SMSG_AURA_POINTS_DEPLETED, 0x119D},
            {Opcode.SMSG_AURA_UPDATE, 0x1999},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x007E},
            {Opcode.SMSG_AUTH_RESPONSE, 0x18F6},
            {Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE, 0x120E},
            {Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE, 0x02C0},
            {Opcode.SMSG_BATTLE_PET_CAGE_DATE_ERROR, 0x1972},
            {Opcode.SMSG_BATTLE_PET_DELETED, 0x0A40},
            {Opcode.SMSG_BATTLE_PET_ERROR, 0x1DB2},
            {Opcode.SMSG_BATTLE_PET_HEALED, 0x162E},
            {Opcode.SMSG_BATTLE_PET_JOURNAL, 0x1C35},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x023F},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_DENIED, 0x1346},
            {Opcode.SMSG_BATTLE_PET_LICENSE_CHANGED, 0x131A},
            {Opcode.SMSG_BATTLE_PET_RESTORED, 0x1D62},
            {Opcode.SMSG_BATTLE_PET_REVOKED, 0x0F0C},
            {Opcode.SMSG_BATTLE_PET_TRAP_LEVEL, 0x0638},
            {Opcode.SMSG_BATTLE_PET_UPDATES, 0x1340},
            {Opcode.SMSG_BATTLEFIELD_LIST, 0x0338},
            {Opcode.SMSG_BATTLEFIELD_STATUS_QUEUED, 0x163F},
            {Opcode.SMSG_BINDER_CONFIRM, 0x19E5},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x0399},
            {Opcode.SMSG_CALENDAR_SEND_NUM_PENDING, 0x129E},
            {Opcode.SMSG_CANCEL_AUTO_REPEAT, 0x1931},
            {Opcode.SMSG_CANCEL_COMBAT, 0x0220},
            {Opcode.SMSG_CANCEL_ORPHAN_SPELL_VISUAL, 0x10ED},
            {Opcode.SMSG_CANCEL_SCENE, 0x0AB8},
            {Opcode.SMSG_CANCEL_SPELL_VISUAL_KIT, 0x112E},
            {Opcode.SMSG_CANCEL_SPELL_VISUAL, 0x106D},
            {Opcode.SMSG_CAN_DUEL_RESULT, 0x1831},
            {Opcode.SMSG_CAST_FAILED, 0x1409},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x15EF},
            {Opcode.SMSG_CHANNEL_NOTIFY_JOINED, 0x14C3},
            {Opcode.SMSG_CHANNEL_NOTIFY_LEFT, 0x19CF},
            {Opcode.SMSG_CHANNEL_START, 0x103E},
            {Opcode.SMSG_CHANNEL_UPDATE, 0x10D9},
            {Opcode.SMSG_CHARACTER_LOGIN_FAILED, 0x0FBD},
            {Opcode.SMSG_CHAR_CREATE, 0x16BA},
            {Opcode.SMSG_CHAR_DELETE, 0x06B8},
            {Opcode.SMSG_CHAR_ENUM, 0x18F1},
            {Opcode.SMSG_CHAR_FACTION_CHANGE, 0x0F8A},
            {Opcode.SMSG_CHUNKED_PACKET, 0x0039},
            {Opcode.SMSG_CLEAR_TARGET, 0x1DF5},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x0E09},
            {Opcode.SMSG_COIN_REMOVED, 0x069D},
            {Opcode.SMSG_COMBAT_EVENT_FAILED, 0x0792},
            {Opcode.SMSG_COMPLETE_SHIPMENT_RESPONSE, 0x1CA5},
            {Opcode.SMSG_COMPRESSED_PACKET, 0x007D},
            {Opcode.SMSG_CONQUEST_FORMULA_CONSTANTS, 0x1C75},
            {Opcode.SMSG_CONTACT_LIST, 0x039F},
            {Opcode.SMSG_CONTACT_STATUS, 0x0F03},
            {Opcode.SMSG_COOLDOWN_EVENT, 0x0922},
            {Opcode.SMSG_CORPSE_LOCATION, 0x0ABF},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x02BA},
            {Opcode.SMSG_CORPSE_TRANSPORT_QUERY, 0x1E2E},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x1A15},
            {Opcode.SMSG_CRITERIA_DELETED, 0x1E2F},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x0716},
            {Opcode.SMSG_DANCE_STUDIO_CREATE_RESULT, 0x09E6},
            {Opcode.SMSG_DB_REPLY, 0x09A5},
            {Opcode.SMSG_DEATH_RELEASE_LOC, 0x0A17},
            {Opcode.SMSG_DEFENSE_MESSAGE, 0x11E3},
            {Opcode.SMSG_DISMOUNT, 0x03BF},
            {Opcode.SMSG_DISPLAY_PROMOTION, 0x0236},
            {Opcode.SMSG_DISPLAY_TOAST, 0x1CF1},
            {Opcode.SMSG_DUEL_COUNTDOWN, 0x0318},
            {Opcode.SMSG_DUEL_REQUESTED, 0x0BBF},
            {Opcode.SMSG_DURABILITY_DAMAGE_DEATH, 0x1936},
            {Opcode.SMSG_EMOTE, 0x0FC0},
            {Opcode.SMSG_ENCHANTMENT_LOG, 0x0DA6},
            {Opcode.SMSG_ENVIRONMENTALDAMAGELOG, 0x183E},
            {Opcode.SMSG_EQUIPMENT_SET_LIST, 0x079E},
            {Opcode.SMSG_EXPLORATION_EXPERIENCE, 0x0692},
            {Opcode.SMSG_FAILED_PLAYER_CONDITION, 0x0A9E},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x0B3E},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS_GLUE_SCREEN, 0x0A1D},
            {Opcode.SMSG_FINAL_CHUNK, 0x005A},
            {Opcode.SMSG_FLIGHT_SPLINE_SYNC, 0x1647},
            {Opcode.SMSG_GAMEOBJECT_CUSTOM_ANIM, 0x0797},
            {Opcode.SMSG_GAMEOBJECT_DESPAWN, 0x0E0A},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x1345},
            {Opcode.SMSG_GAME_TIME_SET, 0x0F9F},
            {Opcode.SMSG_GAME_TIME_UPDATE, 0x0D76},
            {Opcode.SMSG_GARRISON_BUILDING_ACTIVATED, 0x01B0},
            {Opcode.SMSG_GARRISON_FOLLOWER_CHANGED_XP, 0x01DB},
            {Opcode.SMSG_GARRISON_LIST_FOLLOWERS_CHEAT_RESULT, 0x0988},
            {Opcode.SMSG_GARRISON_REMOTE_INFO, 0x08B4},
            {Opcode.SMSG_GET_GARRISON_INFO_RESULT, 0x0084},
            {Opcode.SMSG_GM_TICKET_CASE_STATUS, 0x17B7},
            {Opcode.SMSG_GM_TICKET_GET_TICKET_RESPONSE, 0x0B95},
            {Opcode.SMSG_GM_TICKET_RESOLVE_RESPONSE, 0x0A37},
            {Opcode.SMSG_GM_TICKET_RESPONSE, 0x07B6},
            {Opcode.SMSG_GM_TICKET_RESPONSE_ERROR, 0x08A2},
            {Opcode.SMSG_GM_TICKET_STATUS_UPDATE, 0x13B7},
            {Opcode.SMSG_GM_TICKET_SYSTEM_STATUS, 0x0B16},
            {Opcode.SMSG_GM_TICKET_UPDATE, 0x0925},
            {Opcode.SMSG_GOSSIP_COMPLETE, 0x0010},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x0077},
            {Opcode.SMSG_GROUP_NEW_LEADER, 0x0C32},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_DELETED, 0x11AB},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_EARNED, 0x14B8},
            {Opcode.SMSG_GUILD_ACHIEVEMENT_MEMBERS, 0x10B3},
            {Opcode.SMSG_GUILD_BANK_REMAINING_WITHDRAW_MONEY, 0x1588},
            {Opcode.SMSG_GUILD_COMMAND_RESULT, 0x11A0},
            {Opcode.SMSG_GUILD_CRITERIA_DELETED, 0x118F},
            {Opcode.SMSG_GUILD_CRITERIA_UPDATE, 0x14AC},
            {Opcode.SMSG_GUILD_EVENT_BANK_CONTENTS_CHANGED, 0x11AF},
            {Opcode.SMSG_GUILD_EVENT_BANK_MONEY_CHANGED, 0x10C0},
            {Opcode.SMSG_GUILD_EVENT_DISBANDED, 0x14A3},
            {Opcode.SMSG_GUILD_EVENT_LOG_QUERY_RESULTS, 0x119B},
            {Opcode.SMSG_GUILD_EVENT_MOTD, 0x10BF},
            {Opcode.SMSG_GUILD_EVENT_NEW_LEADER, 0x1587},
            {Opcode.SMSG_GUILD_EVENT_PLAYER_JOINED, 0x1198},
            {Opcode.SMSG_GUILD_EVENT_PLAYER_LEFT, 0x109B},
            {Opcode.SMSG_GUILD_EVENT_PRESENCE_CHANGE, 0x10AF},
            {Opcode.SMSG_GUILD_EVENT_RANK_CHANGED, 0x10BC},
            {Opcode.SMSG_GUILD_EVENT_RANKS_UPDATED, 0x11BC},
            {Opcode.SMSG_GUILD_EVENT_TAB_ADDED, 0x1084},
            {Opcode.SMSG_GUILD_EVENT_TAB_DELETED, 0x1190},
            {Opcode.SMSG_GUILD_EVENT_TAB_MODIFIED, 0x14A8},
            {Opcode.SMSG_GUILD_EVENT_TAB_TEXT_CHANGED, 0x1497},
            {Opcode.SMSG_GUILD_PARTY_STATE_RESPONSE, 0x1094},
            {Opcode.SMSG_GUILD_PERMISSIONS_QUERY_RESULTS, 0x1097},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x1194},
            {Opcode.SMSG_GUILD_RANKS, 0x14B0},
            {Opcode.SMSG_GUILD_ROSTER, 0x1498},
            {Opcode.SMSG_HEALTH_UPDATE, 0x07BD},
            {Opcode.SMSG_HIGHEST_THREAT_UPDATE, 0x0F35},
            {Opcode.SMSG_HOTFIX_NOTIFY_BLOB, 0x1D71},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x1C32},
            {Opcode.SMSG_INITIAL_SETUP, 0x0238},
            {Opcode.SMSG_INITIAL_SPELLS, 0x109A},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x09E1},
            {Opcode.SMSG_INSPECT_RESULT, 0x1D22},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_CHANGE_PRIORITY, 0x0C72},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_DISENGAGE_UNIT, 0x1DB6},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_END, 0x16B5},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_ENGAGE_UNIT, 0x08E6},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_GAIN_COMBAT_RESURRECTION_CHARGE, 0x0866},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_IN_COMBAT_RESURRECTION, 0x1717},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_OBJECTIVE_COMPLETE, 0x0735},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_OBJECTIVE_START, 0x0B3D},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_OBJECTIVE_UPDATE, 0x1219},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_PHASE_SHIFT_CHANGED, 0x0F89},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_START, 0x06B9},
            {Opcode.SMSG_INSTANCE_ENCOUNTER_TIMER_START, 0x0619},
            {Opcode.SMSG_INSTANCE_GROUP_SIZE_CHANGED, 0x1C22},
            {Opcode.SMSG_INSTANCE_INFO, 0x12B5},
            {Opcode.SMSG_INSTANCE_RESET, 0x0825},
            {Opcode.SMSG_INSTANCE_RESET_FAILED, 0x0F40},
            {Opcode.SMSG_INSTANCE_SAVE_CREATED, 0x0DA2},
            {Opcode.SMSG_INVALIDATE_PLAYER, 0x0B9D},
            {Opcode.SMSG_ITEM_BONUS_DEBUG, 0x1CB6},
            {Opcode.SMSG_ITEM_COOLDOWN, 0x0D35},
            {Opcode.SMSG_ITEM_ENCHANT_TIME_UPDATE, 0x1E30},
            {Opcode.SMSG_ITEM_EXPIRE_PURCHASE_REFUND, 0x1798},
            {Opcode.SMSG_ITEM_PURCHASE_REFUND_RESULT, 0x1620},
            {Opcode.SMSG_ITEM_PUSH_RESULT, 0x0B15},
            {Opcode.SMSG_ITEM_TIME_UPDATE, 0x1DB5},
            {Opcode.SMSG_LEARNED_SPELLS, 0x183D},
            {Opcode.SMSG_LEVELUP_INFO, 0x0B36},
            {Opcode.SMSG_LFG_PLAYER_INFO, 0x0E32},
            {Opcode.SMSG_LIST_INVENTORY, 0x0E40},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x139A},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x0D65},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0A98},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x08B2},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0E95},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x0731},
            {Opcode.SMSG_LOOT_CONTENTS, 0x02BF},
            {Opcode.SMSG_LOOT_LIST, 0x08E2},
            {Opcode.SMSG_LOOT_MONEY_NOTIFY, 0x17A0},
            {Opcode.SMSG_LOOT_RELEASE_ALL, 0x1C61},
            {Opcode.SMSG_LOOT_RELEASE, 0x06B7},
            {Opcode.SMSG_LOOT_REMOVED, 0x0F15},
            {Opcode.SMSG_LOOT_RESPONSE, 0x122D},
            {Opcode.SMSG_LOSS_OF_CONTROL_AURA_UPDATE, 0x0737},
            {Opcode.SMSG_MAIL_LIST_RESULT, 0x0871},
            {Opcode.SMSG_MAIL_QUERY_NEXT_TIME_RESULT, 0x0F8C},
            {Opcode.SMSG_MESSAGECHAT, 0x11E7},
            {Opcode.SMSG_MODIFY_COOLDOWN, 0x0832},
            {Opcode.SMSG_MOTD, 0x18E8},
            {Opcode.SMSG_MOVE_DISABLE_CAN_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x1EAC},
            {Opcode.SMSG_MOVE_ENABLE_CAN_TRANSITION_BETWEEN_SWIM_AND_FLY, 0x0BCF},
            {Opcode.SMSG_MOVE_KNOCK_BACK, 0x1BA3},
            {Opcode.SMSG_MOVE_ROOT, 0x018A},
            {Opcode.SMSG_MOVE_SET_ACTIVE_MOVER, 0x025B},
            {Opcode.SMSG_MOVE_SET_ANIM_KIT, 0x0D25},
            {Opcode.SMSG_MOVE_SET_CAN_FLY, 0x012A},
            {Opcode.SMSG_MOVE_SET_CAN_TURN_WHILE_FALLING, 0x0EA1},
            {Opcode.SMSG_MOVE_SET_COLLISION_HEIGHT, 0x1BA4},
            {Opcode.SMSG_MOVE_SET_COMPOUND_STATE, 0x02D0},
            {Opcode.SMSG_MOVE_SET_FEATHER_FALL, 0x0674},
            {Opcode.SMSG_MOVE_SET_FLIGHT_BACK_SPEED, 0x030D},
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x046D},
            {Opcode.SMSG_MOVE_SET_HOVER, 0x0B21},
            {Opcode.SMSG_MOVE_SET_IGNORE_MOVEMENT_FORCES, 0x1347},
            {Opcode.SMSG_MOVE_SET_LAND_WALK, 0x0AC7},
            {Opcode.SMSG_MOVE_SET_NORMAL_FALL, 0x04EE},
            {Opcode.SMSG_MOVE_SET_PITCH_RATE, 0x0B2C},
            {Opcode.SMSG_MOVE_SET_RUN_BACK_SPEED, 0x03DA},
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x1EA9},
            {Opcode.SMSG_MOVE_SET_SWIM_BACK_SPEED, 0x0605},
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x1628},
            {Opcode.SMSG_MOVE_SET_TURN_RATE, 0x1E24},
            {Opcode.SMSG_MOVE_SET_VEHICLE_REC_ID, 0x1A29},
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x0F28},
            {Opcode.SMSG_MOVE_SET_WATER_WALK, 0x035C},
            {Opcode.SMSG_MOVE_SPLINE_DISABLE_GRAVITY, 0x1A21},
            {Opcode.SMSG_MOVE_SPLINE_ENABLE_GRAVITY, 0x0252},
            {Opcode.SMSG_MOVE_SPLINE_ROOT, 0x02D1},
            {Opcode.SMSG_MOVE_SPLINE_SET_FEATHER_FALL, 0x0F30},
            {Opcode.SMSG_MOVE_SPLINE_SET_FLIGHT_BACK_SPEED, 0x1F22},
            {Opcode.SMSG_MOVE_SPLINE_SET_FLIGHT_SPEED, 0x1208},
            {Opcode.SMSG_MOVE_SPLINE_SET_FLYING, 0x0B2A},
            {Opcode.SMSG_MOVE_SPLINE_SET_HOVER, 0x1B21},
            {Opcode.SMSG_MOVE_SPLINE_SET_LAND_WALK, 0x1A28},
            {Opcode.SMSG_MOVE_SPLINE_SET_NORMAL_FALL, 0x037A},
            {Opcode.SMSG_MOVE_SPLINE_SET_PITCH_RATE, 0x02C8},
            {Opcode.SMSG_MOVE_SPLINE_SET_RUN_BACK_SPEED, 0x0305},
            {Opcode.SMSG_MOVE_SPLINE_SET_RUN_MODE, 0x1A8C},
            {Opcode.SMSG_MOVE_SPLINE_SET_RUN_SPEED, 0x164F},
            {Opcode.SMSG_MOVE_SPLINE_SET_SWIM_BACK_SPEED, 0x0A47},
            {Opcode.SMSG_MOVE_SPLINE_SET_SWIM_SPEED, 0x0E22},
            {Opcode.SMSG_MOVE_SPLINE_SET_TURN_RATE, 0x035B},
            {Opcode.SMSG_MOVE_SPLINE_SET_WALK_BACK_SPEED, 0x1205},
            {Opcode.SMSG_MOVE_SPLINE_SET_WALK_MODE, 0x0B09},
            {Opcode.SMSG_MOVE_SPLINE_SET_WATER_WALK, 0x0EAB},
            {Opcode.SMSG_MOVE_SPLINE_START_SWIM, 0x1A81},
            {Opcode.SMSG_MOVE_SPLINE_STOP_SWIM, 0x1A0B},
            {Opcode.SMSG_MOVE_SPLINE_UNROOT, 0x1BA2},
            {Opcode.SMSG_MOVE_SPLINE_UNSET_FLYING, 0x1A2C},
            {Opcode.SMSG_MOVE_SPLINE_UNSET_HOVER, 0x0E47},
            {Opcode.SMSG_MOVE_TELEPORT, 0x1206},
            {Opcode.SMSG_MOVE_UNROOT, 0x046E},
            {Opcode.SMSG_MOVE_UNSET_CAN_FLY, 0x03DC},
            {Opcode.SMSG_MOVE_UNSET_CAN_TURN_WHILE_FALLING, 0x124F},
            {Opcode.SMSG_MOVE_UNSET_HOVER, 0x0651},
            {Opcode.SMSG_MOVE_UNSET_IGNORE_MOVEMENT_FORCES, 0x0F2B},
            {Opcode.SMSG_MOVE_UPDATE, 0x0F2C},
            {Opcode.SMSG_MOVE_UPDATE_COLLISION_HEIGHT, 0x1A04},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_BACK_SPEED, 0x032E},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_SPEED, 0x0628},
            {Opcode.SMSG_MOVE_UPDATE_KNOCK_BACK, 0x0273},
            {Opcode.SMSG_MOVE_UPDATE_PITCH_RATE, 0x1AAC},
            {Opcode.SMSG_MOVE_UPDATE_REMOVE_MOVEMENT_FORCE, 0x1F47},
            {Opcode.SMSG_MOVE_UPDATE_RUN_BACK_SPEED, 0x1B82},
            {Opcode.SMSG_MOVE_UPDATE_RUN_SPEED, 0x06DA},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_BACK_SPEED, 0x0B06},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_SPEED, 0x1A83},
            {Opcode.SMSG_MOVE_UPDATE_TELEPORT, 0x1F21},
            {Opcode.SMSG_MOVE_UPDATE_TURN_RATE, 0x000A},
            {Opcode.SMSG_MOVE_UPDATE_WALK_SPEED, 0x1F29},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x0C71},
            {Opcode.SMSG_NEW_WORLD, 0x0A15},
            {Opcode.SMSG_NPC_TEXT_UPDATE, 0x071E},
            {Opcode.SMSG_NUKE_ALL_OBJECTS_DUE_TO_SEAMLESS_PORT, 0x0E20},
            {Opcode.SMSG_ON_MONSTER_MOVE, 0x0EA9},
            {Opcode.SMSG_PARTY_INVITE, 0x0E83},
            {Opcode.SMSG_PARTY_KILL_LOG, 0x120F},
            {Opcode.SMSG_PERIODICAURALOG, 0x14E9},
            {Opcode.SMSG_PET_ACTION_SOUND, 0x0875},
            {Opcode.SMSG_PET_DISMISS_SOUND, 0x0237},
            {Opcode.SMSG_PET_GUIDS, 0x0245},
            {Opcode.SMSG_PET_NAME_QUERY_RESPONSE, 0x023D},
            {Opcode.SMSG_PET_STABLE_LIST, 0x0D36},
            {Opcode.SMSG_PLAY_MUSIC, 0x09F1},
            {Opcode.SMSG_PLAY_OBJECT_SOUND, 0x16BF},
            {Opcode.SMSG_PLAY_ONE_SHOT_ANIM_KIT, 0x0FB6},
            {Opcode.SMSG_PLAY_ORPHAN_SPELL_VISUAL, 0x191E},
            {Opcode.SMSG_PLAY_SCENE, 0x09B1},
            {Opcode.SMSG_PLAY_SOUND, 0x1298},
            {Opcode.SMSG_PLAY_SPELL_VISUAL_KIT, 0x1859},
            {Opcode.SMSG_PLAY_SPELL_VISUAL, 0x11EA},
            {Opcode.SMSG_PLAY_TIME_WARNING, 0x0972},
            {Opcode.SMSG_PLAYED_TIME, 0x1875},
            {Opcode.SMSG_PONG, 0x011D},
            {Opcode.SMSG_POWER_UPDATE, 0x0F96},
            {Opcode.SMSG_PRE_RESSURECT, 0x058D},
            {Opcode.SMSG_PVP_SEASON, 0x1D61},
            {Opcode.SMSG_QUERY_BATTLE_PET_NAME_RESPONSE, 0x17BD},
            {Opcode.SMSG_QUERY_ITEM_TEXT_RESPONSE, 0x1D36},
            {Opcode.SMSG_QUERY_PETITION_RESPONSE, 0x1872},
            {Opcode.SMSG_QUERY_TIME_RESPONSE, 0x0CF1},
            {Opcode.SMSG_QUESTGIVER_INVALID_QUEST, 0x0543},
            {Opcode.SMSG_QUESTGIVER_OFFER_REWARD, 0x0547},
            {Opcode.SMSG_QUESTGIVER_QUEST_COMPLETE, 0x004C},
            {Opcode.SMSG_QUESTGIVER_QUEST_DETAILS, 0x0534},
            {Opcode.SMSG_QUESTGIVER_QUEST_FAILED, 0x007F},
            {Opcode.SMSG_QUESTGIVER_QUEST_LIST, 0x0843},
            {Opcode.SMSG_QUESTGIVER_REQUEST_ITEMS, 0x0528},
            {Opcode.SMSG_QUESTGIVER_STATUS, 0x052F},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0x0814},
            {Opcode.SMSG_QUEST_COMPLETION_NPC_RESPONSE, 0x0540},
            {Opcode.SMSG_QUEST_POI_QUERY_RESPONSE, 0x051F},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x0817},
            {Opcode.SMSG_QUEST_UPDATE_ADD_CREDIT, 0x006C},
            {Opcode.SMSG_QUEST_UPDATE_ADD_CREDIT_SIMPLE, 0x0070},
            {Opcode.SMSG_QUEST_UPDATE_ADD_PVP_CREDIT, 0x005B},
            {Opcode.SMSG_QUEST_UPDATE_COMPLETE, 0x0480},
            {Opcode.SMSG_QUEST_UPDATE_FAILED, 0x0573},
            {Opcode.SMSG_QUEST_UPDATE_FAILED_TIMER, 0x0108},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x121A},
            {Opcode.SMSG_REALM_QUERY_RESPONSE, 0x0DF2},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0119},
            {Opcode.SMSG_REFRESH_SPELL_HISTORY, 0x153D},
            {Opcode.SMSG_REQUEST_CEMETERY_LIST_RESPONSE, 0x1398},
            {Opcode.SMSG_RESPOND_INSPECT_ACHIEVEMENTS, 0x1A2E},
            {Opcode.SMSG_RESUME_CAST_BAR, 0x10F9},
            {Opcode.SMSG_RESUME_COMMS, 0x003A},
            {Opcode.SMSG_SELL_RESPONSE, 0x133E},
            {Opcode.SMSG_SEND_SPELL_CHARGES, 0x187E},
            {Opcode.SMSG_SEND_SPELL_HISTORY, 0x142D},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x155D},
            {Opcode.SMSG_SERVER_FIRST_ACHIEVEMENTS, 0x0337},
            {Opcode.SMSG_SETUP_CURRENCY, 0x1CE2},
            {Opcode.SMSG_SET_AI_ANIM_KIT, 0x1295},
            {Opcode.SMSG_SET_ALL_TASK_PROGRESS, 0x0ABD},
            {Opcode.SMSG_SET_ANIM_TIER, 0x0317},
            {Opcode.SMSG_SET_CURRENCY, 0x0336},
            {Opcode.SMSG_SET_DUNGEON_DIFFICULTY, 0x19F2},
            {Opcode.SMSG_SET_FACTION_AT_WAR, 0x0F9D},
            {Opcode.SMSG_SET_FACTION_STANDING, 0x1210},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x192A},
            {Opcode.SMSG_SET_MELEE_ANIM_KIT, 0x0BB5},
            {Opcode.SMSG_SET_PCT_SPELL_MODIFIER, 0x1DAA},
            {Opcode.SMSG_SET_PHASE_SHIFT_CHANGE, 0x18A6},
            {Opcode.SMSG_SET_PLAY_HOVER_ANIM, 0x0F9E},
            {Opcode.SMSG_SET_PROFICIENCY, 0x0D75},
            {Opcode.SMSG_SET_RAID_DIFFICULTY, 0x0E8B},
            {Opcode.SMSG_SET_TIME_ZONE_INFORMATION, 0x073A},
            {Opcode.SMSG_SET_VEHICLE_REC_ID, 0x0F1F},
            {Opcode.SMSG_SET_VIGNETTE, 0x1691},
            {Opcode.SMSG_SHOW_BANK, 0x179F},
            {Opcode.SMSG_SHOW_MAILBOX, 0x1871},
            {Opcode.SMSG_SHOW_NEUTRAL_PLAYER_FACTION_SELECT_UI, 0x0331},
            {Opcode.SMSG_SHOW_TAXI_NODES, 0x0FB8},
            {Opcode.SMSG_SHOW_TRADE_SKILL_RESPONSE, 0x1E0D},
            {Opcode.SMSG_SPECIAL_MOUNT_ANIM, 0x1319},
            {Opcode.SMSG_SPELL_CATEGORY_COOLDOWN, 0x15FA},
            {Opcode.SMSG_SPELL_COOLDOWN, 0x1D2A},
            {Opcode.SMSG_SPELL_DELAYED, 0x14FD},
            {Opcode.SMSG_SPELL_DISPEL_LOG, 0x10FD},
            {Opcode.SMSG_SPELL_ENERGIZE_LOG, 0x1C8D},
            {Opcode.SMSG_SPELL_ENERGIZE_LOG2, 0x1C3D},
            {Opcode.SMSG_SPELL_EXECUTE_LOG, 0x1D9A},
            {Opcode.SMSG_SPELL_FAILED_OTHER, 0x10CE},
            {Opcode.SMSG_SPELL_FAILURE, 0x1CAD},
            {Opcode.SMSG_SPELL_GO, 0x1CB9},
            {Opcode.SMSG_SPELL_HEAL_LOG, 0x155A},
            {Opcode.SMSG_SPELL_INSTAKILL_LOG, 0x11FE},
            {Opcode.SMSG_SPELL_INTERRUPT_LOG, 0x185E},
            {Opcode.SMSG_SPELL_MISS_LOG, 0x147A},
            {Opcode.SMSG_SPELL_MULTISTRIKE_EFFECT, 0x150A},
            {Opcode.SMSG_SPELL_NON_MELEE_DAMAGE_LOG, 0x141E},
            {Opcode.SMSG_SPELL_START, 0x14BA},
            {Opcode.SMSG_SPELL_UPDATE_CHAIN_TARGETS, 0x1419},
            {Opcode.SMSG_STAND_STATE_UPDATE, 0x0B37},
            {Opcode.SMSG_START_ELAPSED_TIMERS, 0x063D},
            {Opcode.SMSG_START_MIRROR_TIMER, 0x0861},
            {Opcode.SMSG_STOP_ELAPSED_TIMER, 0x0795},
            {Opcode.SMSG_STOP_MIRROR_TIMER, 0x0BB6},
            {Opcode.SMSG_SUPPRESS_NPC_GREETINGS, 0x07A0},
            {Opcode.SMSG_SUSPEND_COMMS, 0x001E},
            {Opcode.SMSG_TALENTS_INFO, 0x1862},
            {Opcode.SMSG_TAXINODE_STATUS, 0x0EBF},
            {Opcode.SMSG_TEXT_EMOTE, 0x0696},
            {Opcode.SMSG_THREAT_CLEAR, 0x0F1D},
            {Opcode.SMSG_THREAT_REMOVE, 0x0BBE},
            {Opcode.SMSG_THREAT_UPDATE, 0x0AC0},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x1E23},
            {Opcode.SMSG_TITLE_EARNED, 0x1E03},
            {Opcode.SMSG_TRAINER_LIST, 0x17B2},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0E82},
            {Opcode.SMSG_UI_TIME, 0x0DA1},
            {Opcode.SMSG_UNDELETE_COOLDOWN_STATUS_RESPONSE, 0x0B9F},
            {Opcode.SMSG_UNLEARNED_SPELLS, 0x151E},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x1698},
            {Opcode.SMSG_UPDATE_DUNGEON_ENCOUNTER_FOR_LOOT, 0x0B3A},
            {Opcode.SMSG_UPDATE_EXPANSION_LEVEL, 0x1236},
            {Opcode.SMSG_UPDATE_INSTANCE_OWNERSHIP, 0x12BF},
            {Opcode.SMSG_UPDATE_LAST_INSTANCE, 0x0971},
            {Opcode.SMSG_UPDATE_OBJECT, 0x1CB2},
            {Opcode.SMSG_UPDATE_TASK_PROGRESS, 0x1317},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x1DF1},
            {Opcode.SMSG_WARDEN_DATA, 0x0E96},
            {Opcode.SMSG_WEATHER, 0x0397},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x1199},
            {Opcode.SMSG_WHO, 0x11CC},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x0FB5},
            {Opcode.SMSG_XP_GAIN_ABORTED, 0x19F5},
            {Opcode.SMSG_XP_GAIN_ENABLED, 0x0EB7},
            {Opcode.SMSG_ZONE_UNDER_ATTACK, 0x14CF}
        };

        private static readonly BiDictionary<Opcode, int> MiscOpcodes = new BiDictionary<Opcode, int>();
    }
}
