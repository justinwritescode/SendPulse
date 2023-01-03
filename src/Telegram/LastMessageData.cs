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

namespace SendPulse.Telegram
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Text.Json;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class LastMessageData
    {
        [JsonProperty("chat_id", NullValueHandling = NullValueHandling.Ignore)]
        [JProp("chat_id")]
        public long? ChatId { get; set; }

        [JsonProperty("contact")]
        public object Contact { get; set; }

        [JsonProperty("message", NullValueHandling = NullValueHandling.Ignore)]
        public Message Message { get; set; }

        [JsonProperty("message_id", NullValueHandling = NullValueHandling.Ignore)]
        [JProp("message_id")]
        public long? MessageId { get; set; }
    }
}
