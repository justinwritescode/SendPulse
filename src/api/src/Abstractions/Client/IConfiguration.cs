﻿/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: justin@justinwritescode.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

namespace SendPulse.Api.Client.Abstractions;

public interface IConfiguration : IReadOnlyConfiguration
{
    IApiClient ApiClient { get; }
    new string BasePath { get; set; }
    new IStringDictionary DefaultHeader { get; set; }
    new int Timeout { get; set; }
    new string UserAgent { get; set; }
    new string ClientId { get; set; }
    new string ClientSecret { get; set; }
    new string AccessToken { get; set; }
    new string TempFolderPath { get; set; }
    new string DateTimeFormat { get; set; }
    new IStringDictionary ApiKeyPrefix { get; set; }
    new IStringDictionary ApiKey { get; set; }

    void AddApiKey(string key, string value);
    void AddApiKeyPrefix(string key, string value);
    void AddDefaultHeader(string key, string value);
    new IApiClient CreateApiClient();
    new string GetApiKeyWithPrefix(string apiKeyIdentifier);
}
