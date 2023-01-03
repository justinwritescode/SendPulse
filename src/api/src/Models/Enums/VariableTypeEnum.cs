/*
 * VariableTypeEnum.cs
 *
 *   Created: 2022-12-06-12:48:23
 *   Modified: 2022-12-06-12:48:24
 *
 *   Author: Justin Chase <justin@justinwritescode.com>
 *
 *   Copyright © 2022 Justin Chase, All Rights Reserved
 *      License: MIT (https://opensource.org/licenses/MIT)
 */

namespace SendPulse.Api.Enums;

/// <summary>
///                      * &#x60;1&#x60; - contact variable                      * &#x60;2&#x60; - bot variable
/// </summary>
/// <value>                     * &#x60;1&#x60; - contact variable                      * &#x60;2&#x60; - bot variable                  </value>
[JsonConverter(typeof(StringEnumConverter))]
public enum TypeEnum
{
    /// <summary>
    /// Enum NUMBER_1 for value: 1
    /// </summary>
    [EnumMember(Value = "1")]
    ContactVariable = 1,

    /// <summary>
    /// Enum NUMBER_2 for value: 2
    /// </summary>
    [EnumMember(Value = "2")]
    BotVariable = 2
}
