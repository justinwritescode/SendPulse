﻿/*
* NewtonsoftJsonToSystemTextJsonConverter.cs
*
*   Created: 2022-12-09-04:48:30
*   Modified: 2022-12-09-04:48:30
*
*   Author: Justin Chase <justin@justinwritescode.com>
*
*   Copyright © 2022 Justin Chase, All Rights Reserved
*      License: MIT (https://opensource.org/licenses/MIT)
*/

namespace Telegram.JsonConverters;
using System.Text.Json;
using static System.Text.Encoding;

public class NewtonsoftJsonToSystemTextJsonConverter<T>
    : System.Text.Json.Serialization.JsonConverter<T>
{
    public override T? Read(
        ref Utf8JsonReader reader,
        Type typeToConvert,
        JsonSerializerOptions options
    )
    {
        return JsonConvert.DeserializeObject<T>(UTF8.GetString(reader.ValueSpan.ToArray()));
    }

    public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
    {
        writer.WriteStringValue(JsonConvert.SerializeObject(value));
    }
}
