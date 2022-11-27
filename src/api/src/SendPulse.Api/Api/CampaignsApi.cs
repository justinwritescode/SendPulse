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
        internal interface ICampaignsApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InlineResponse20010</returns>
        InlineResponse20010 CampaignsSendPost (CampaignsSendBody body);

        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        ApiResponse<InlineResponse20010> CampaignsSendPostWithHttpInfo (CampaignsSendBody body);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InlineResponse20010</returns>
        System.Threading.Tasks.Task<InlineResponse20010> CampaignsSendPostAsync (CampaignsSendBody body);

        /// <summary>
        /// Send campaign
        /// </summary>
        /// <remarks>
        /// Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </remarks>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> CampaignsSendPostAsyncWithHttpInfo (CampaignsSendBody body);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
        internal partial class CampaignsApi : ICampaignsApi
    {
        private SendPulse.Api.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsApi"/> class.
        /// </summary>
        /// <returns></returns>
        public CampaignsApi(string basePath)
        {
            this.Configuration = new SendPulse.Api.Client.Configuration { BasePath = basePath };

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsApi"/> class
        /// </summary>
        /// <returns></returns>
        public CampaignsApi()
        {
            this.Configuration = SendPulse.Api.Client.Configuration.Default;

            ExceptionFactory = SendPulse.Api.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignsApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public CampaignsApi(SendPulse.Api.Client.Configuration configuration = null)
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
        /// Send campaign Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>InlineResponse20010</returns>
        public InlineResponse20010 CampaignsSendPost (CampaignsSendBody body)
        {
             ApiResponse<InlineResponse20010> localVarResponse = CampaignsSendPostWithHttpInfo(body);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Send campaign Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>ApiResponse of InlineResponse20010</returns>
        public ApiResponse< InlineResponse20010 > CampaignsSendPostWithHttpInfo (CampaignsSendBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CampaignsApi->CampaignsSendPost");

            var localVarPath = "/campaigns/send";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CampaignsSendPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20010>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20010) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20010)));
        }

        /// <summary>
        /// Send campaign Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of InlineResponse20010</returns>
        public async System.Threading.Tasks.Task<InlineResponse20010> CampaignsSendPostAsync (CampaignsSendBody body)
        {
             ApiResponse<InlineResponse20010> localVarResponse = await CampaignsSendPostAsyncWithHttpInfo(body);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Send campaign Sends a campaign to all of a bot&#x27;s subscribers that were active within the last 24 hours. You can send a campaign with text, an image, or a file. To view an example of the request body, select a message type from the drop-down list
        /// </summary>
        /// <exception cref="SendPulse.Api.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="body"></param>
        /// <returns>Task of ApiResponse (InlineResponse20010)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<InlineResponse20010>> CampaignsSendPostAsyncWithHttpInfo (CampaignsSendBody body)
        {
            // verify the required parameter 'body' is set
            if (body == null)
                throw new ApiException(400, "Missing required parameter 'body' when calling CampaignsApi->CampaignsSendPost");

            var localVarPath = "/campaigns/send";
            var localVarPathParams = new Dictionary<string, string>();
            var localVarQueryParams = new List<KeyValuePair<string, string>>();
            var localVarHeaderParams = new Dictionary<string, string>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<string, string>();
            var localVarFileParams = new Dictionary<string, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            string[] localVarHttpContentTypes = new string[] {
                "application/json"
            };
            string localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            string[] localVarHttpHeaderAccepts = new string[] {
                "application/json"
            };
            string localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (body != null && body.GetType() != typeof(byte[]))
            {
                localVarPostBody = this.Configuration.ApiClient.Serialize(body); // http body (model) parameter
            }
            else
            {
                localVarPostBody = body; // byte array
            }
            // authentication (oAuth2ClientCredentials) required
            // oauth required
            if (!string.IsNullOrEmpty(this.Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + this.Configuration.AccessToken;
            }

            // make the HTTP request
            RestResponse localVarResponse = (RestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.Post, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CampaignsSendPost", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<InlineResponse20010>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => string.Join(",", x.Value)),
                (InlineResponse20010) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(InlineResponse20010)));
        }

    }
}
