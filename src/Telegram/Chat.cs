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

    public partial class Chat
    {
        [JsonProperty("first_name", NullValueHandling = NullValueHandling.Ignore)]
        [JProp("first_name")]
        public string FirstName { get; set; }

        [JsonProperty("id", NullValueHandling = NullValueHandling.Ignore)]
        public long? Id { get; set; }

        [JsonProperty("last_name", NullValueHandling = NullValueHandling.Ignore)]
        [JProp("last_name")]
        public string LastName { get; set; }

        [JsonProperty("type", NullValueHandling = NullValueHandling.Ignore)]
        public string Type { get; set; }

        [JsonProperty("username", NullValueHandling = NullValueHandling.Ignore)]
        public string Username { get; set; }
    }
}
