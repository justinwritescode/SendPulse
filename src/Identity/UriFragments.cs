/*
 * UriFragments.cs
 *
 *   Created: 2022-11-27-08:07:51
 *   Modified: 2022-11-27-08:07:51
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Identity;

public static partial class ClaimTypes
{
    public static partial class UriFragments
    {
        /// <summary>A fragment for identity claims</summary>
        /// <value>identity/</value>
        public const string Identity = "identity/";

        /// <summary>A fragment for representing a SendPulse contact ID</summary>
        /// <value>contact_id/</value>
        public const string ContactId = "contact_id/";

        /// <summary>A fragment for representing the SendPulse Telegram chatbot API</summary>
        /// <value>telegram/</value>
        public const string Telegram = "telegram/";


        // public const string Telegram = "telegram/";
        // public const string TelegramBots = "bots/";
        // public const string TelegramBotsStart = "start/";
        // public const string TelegramBotsStop = "stop/";
        // public const string TelegramBotsDelete = "delete/";
        // public const string TelegramBotsInfo = "info/";
        // public const string TelegramBotsList = "list/";
        // public const string TelegramBotsCreate = "create/";
        // public const string TelegramBotsEdit = "edit/";
        // public const string TelegramBotsSend = "send/";
        // public const string TelegramBotsSendFile = "sendFile/";
        // public const string TelegramBotsSendPhoto = "sendPhoto/";
        // public const string TelegramBotsSendAudio = "sendAudio/";
        // public const string TelegramBotsSendVideo = "sendVideo/";
        // public const string TelegramBotsSendDocument = "sendDocument/";
        // public const string TelegramBotsSendSticker = "sendSticker/";
        // public const string TelegramBotsSendVoice = "sendVoice/";
        // public const string TelegramBotsSendLocation = "sendLocation/";
        // public const string TelegramBotsSendVenue = "sendVenue/";
        // public const string TelegramBotsSendContact = "sendContact/";
        // public const string TelegramBotsSendChatAction = "sendChatAction/";
        // public const string TelegramBotsGetChat = "getChat/";
        // public const string TelegramBotsGetChatAdministrators = "getChatAdministrators/";
        // public const string TelegramBotsGetChatMembersCount = "getChatMembersCount/";
        // public const string TelegramBotsGetChatMember = "getChatMember/";
        // public const string TelegramBotsLeaveChat = "leaveChat/";
        // public const string TelegramBotsUnbanChatMember = "unbanChatMember/";
        // public const string TelegramBotsGetFile = "getFile/";
        // public const string TelegramBotsKickChatMember = "kickChatMember/";
        // public const string TelegramBotsAnswerCallbackQuery = "answerCallbackQuery/";
        // public const string TelegramBotsEditMessageText = "editMessageText/";
        // public const string TelegramBotsEditMessageCaption = "editMessageCaption/";
        // public const string TelegramBotsEditMessageReplyMarkup = "editMessageReplyMarkup/";
        // public const string TelegramBotsDeleteMessage = "deleteMessage/";
    }
}
