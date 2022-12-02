/*
 * TelegramWebhookMessage.cs
 *
 *   Created: 2022-12-01-11:48:58
 *   Modified: 2022-12-01-11:48:59
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.Telegram
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class WebhookMessage
    {
        [JsonProperty("bot", NullValueHandling = NullValueHandling.Ignore)]
        public Bot Bot { get; set; }

        [JsonProperty("contact", NullValueHandling = NullValueHandling.Ignore)]
        public SendPulseContact Contact { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public long? Date { get; set; }

        [JsonProperty("info")]
        public object Info { get; set; }

        [JsonProperty("service", NullValueHandling = NullValueHandling.Ignore)]
        public string Service { get; set; }

        [JsonProperty("title", NullValueHandling = NullValueHandling.Ignore)]
        public string Title { get; set; }
    }

    public partial class Bot
    {
        [JsonProperty("external_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? TelegramId { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string SendPulseId { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("url", NullValueHandling = NullValueHandling.Ignore)]
        public string Url { get; set; }
    }

    public partial class SendPulseContact
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public string SendPulseId { get; set; }

        [JsonProperty("last_message")]
        public object LastMessage { get; set; }

        [JsonProperty("last_message_data", NullValueHandling = NullValueHandling.Ignore)]
        public LastMessageData LastMessageData { get; set; }

        [JsonProperty("name", NullValueHandling = NullValueHandling.Ignore)]
        public string Name { get; set; }

        [JsonProperty("photo")]
        public object Photo { get; set; }

        [JsonProperty("tags", NullValueHandling = NullValueHandling.Ignore)]
        public string[] Tags { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }

        [JsonProperty("variables", NullValueHandling = NullValueHandling.Ignore)]
        public Dictionary<string, string> Variables { get; set; }
    }

    public partial class LastMessageData
    {
        [JsonProperty("chat_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? ChatId { get; set; }

        [JsonProperty("contact")]
        public object Contact { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public MessageClass Message { get; set; }

        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MessageId { get; set; }
    }

    public partial class MessageClass
    {
        [JsonProperty("caption", NullValueHandling = NullValueHandling.Ignore)]
        public string Caption { get; set; }

        [JsonProperty("caption_entities", NullValueHandling = NullValueHandling.Ignore)]
        public CaptionEntity[] CaptionEntities { get; set; }

        [JsonProperty("chat", NullValueHandling = NullValueHandling.Ignore)]
        public Chat Chat { get; set; }

        [JsonProperty("date", NullValueHandling = NullValueHandling.Ignore)]
        public long? Date { get; set; }

        [JsonProperty("from", NullValueHandling = NullValueHandling.Ignore)]
        public From From { get; set; }

        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        public long? MessageId { get; set; }

        [JsonProperty("reply_markup", NullValueHandling = NullValueHandling.Ignore)]
        public ReplyMarkup ReplyMarkup { get; set; }

        [JsonProperty("via_bot", NullValueHandling = NullValueHandling.Ignore)]
        public ViaBot ViaBot { get; set; }

        [JsonProperty("video", NullValueHandling = NullValueHandling.Ignore)]
        public Video Video { get; set; }

        [JsonProperty("photo", NullValueHandling = NullValueHandling.Ignore)]
        public Photo[] Photo { get; set; }
    }

    public partial class CaptionEntity
    {
        [JsonProperty("length")]
        public long Length { get; set; }

        [JsonProperty("offset")]
        public long Offset { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }
    }

    public partial class Chat
    {
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }

    public partial class From
    {
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("is_bot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBot { get; set; }

        [JsonProperty("is_premium", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsPremium { get; set; }

        [JsonProperty("language_code", NullValueHandling = NullValueHandling.Ignore)]
        public string LanguageCode { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        public string LastName { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }

    public partial class ReplyMarkup
    {
        [JsonProperty("inline_keyboard", NullValueHandling = NullValueHandling.Ignore)]
        public InlineKeyboard[][] InlineKeyboard { get; set; }
    }

    public partial class InlineKeyboard
    {
        [JsonProperty("callback_data")]
        public string CallbackData { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }

    public partial class ViaBot
    {
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FirstName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("is_bot", NullValueHandling = NullValueHandling.Ignore)]
        public bool? IsBot { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }

    public partial class Video
    {
        [JsonProperty("duration", NullValueHandling = NullValueHandling.Ignore)]
        public long? Duration { get; set; }

        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        [JsonProperty("file_name", NullValueHandling = NullValueHandling.Ignore)]
        public string FileName { get; set; }

        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        [JsonProperty("file_unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUniqueId { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("mime_type", NullValueHandling = NullValueHandling.Ignore)]
        public string MimeType { get; set; }

        [JsonProperty("thumb", NullValueHandling = NullValueHandling.Ignore)]
        public Thumb Thumb { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }
    }
    public partial class Photo
    {
        [JsonProperty("width")]
        public long Width { get; set; }

        [JsonProperty("height")]
        public long Height { get; set; }

        [JsonProperty("file_id")]
        public string FileId { get; set; }

        [JsonProperty("file_unique_id")]
        public string FileUniqueId { get; set; }

        [JsonProperty("file_size")]
        public long FileSize { get; set; }
    }

    public partial class Thumb
    {
        [JsonProperty("file_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileId { get; set; }

        [JsonProperty("file_size", NullValueHandling = NullValueHandling.Ignore)]
        public long? FileSize { get; set; }

        [JsonProperty("file_unique_id", NullValueHandling = NullValueHandling.Ignore)]
        public string FileUniqueId { get; set; }

        [JsonProperty("height", NullValueHandling = NullValueHandling.Ignore)]
        public long? Height { get; set; }

        [JsonProperty("width", NullValueHandling = NullValueHandling.Ignore)]
        public long? Width { get; set; }
    }
}
