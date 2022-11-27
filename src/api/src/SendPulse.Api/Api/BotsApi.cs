/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: justin@justinwritescode.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using SendPulse.Api.Client;
using SendPulse.Api.Model;

namespace SendPulse.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        internal interface IBotsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Get a list of connected bots
        /// </summary>
        /// <remarks>
        /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse2005</returns>
        InlineResponse2005 BotsGet ();

        /// <summary>
        /// Get a list of connected bots
        /// </summary>
        /// <remarks>
        /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        ApiResponse<InlineResponse2005> BotsGetWithHttpInfo ();
        /// <summary>
        /// Get general statistics info by bot
        /// </summary>
        /// <remarks>
        /// Returns general statistics info by bot
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>InlineResponse2006</returns>
        InlineResponse2006 BotsStatisticsGet (string botId);

        /// <summary>
        /// Get general statistics info by bot
        /// </summary>
        /// <remarks>
        /// Returns general statistics info by bot
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        ApiResponse<InlineResponse2006> BotsStatisticsGetWithHttpInfo (string botId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Get a list of connected bots
        /// </summary>
        /// <remarks>
        /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse2005</returns>
        System.Threading.Tasks.Task<InlineResponse2005> BotsGetAsync ();

        /// <summary>
        /// Get a list of connected bots
        /// </summary>
        /// <remarks>
        /// Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> BotsGetAsyncWithHttpInfo ();
        /// <summary>
        /// Get general statistics info by bot
        /// </summary>
        /// <remarks>
        /// Returns general statistics info by bot
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>Task of InlineResponse2006</returns>
        System.Threading.Tasks.Task<InlineResponse2006> BotsStatisticsGetAsync (string botId);

        /// <summary>
        /// Get general statistics info by bot
        /// </summary>
        /// <remarks>
        /// Returns general statistics info by bot
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> BotsStatisticsGetAsyncWithHttpInfo (string botId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        internal partial class BotsApi : IBotsApi
    {
        private SendPulse.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="BotsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public BotsApi(string basePath)
        {
            this.Configuration = new SendPulse.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotsApi"/> class
        /// </summary>
        /// <returns></returns>
        public BotsApi()
        {
            this.Configuration = SendPulse.Api.Client.Configuration.Default;

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BotsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public BotsApi(SendPulse.Api.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = SendPulse.Api.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public string GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.Options!.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(string basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public SendPulse.Api.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public SendPulse.Api.Client.ExceptionFactory ExceptionFactory
        {
            get
            {
                if (_exceptionFactory != null && _exceptionFactory.GetInvocationList().Length > 1)
                {
                    throw new InvalidOperationException("Multicast delegate for ExceptionFactory is unsupported.");
                }
                return _exceptionFactory;
            }
            set { _exceptionFactory = value; }
        }

        /// <summary>
        /// Gets the default header.
        /// </summary>
        /// <returns>Dictionary of HTTP header</returns>
        [Obsolete("DefaultHeader is deprecated, please use Configuration.DefaultHeader instead.")]
        public IDictionary<string, string> DefaultHeader()
        {
            return new ReadOnlyDictionary<string, string>(this.Configuration.DefaultHeader);
        }

        /// <summary>
        /// Add default header.
        /// </summary>
        /// <param name="key">Header field name.</param>
        /// <param name="value">Header field value.</param>
        /// <returns></returns>
        [Obsolete("AddDefaultHeader is deprecated, please use Configuration.AddDefaultHeader instead.")]
        public void AddDefaultHeader(string key, string value)
        {
            this.Configuration.AddDefaultHeader(key, value);
        }

        /// <summary>
        /// Get a list of connected bots Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>InlineResponse2005</returns>
        public InlineResponse2005 BotsGet ()
        {
             ApiResponse<InlineResponse2005> localVarResponse = BotsGetWithHttpInfo();
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get a list of connected bots Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>ApiResponse of InlineResponse2005</returns>
        public ApiResponse< InlineResponse2005 > BotsGetWithHttpInfo ()
        {

            var localVarPath = "/bots";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BotsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Get a list of connected bots Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of InlineResponse2005</returns>
        public async System.Threading.Tasks.Task<InlineResponse2005> BotsGetAsync ()
        {
             ApiResponse<InlineResponse2005> localVarResponse = await BotsGetAsyncWithHttpInfo();
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get a list of connected bots Returns lists of bots with information about each: bot ID, channel information, number of received and unread messages, bot status, and creation date
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <returns>Task of ApiResponse (InlineResponse2005)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2005>> BotsGetAsyncWithHttpInfo ()
        {

            var localVarPath = "/bots";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BotsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2005>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2005) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2005)));
        }

        /// <summary>
        /// Get general statistics info by bot Returns general statistics info by bot
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>InlineResponse2006</returns>
        public InlineResponse2006 BotsStatisticsGet (string botId)
        {
             ApiResponse<InlineResponse2006> localVarResponse = BotsStatisticsGetWithHttpInfo(botId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get general statistics info by bot Returns general statistics info by bot
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>ApiResponse of InlineResponse2006</returns>
        public ApiResponse< InlineResponse2006 > BotsStatisticsGetWithHttpInfo (string botId)
        {
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling BotsApi->BotsStatisticsGet");

            var localVarPath = "/bots/statistics";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (botId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "bot_id", botId)); // query parameter
            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BotsStatisticsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

        /// <summary>
        /// Get general statistics info by bot Returns general statistics info by bot
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>Task of InlineResponse2006</returns>
        public async System.Threading.Tasks.Task<InlineResponse2006> BotsStatisticsGetAsync (string botId)
        {
             ApiResponse<InlineResponse2006> localVarResponse = await BotsStatisticsGetAsyncWithHttpInfo(botId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Get general statistics info by bot Returns general statistics info by bot
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="botId">The bot ID. Can be obtained with a method of getting a list of bots. You can also find it in your account in the address bar of a chat window with the desired contact.</param>
        /// <returns>Task of ApiResponse (InlineResponse2006)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse2006>> BotsStatisticsGetAsyncWithHttpInfo (string botId)
        {
            // verify the required parameter 'botId' is set
            if (botId == null)
                throw new ApiException(400, "Missing required parameter 'botId' when calling BotsApi->BotsStatisticsGet");

            var localVarPath = "/bots/statistics";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
            };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (botId != null) localVarQueryParams.AddRange(this.Configuration.ApiClient.ParameterToKeyValuePairs("", "bot_id", botId)); // query parameter
            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Get, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("BotsStatisticsGet", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse2006>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse2006) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse2006)));
        }

    }
}
