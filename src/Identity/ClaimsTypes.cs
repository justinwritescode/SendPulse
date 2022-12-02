/*
 * Claims.cs
 *
 *   Created: 2022-11-27-08:09:19
 *   Modified: 2022-11-27-08:09:19
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace JustinWritesCode.SendPulse.Identity;

public static class ClaimTypes
{
    public static readonly ClaimType SendPulseContactId = new ClaimType("SendPulseContactId", "SendPulse Contact Id");
}
