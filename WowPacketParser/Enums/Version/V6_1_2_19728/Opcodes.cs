﻿using System;
using WowPacketParser.Misc;

namespace WowPacketParser.Enums.Version.V6_1_2_19728
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
            {Opcode.CMSG_ATTACKSTOP, 0x0A01},
            {Opcode.CMSG_ATTACKSWING, 0x0BF4},
            {Opcode.CMSG_AUCTION_LIST_BIDDER_ITEMS, 0x1821},
            {Opcode.CMSG_AUCTION_PLACE_BID, 0x1822},
            {Opcode.CMSG_AUTH_CONTINUED_SESSION, 0x0485},
            {Opcode.CMSG_AUTH_SESSION, 0x03DD},
            {Opcode.CMSG_BANKER_ACTIVATE, 0x0CA5},
            {Opcode.CMSG_BATTLE_PAY_GET_PRODUCT_LIST_QUERY, 0x1616},
            {Opcode.CMSG_BATTLE_PET_MODIFY_NAME, 0x0B37},
            {Opcode.CMSG_BATTLEFIELD_JOIN, 0x1D36},
            {Opcode.CMSG_BATTLEFIELD_JOIN_RATED, 0x01AA},             // Unconfirmed
            {Opcode.CMSG_BATTLEFIELD_LEAVE, 0x0272},                  // Unconfirmed
            {Opcode.CMSG_BATTLEFIELD_PORT, 0x1D32},                   // Unconfirmed
            {Opcode.CMSG_BUY_BACK_ITEM, 0x1E84},
            {Opcode.CMSG_BUY_BANK_SLOT, 0x1DE2},
            {Opcode.CMSG_BUY_ITEM, 0x1CE5},
            {Opcode.CMSG_CANCEL_AURA, 0x12FB},
            {Opcode.CMSG_CANCEL_CAST, 0x058A},
            {Opcode.CMSG_CANCEL_TRADE, 0x0E0F},                       // Unconfirmed
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
            {Opcode.CMSG_CONVERT_RAID, 0x0A98},                       // Unconfirmed
            {Opcode.CMSG_CREATURE_QUERY, 0x0FD3},
            {Opcode.CMSG_DB_QUERY_BULK, 0x0836},
            {Opcode.CMSG_DELETE_EQUIPMENT_SET, 0x014A},
            {Opcode.CMSG_DEL_FRIEND, 0x163F},
            {Opcode.CMSG_DEL_IGNORE, 0x03C0},
            {Opcode.CMSG_DEPOSIT_REAGENT_BANK, 0x002A},
            {Opcode.CMSG_DO_READY_CHECK, 0x139E},                     // Unconfirmed
            {Opcode.CMSG_DUEL_RESPONSE, 0x0C62},
            {Opcode.CMSG_EMOTE, 0x01AD},
            {Opcode.CMSG_EQUIPMENT_SET_SAVE, 0x09E2},
            {Opcode.CMSG_GAMEOBJECT_QUERY, 0x06C8},
            {Opcode.CMSG_GARRISON_MISSION_BONUS_ROLL, 0x07D2},        // Unconfirmed
            {Opcode.CMSG_GET_UNDELETE_COOLDOWN_STATUS, 0x063D},
            {Opcode.CMSG_GM_TICKET_CREATE, 0x0A1E},
            {Opcode.CMSG_GM_TICKET_DELETE_TICKET, 0x129E},
            {Opcode.CMSG_GM_TICKET_GET_STATUS, 0x0A18},
            {Opcode.CMSG_GM_TICKET_GET_TICKET, 0x0717},
            {Opcode.CMSG_GM_TICKET_GET_WEB_TICKET, 0x1A3F},
            {Opcode.CMSG_GM_TICKET_RESPONSE_RESOLVE, 0x0217},
            {Opcode.CMSG_GM_TICKET_UPDATE_TEXT, 0x13A0},
            {Opcode.CMSG_GOSSIP_HELLO, 0x1C22},
            {Opcode.CMSG_GOSSIP_SELECT_OPTION, 0x1E0C},               // Unconfirmed
            {Opcode.CMSG_GUILD_BANK_BUY_TAB, 0x0F09},
            {Opcode.CMSG_GUILD_BANK_DEPOSIT_MONEY, 0x0832},           // Unconfirmed
            {Opcode.CMSG_GUILD_DECLINE_INVITATION, 0x1967},           // Unconfirmed
            {Opcode.CMSG_GUILD_QUERY, 0x12BE},
            {Opcode.CMSG_JOIN_ARENA, 0x0865},                         // Unconfirmed
            {Opcode.CMSG_JOIN_ARENA_SKIRMISH, 0x1E01},
            {Opcode.CMSG_JOIN_CHANNEL, 0x152A},
            {Opcode.CMSG_LEARN_TALENTS, 0x0AAA},
            {Opcode.CMSG_LEAVE_CHANNEL, 0x113D},
            {Opcode.CMSG_LEAVE_GROUP, 0x179E},                        // Unconfirmed
            {Opcode.CMSG_LF_GUILD_BROWSE, 0x1A37},
            {Opcode.CMSG_LF_GUILD_DECLINE_RECRUIT, 0x1023},           // Unconfirmed
            {Opcode.CMSG_LFG_SET_COMMENT, 0x0615},                    // Unconfirmed
            {Opcode.CMSG_LIST_INVENTORY, 0x1922},
            {Opcode.CMSG_LOAD_SCREEN, 0x13C0},
            {Opcode.CMSG_LOGOUT_CANCEL, 0x0F8C},
            {Opcode.CMSG_LOGOUT_REQUEST, 0x0CA6},
            {Opcode.CMSG_LOG_DISCONNECT, 0x12D5},
            {Opcode.CMSG_LOOT_METHOD, 0x0E3E},                        // Unconfirmed
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
            {Opcode.CMSG_MOVE_HEARTBEAT, 0x055C},
            {Opcode.CMSG_MOVE_JUMP, 0x0158},
            {Opcode.CMSG_MOVE_SET_FACING, 0x0803},
            {Opcode.CMSG_MOVE_SET_PITCH, 0x080F},
            {Opcode.CMSG_MOVE_START_ASCEND, 0x0510},
            {Opcode.CMSG_MOVE_START_BACKWARD, 0x0147},
            {Opcode.CMSG_MOVE_START_DESCEND, 0x0117},
            {Opcode.CMSG_MOVE_START_FORWARD, 0x0004},
            {Opcode.CMSG_MOVE_START_STRAFE_LEFT, 0x0844},
            {Opcode.CMSG_MOVE_START_STRAFE_RIGHT, 0x0957},
            {Opcode.CMSG_MOVE_START_TURN_LEFT, 0x0918},
            {Opcode.CMSG_MOVE_START_TURN_RIGHT, 0x094B},
            {Opcode.CMSG_MOVE_STOP, 0x044B},
            {Opcode.CMSG_MOVE_STOP_ASCEND, 0x011C},
            {Opcode.CMSG_MOVE_STOP_STRAFE, 0x084B},
            {Opcode.CMSG_MOVE_STOP_TURN, 0x0854},
            {Opcode.CMSG_NAME_QUERY, 0x0BBD},
            {Opcode.CMSG_NPC_TEXT_QUERY, 0x1E24},
            {Opcode.CMSG_OBJECT_UPDATE_RESCUED, 0x0DA5},
            {Opcode.CMSG_OPT_OUT_OF_LOOT, 0x1F89},                    // Unconfirmed
            {Opcode.CMSG_PARTY_INVITE, 0x12BD},
            {Opcode.CMSG_PARTY_INVITE_RESPONSE, 0x16BF},              // Unconfirmed
            {Opcode.CMSG_PARTY_UNINVITE, 0x02B6},                     // Unconfirmed
            {Opcode.CMSG_PET_ABANDON, 0x01CA},                        // Unconfirmed
            {Opcode.CMSG_PET_BATTLE_QUEUE_PROPOSE_MATCH_RESULT, 0x1ACF}, // Unconfirmed
            {Opcode.CMSG_PET_BATTLE_REQUEST_PVP, 0x16C8},             // Unconfirmed
            {Opcode.CMSG_PET_RENAME, 0x1618},                         // Unconfirmed
            {Opcode.CMSG_PET_SPELL_AUTOCAST, 0x0C75},                 // Unconfirmed
            {Opcode.CMSG_PET_STOP_ATTACK, 0x09A6},                    // Unconfirmed
            {Opcode.CMSG_PING, 0x12DE},
            {Opcode.CMSG_PLAYED_TIME, 0x0750},
            {Opcode.CMSG_PLAYER_LOGIN, 0x0E98},
            {Opcode.CMSG_PORT_GRAVEYARD, 0x0C65},                     // Unconfirmed
            {Opcode.CMSG_QUEUED_MESSAGES_END, 0x027E},
            {Opcode.CMSG_RANDOMIZE_CHAR_NAME, 0x0B3E},
            {Opcode.CMSG_READY_CHECK_RESPONSE, 0x07B5},               // Unconfirmed
            {Opcode.CMSG_REAGENT_BANK_BUY_TAB, 0x1D75},
            {Opcode.CMSG_REORDER_CHARACTERS, 0x17B7},
            {Opcode.CMSG_REQUEST_ACCOUNT_DATA, 0x0798},
            {Opcode.CMSG_REQUEST_PVP_OPTIONS_ENABLED, 0x029E},        // Unconfirmed
            {Opcode.CMSG_REQUEST_PVP_REWARDS, 0x06DC},                // Unconfirmed
            {Opcode.CMSG_REQUEST_RAID_INFO, 0x0A96},                  // Unconfirmed
            {Opcode.CMSG_REQUEST_RATED_INFO, 0x0A40},                 // Unconfirmed
            {Opcode.CMSG_ROUTER_CLIENT_LOG_STREAMING_ERROR, 0x12D6},
            {Opcode.CMSG_SAVE_CUF_PROFILES, 0x0EC7},
            {Opcode.CMSG_SELL_ITEM, 0x1931},
            {Opcode.CMSG_SET_ACHIEVEMENTS_HIDDEN, 0x16D0},
            {Opcode.CMSG_SET_ACTION_BUTTON, 0x133F},
            {Opcode.CMSG_SET_ACTIVE_MOVER, 0x0108},
            {Opcode.CMSG_SET_ASSISTANT_LEADER, 0x0395},               // Unconfirmed
            {Opcode.CMSG_SET_CONTACT_NOTES, 0x0B3D},
            {Opcode.CMSG_SET_DUNGEON_DIFFICULTY, 0x0E16},             // Unconfirmed
            {Opcode.CMSG_SET_EVERYONE_IS_ASSISTANT, 0x1716},          // Unconfirmed
            {Opcode.CMSG_SET_FACTION_AT_WAR, 0x1C66},                 // Unconfirmed
            {Opcode.CMSG_SET_FACTION_INACTIVE, 0x1862},
            {Opcode.CMSG_SET_LOOT_SPECIALIZATION, 0x00D72},
            {Opcode.CMSG_SET_PARTY_LEADER, 0x131D},                   // Unconfirmed
            {Opcode.CMSG_SET_PVP, 0x1BC7},
            {Opcode.CMSG_SET_RAID_DIFFICULTY, 0x0397},                // Unconfirmed
            {Opcode.CMSG_SET_ROLE, 0x0398},
            {Opcode.CMSG_SET_SELECTION, 0x0E8C},
            {Opcode.CMSG_SET_SPECIALIZATION, 0x0759},
            {Opcode.CMSG_SET_TITLE, 0x1650},
            {Opcode.CMSG_SET_WATCHED_FACTION, 0x1E82},
            {Opcode.CMSG_SHOW_FRIENDS, 0x0EC0},
            {Opcode.CMSG_SHOWING_CLOAK, 0x0F04},
            {Opcode.CMSG_SHOWING_HELM, 0x0C36},
            {Opcode.CMSG_SORT_BAGS, 0x0AF1},
            {Opcode.CMSG_SORT_BANK_BAGS, 0x659},                      // Unconfirmed
            {Opcode.CMSG_SORT_REAGENT_BANK_BAGS, 0x06D2},
            {Opcode.CMSG_SPLIT_ITEM, 0x052B},
            {Opcode.CMSG_START_SPECTATOR_WAR_GAME, 0x16B5},           // Unconfirmed
            {Opcode.CMSG_START_WARGAME, 0x012BF},                     // Unconfirmed
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_BUG, 0x06B6},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_COMPLAINT, 0x16C0},
            {Opcode.CMSG_SUPPORT_TICKET_SUBMIT_SUGGESTION, 0x1A16},   // Unconfirmed
            {Opcode.CMSG_SUSPEND_COMMS_ACK, 0x1375},
            {Opcode.CMSG_SUSPEND_TOKEN_RESPONSE, 0x1255},
            {Opcode.CMSG_SWAP_INV_ITEM, 0x003C},
            {Opcode.CMSG_SWAP_ITEM, 0x0438},
            {Opcode.CMSG_SWAP_SUB_GROUPS, 0x0F98},                    // Unconfirmed
            {Opcode.CMSG_TIME_SYNC_RESPONSE, 0x0550},
            {Opcode.CMSG_TOGGLE_PVP, 0x1BAB},
            {Opcode.CMSG_TRANSMOGRIFY_ITEMS, 0x03F1},
            {Opcode.CMSG_UI_TIME_REQUEST, 0x0316},
            {Opcode.CMSG_UNLEARN_SPECIALIZATION, 0x0708},             // Unconfirmed
            {Opcode.CMSG_UNLEARN_TALENTS, 0x0FA9},
            {Opcode.CMSG_UPDATE_ACCOUNT_DATA, 0x1637},
            {Opcode.CMSG_USE_EQUIPMENT_SET, 0x083C},
            {Opcode.CMSG_USE_ITEM, 0x06D0},
            {Opcode.CMSG_VIOLENCE_LEVEL, 0x0F48},
            {Opcode.CMSG_VOID_STORAGE_TRANSFER, 0x0E07},
            {Opcode.CMSG_VOID_STORAGE_UNLOCK, 0x0AA1},
            {Opcode.CMSG_WARDEN_DATA, 0x02B8},
            {Opcode.CMSG_WARGAME_RESPONSE, 0x0E3F},                   // Unconfirmed
            {Opcode.CMSG_WHO, 0x079E},                                // Unconfirmed
        };

        private static readonly BiDictionary<Opcode, int> ServerOpcodes = new BiDictionary<Opcode, int>
        {
            {Opcode.SMSG_ACCOUNT_CRITERIA_UPDATE, 0x1635},
            {Opcode.SMSG_ACCOUNT_DATA_TIMES, 0x16B8},
            {Opcode.SMSG_ACCOUNT_MOUNT_UPDATE, 0x079D},
            //{Opcode.SMSG_ACCOUNT_TOYS_UPDATE, 0x0000},
            //{Opcode.SMSG_ACTION_BUTTONS, 0x0000},
            {Opcode.SMSG_ADDON_INFO, 0x1715},
            {Opcode.SMSG_AI_REACTION, 0x1739},
            {Opcode.SMSG_ALL_ACCOUNT_CRITERIA, 0x0392},
            {Opcode.SMSG_ALL_ACHIEVEMENT_DATA, 0x163D},
            {Opcode.SMSG_ATTACKERSTATEUPDATE, 0x0EBD},
            {Opcode.SMSG_ATTACKSTART, 0x1971},
            {Opcode.SMSG_AUCTION_COMMAND_RESULT, 0x13B6},
            {Opcode.SMSG_AURA_UPDATE, 0x1999},
            {Opcode.SMSG_AUCTION_LIST_BIDDER_ITEMS_RESULT, 0x02B9},
            {Opcode.SMSG_AUTH_CHALLENGE, 0x007E},
            {Opcode.SMSG_AUTH_RESPONSE, 0x18F6},
            {Opcode.SMSG_BATTLE_PAY_GET_DISTRIBUTION_LIST_RESPONSE, 0x120E},
            {Opcode.SMSG_BATTLE_PAY_GET_PURCHASE_LIST_RESPONSE, 0x02C0},
            {Opcode.SMSG_BATTLE_PET_JOURNAL_LOCK_ACQUIRED, 0x023F},
            {Opcode.SMSG_BINDPOINTUPDATE, 0x0399},
            {Opcode.SMSG_CAN_DUEL_RESULT, 0x0BBF},
            {Opcode.SMSG_CHANNEL_NOTIFY, 0x15EF},
            {Opcode.SMSG_CHANNEL_NOTIFY_JOINED, 0x14C3},
            {Opcode.SMSG_CHANNEL_NOTIFY_LEFT, 0x19CF},
            {Opcode.SMSG_CHANNEL_START, 0x103E},
            {Opcode.SMSG_CHARACTER_LOGIN_FAILED, 0x0FBD},
            {Opcode.SMSG_CHAR_CREATE, 0x16BA},
            {Opcode.SMSG_CHAR_DELETE, 0x06B8},
            {Opcode.SMSG_CHAR_ENUM, 0x18F1},
            //{Opcode.SMSG_CHUNKED_PACKET, 0x0000},
            {Opcode.SMSG_CLIENTCACHE_VERSION, 0x0E09},
            //{Opcode.SMSG_COMPRESSED_PACKET, 0x0000},
            {Opcode.SMSG_CONTACT_LIST, 0x039F},
            {Opcode.SMSG_CONTACT_STATUS, 0x0F03},
            {Opcode.SMSG_CORPSE_RECLAIM_DELAY, 0x02BA},
            {Opcode.SMSG_CREATURE_QUERY_RESPONSE, 0x1A15},
            {Opcode.SMSG_CRITERIA_UPDATE, 0x0716},
            {Opcode.SMSG_DANCE_STUDIO_CREATE_RESULT, 0x09E6},
            {Opcode.SMSG_DB_REPLY, 0x09A5},
            {Opcode.SMSG_DISPLAY_PROMOTION, 0x0236},
            {Opcode.SMSG_DUEL_COUNTDOWN, 0x0318},
            {Opcode.SMSG_DUEL_REQUESTED, 0x0BBF},
            //{Opcode.SMSG_EQUIPMENT_SET_LIST, 0x0000},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS, 0x0B3E},
            {Opcode.SMSG_FEATURE_SYSTEM_STATUS_GLUE_SCREEN, 0x0A1D},
            //{Opcode.SMSG_FINAL_CHUNK, 0x0000},
            {Opcode.SMSG_GAMEOBJECT_QUERY_RESPONSE, 0x1345},
            {Opcode.SMSG_GM_TICKET_CASE_STATUS, 0x17B7},
            {Opcode.SMSG_GM_TICKET_GET_TICKET_RESPONSE, 0x07B6},
            {Opcode.SMSG_GM_TICKET_RESOLVE_RESPONSE, 0x0A37},
            {Opcode.SMSG_GM_TICKET_RESPONSE, 0x07B6},
            {Opcode.SMSG_GM_TICKET_RESPONSE_ERROR, 0x08A2},
            {Opcode.SMSG_GM_TICKET_STATUS_UPDATE, 0x13B7},
            {Opcode.SMSG_GM_TICKET_SYSTEM_STATUS, 0x0B16},
            {Opcode.SMSG_GM_TICKET_UPDATE, 0x0925},
            {Opcode.SMSG_GOSSIP_MESSAGE, 0x0077},
            {Opcode.SMSG_GROUP_NEW_LEADER, 0x0C32},
            {Opcode.SMSG_GUILD_COMMAND_RESULT, 0x11A0},
            {Opcode.SMSG_GUILD_QUERY_RESPONSE, 0x1194},
            {Opcode.SMSG_HOTFIX_NOTIFY_BLOB, 0x1D71},
            {Opcode.SMSG_INITIALIZE_FACTIONS, 0x1C32},
            {Opcode.SMSG_INITIAL_SETUP, 0x0238},
            //{Opcode.SMSG_INITIAL_SPELLS, 0x0000},
            {Opcode.SMSG_INIT_WORLD_STATES, 0x09E1},
            {Opcode.SMSG_LEARNED_SPELLS, 0x183D},
            {Opcode.SMSG_LEVELUP_INFO, 0x0B36},
            {Opcode.SMSG_LIST_INVENTORY, 0x0E40},
            {Opcode.SMSG_LOAD_CUF_PROFILES, 0x139A},
            {Opcode.SMSG_LOGIN_SETTIMESPEED, 0x0D65},
            {Opcode.SMSG_LOGIN_VERIFY_WORLD, 0x0A98},
            {Opcode.SMSG_LOGOUT_CANCEL_ACK, 0x08B2},
            {Opcode.SMSG_LOGOUT_COMPLETE, 0x0E95},
            {Opcode.SMSG_LOGOUT_RESPONSE, 0x0731},
            {Opcode.SMSG_MESSAGECHAT, 0x11E7},
            {Opcode.SMSG_MOTD, 0x18E8},
            {Opcode.SMSG_MOVE_SET_FLIGHT_BACK_SPEED, 0x030D},
            {Opcode.SMSG_MOVE_SET_FLIGHT_SPEED, 0x046D},
            {Opcode.SMSG_MOVE_SET_PITCH_RATE, 0x0B2C},
            {Opcode.SMSG_MOVE_SET_RUN_BACK_SPEED, 0x03DA},
            {Opcode.SMSG_MOVE_SET_RUN_SPEED, 0x1EA9},
            {Opcode.SMSG_MOVE_SET_SWIM_BACK_SPEED, 0x0605},
            {Opcode.SMSG_MOVE_SET_SWIM_SPEED, 0x1628},
            {Opcode.SMSG_MOVE_SET_TURN_RATE, 0x1E24},
            {Opcode.SMSG_MOVE_SET_WALK_SPEED, 0x0F28},
            {Opcode.SMSG_MOVE_UPDATE, 0x0F2C},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_BACK_SPEED, 0x032E},
            {Opcode.SMSG_MOVE_UPDATE_FLIGHT_SPEED, 0x0628},
            {Opcode.SMSG_MOVE_UPDATE_PITCH_RATE, 0x1AAC},
            {Opcode.SMSG_MOVE_UPDATE_REMOVE_MOVEMENT_FORCE, 0x1F47},
            {Opcode.SMSG_MOVE_UPDATE_RUN_BACK_SPEED, 0x1B82},
            {Opcode.SMSG_MOVE_UPDATE_RUN_SPEED, 0x06DA},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_BACK_SPEED, 0x0B06},
            {Opcode.SMSG_MOVE_UPDATE_SWIM_SPEED, 0x1A83},
            {Opcode.SMSG_MOVE_UPDATE_TURN_RATE, 0x000A},
            {Opcode.SMSG_MOVE_UPDATE_WALK_SPEED, 0x1F29},
            //{Opcode.SMSG_MULTIPLE_PACKETS, 0x0000},
            {Opcode.SMSG_NAME_QUERY_RESPONSE, 0x0C71},
            {Opcode.SMSG_NEW_WORLD, 0x0A15},
            {Opcode.SMSG_ON_MONSTER_MOVE, 0x0EA9},
            {Opcode.SMSG_PARTY_INVITE, 0x0E83},
            {Opcode.SMSG_PET_GUIDS, 0x0245},
            {Opcode.SMSG_PET_STABLE_LIST, 0x0D36},
            {Opcode.SMSG_PLAYED_TIME, 0x1875},
            {Opcode.SMSG_PONG, 0x011D},
            {Opcode.SMSG_POWER_UPDATE, 0x0F96},
            {Opcode.SMSG_PVP_SEASON, 0x1D61},
            {Opcode.SMSG_QUESTGIVER_STATUS_MULTIPLE, 0x0814},
            {Opcode.SMSG_QUEST_QUERY_RESPONSE, 0x0817},
            {Opcode.SMSG_RANDOMIZE_CHAR_NAME, 0x121A},
            {Opcode.SMSG_REDIRECT_CLIENT, 0x0119},
            //{Opcode.SMSG_RESUME_COMMS, 0x0000},
            {Opcode.SMSG_SEND_SPELL_CHARGES, 0x187E},
            {Opcode.SMSG_SEND_SPELL_HISTORY, 0x142D},
            {Opcode.SMSG_SEND_UNLEARN_SPELLS, 0x155D},
            {Opcode.SMSG_SETUP_CURRENCY, 0x1CE2},
            {Opcode.SMSG_SET_FLAT_SPELL_MODIFIER, 0x192A},
            {Opcode.SMSG_SET_PHASE_SHIFT_CHANGE, 0x18A6},
            {Opcode.SMSG_SET_PROFICIENCY, 0x0D75},
            {Opcode.SMSG_SET_TIME_ZONE_INFORMATION, 0x073A},
            //{Opcode.SMSG_SET_VIGNETTE, 0x0000},
            {Opcode.SMSG_SPELL_GO, 0x1CB9},
            {Opcode.SMSG_SPELL_HEAL_LOG, 0x155A},
            {Opcode.SMSG_SPELL_NON_MELEE_DAMAGE_LOG, 0x14E9},
            {Opcode.SMSG_SPELL_START, 0x14BA},
            //{Opcode.SMSG_SUSPEND_COMMS, 0x0000},
            //{Opcode.SMSG_SUSPEND_TOKEN, 0x0000},
            //{Opcode.SMSG_TALENTS_INFO, 0x0000},
            {Opcode.SMSG_TIME_SYNC_REQ, 0x1E23},
            {Opcode.SMSG_TUTORIAL_FLAGS, 0x0E82},
            {Opcode.SMSG_UI_TIME, 0x0DA1},
            {Opcode.SMSG_UNDELETE_COOLDOWN_STATUS_RESPONSE, 0x0B9F},
            {Opcode.SMSG_UPDATE_ACCOUNT_DATA, 0x1698},
            {Opcode.SMSG_UPDATE_OBJECT, 0x1CB2},
            {Opcode.SMSG_UPDATE_WORLD_STATE, 0x1DF1},
            {Opcode.SMSG_WARDEN_DATA, 0x0E96},
            {Opcode.SMSG_WEATHER, 0x0397},
            {Opcode.SMSG_WEEKLY_SPELL_USAGE, 0x1199},
            {Opcode.SMSG_WHO, 0x11CC},
            {Opcode.SMSG_WORLD_SERVER_INFO, 0x0FB5},
        };

        private static readonly BiDictionary<Opcode, int> MiscOpcodes = new BiDictionary<Opcode, int>();
    }
}
