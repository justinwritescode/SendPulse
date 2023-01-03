﻿/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: justin@justinwritescode.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using SendPulse.Api.Client;
using SendPulse.Api.Client.Abstractions;
using SendPulse.Api.Models;

namespace SendPulse.Api.Abstractions;

/// <summary>
/// Represents a collection of functions to interact with the API endpoints
/// </summary>
public interface IAccountApi : IApiAccessor
{
    #region Synchronous Operations
    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>InlineResponse20011</returns>
    AccountInfo AccountGet();

    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>ApiResponse of InlineResponse20011</returns>
    ApiResponse<AccountInfo> AccountGetWithHttpInfo();
    #endregion Synchronous Operations
    #region Asynchronous Operations
    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of InlineResponse20011</returns>
    System.Threading.Tasks.Task<AccountInfo> AccountGetAsync();

    /// <summary>
    /// Get account info
    /// </summary>
    /// <remarks>
    /// Returns information about your current account pricing plan, the number of messages in your plan, bots, contacts, list of tags, and variables
    /// </remarks>
    /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
    /// <returns>Task of ApiResponse (InlineResponse20011)</returns>
    System.Threading.Tasks.Task<ApiResponse<AccountInfo>> AccountGetAsyncWithHttpInfo();
    #endregion Asynchronous Operations
}
