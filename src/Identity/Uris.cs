/*
 * Uris.cs
 *
 *   Created: 2022-11-27-07:56:41
 *   Modified: 2022-11-27-07:56:41
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022-2023 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Identity;

public static partial class ClaimTypes
{
    public static partial class Uris
    {
        /// <inheritdoc cref="ObjectId.BaseUri"/>
        public static readonly uri BaseUri = new(SendPulseId.ApiBaseUri);
        /// <inheritdoc cref="ObjectId.OAuth2EncpointUri"/>
        public static readonly uri OAuth2EncpointUri = new(SendPulseId.OAuth2EncpointUri);
    }
}
