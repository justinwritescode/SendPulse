/*
 * Strings.cs
 *
 *   Created: 2022-11-27-07:56:37
 *   Modified: 2022-11-27-07:56:37
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Identity;
public static partial class ClaimTypes
{
    /// <summary>The base URI for the SendPulse API.</summary>
    /// <value>https://api.sendpulse.com/</value>
    public const string ApiBaseUri = "https://api.sendpulse.com/";

    /// <summary>The base URI for the SendPulse API.</summary>
    /// <value><inheritdoc cref="ApiBaseUri" /><inheritdoc cref="SendPulseIdFragments.Telegram" /></value>
    public const string Telegram = ApiBaseUri + SendPulseIdFragments.Telegram;

    /// <summary>The base URI for the SendPulse domain.</summary>
    /// <value>https://sendpulse.com/</value>
    public const string BaseUri = "https://sendpulse.com/";

    /// <summary>The base URI for the SendPulse identity domain.</summary>
    /// <value><inheritdoc cref="BaseUri" /><inheritdoc cref="SendPulseIdFragments.Identity" /></value>
    public const string Identity = BaseUri + SendPulseIdFragments.Identity;

    /// <summary>The base URI for the SendPulse domain.</summary>
    /// <value><inheritdoc cref="Identity" /><inheritdoc cref="SendPulseIdFragments.ContactId"  /></value>
    public const string ContactId = Identity + SendPulseIdFragments.ContactId;

    /// <summary>The URI for the SendPulse API's OAuth2 endpoint.</summary>
    /// <value>https://login.sendpulse.com/oauth/access_token/</value>
    public const string OAuth2EncpointUri = "https://login.sendpulse.com/oauth/access_token/";
}
