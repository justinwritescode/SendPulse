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
    using AnyOfTypes;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Converters;

    public partial class SendPulseContact
    {
        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        [JProp("id")]
        public string ObjectId { get; set; }

        [JsonProperty("last_message")]
        public object LastMessage { get; set; }

        [JsonProperty("last_message_data", NullValueHandling = NullValueHandling.Ignore)]
        [JProp("last_message_data")]
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
        // [JConverter(typeof(AnyOfTypes.System.Text.Json.AnyOfJsonConverter))]
        public object Variables { get; set; }
    }
}
