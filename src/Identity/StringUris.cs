using System;
using Microsoft.VisualBasic;
/*
 * Strings.cs
 *
 *   Created: 2022-11-27-07:56:37
 *   Modified: 2022-11-27-07:56:37
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.SendPulse.Identity;

public static partial class Constants
{
    public static partial class UriStrings
    {
        /// <summary>The base URI for the SendPulse API.</summary>
        /// <value>https://api.sendpulse.com/</value>
        public const string SendPulseApiBaseUriString = "https://api.sendpulse.com/";

        /// <summary>The base URI for the SendPulse domain.</summary>
        /// <value>https://sendpulse.com/</value>
        public const string SendPulseBaseUriString = "https://sendpulse.com/";

        /// <summary>The base URI for the SendPulse domain.</summary>
        /// <value><inheritdoc cref="SendPulseBaseUriString" path="/value/node()" /><inheritdoc cref="IdentityUriFragment" path="/value/node()" /></value>
        public const string SendPulseIdentityUriString = SendPulseBaseUriString + IdentityUriFragment;

        /// <summary>The base URI for the SendPulse domain.</summary>
        /// <value><inheritdoc cref="SendPulseIdentityUriString" path="/value/node()" /><inheritdoc cref="ContactIdUriFragment" path="/value/node()" /></value>
        public const string SendPulseIContactIdUriString = SendPulseIdentityUriString + ContactIdUriFragment;

        /// <summary>
        ///     The URI for the SendPulse API's OAuth2 endpoint.
        /// </summary>
        public const string SendPulseOAuth2UriString = "https://login.sendpulse.com/oauth/access_token/";
    }
}
