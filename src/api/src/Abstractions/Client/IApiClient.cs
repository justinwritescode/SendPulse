﻿/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: justin@justinwritescode.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
#pragma warning disable
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using RestSharp;
using SendPulse.Api.Abstractions;

namespace SendPulse.Api.Client.Abstractions;

public interface IApiClient
{
    ITokenClient TokenClient { get; set; }
    IReadOnlyConfiguration Configuration { get; set; }
    RestClient RestClient { get; set; }

    object CallApi(
        string path,
        Method method,
        List<KeyValuePair<string, string>> queryParams,
        object postBody,
        StringDictionary headerParams,
        StringDictionary formParams,
        Dictionary<string, FileParameter> fileParams,
        StringDictionary pathParams,
        string contentType,
        bool callTokenClient = true
    );
    Task<object> CallApiAsync(
        string path,
        Method method,
        List<KeyValuePair<string, string>> queryParams,
        object postBody,
        StringDictionary headerParams,
        StringDictionary formParams,
        Dictionary<string, FileParameter> fileParams,
        StringDictionary pathParams,
        string contentType,
        bool callTokenClient = true
    );
    object Deserialize(RestResponse response, Type type);
    string EscapeString(string str);
    bool IsJsonMime(string mime);
    FileParameter ParameterToFile(string name, Stream stream);
    FileParameter ParameterToFile(string name, byte[] stream);
    IEnumerable<KeyValuePair<string, string>> ParameterToKeyValuePairs(
        string collectionFormat,
        string name,
        object value
    );
    string ParameterToString(object obj);
    string SelectHeaderAccept(string[] accepts);
    string SelectHeaderContentType(string[] contentTypes);
    string Serialize(object obj);
}
