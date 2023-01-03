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

    public partial class InlineKeyboard
    {
        [JsonProperty("callback_data")]
        [JProp("callback_data")]
        public string CallbackData { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }
    }
}
