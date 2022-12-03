using System;
/*
 * Uris.cs
 *
 *   Created: 2022-11-27-07:56:41
 *   Modified: 2022-11-27-07:56:41
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.SendPulse.Identity;
using static JustinWritesCode.SendPulse.Identity.Constants;

public static partial class Constants
{
    public static partial class Uris
    {
        public static readonly Uri SendPulseApiBaseUri = new (UriStrings.SendPulseApiBaseUriString);
        public static readonly Uri SendPulseOAuth2Uri = new(UriStrings.SendPulseOAuth2UriString);

    }
}
