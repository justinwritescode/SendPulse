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
	public static partial class Strings
	{
		/// <summary>
		///     The base URI for the SendPulse API.
		/// </summary>
		public const string SendPulseApiBaseUriString = "https://api.sendpulse.com/";

		/// <summary>
		///     The URI for the SendPulse API's OAuth2 endpoint.
		/// </summary>
		public const string SendPulseOAuth2UriString = "https://login.sendpulse.com/oauth/access_token/";
	}
}
