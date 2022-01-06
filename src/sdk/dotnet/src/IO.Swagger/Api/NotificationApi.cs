/* 
 * self-managed-osdu
 *
 * Rest API Documentation for Self Managed OSDU
 *
 * OpenAPI spec version: 0.11.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using IO.Swagger.Client;
using IO.Swagger.Model;

namespace IO.Swagger.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INotificationApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Notifies subscribers that records have changed
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>NotificationResponseEntity</returns>
        NotificationResponseEntity RecordChangedUsingPOST (string dataPartitionId);

        /// <summary>
        /// Notifies subscribers that records have changed
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>ApiResponse of NotificationResponseEntity</returns>
        ApiResponse<NotificationResponseEntity> RecordChangedUsingPOSTWithHttpInfo (string dataPartitionId);
        #endregion Synchronous Operations
        #region Asynchronous Operations
        /// <summary>
        /// Notifies subscribers that records have changed
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>Task of NotificationResponseEntity</returns>
        System.Threading.Tasks.Task<NotificationResponseEntity> RecordChangedUsingPOSTAsync (string dataPartitionId);

        /// <summary>
        /// Notifies subscribers that records have changed
        /// </summary>
        /// <remarks>
        /// 
        /// </remarks>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>Task of ApiResponse (NotificationResponseEntity)</returns>
        System.Threading.Tasks.Task<ApiResponse<NotificationResponseEntity>> RecordChangedUsingPOSTAsyncWithHttpInfo (string dataPartitionId);
        #endregion Asynchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NotificationApi : INotificationApi
    {
        private IO.Swagger.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NotificationApi(String basePath)
        {
            this.Configuration = new IO.Swagger.Client.Configuration { BasePath = basePath };

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NotificationApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NotificationApi(IO.Swagger.Client.Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = IO.Swagger.Client.Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = IO.Swagger.Client.Configuration.DefaultExceptionFactory;
        }

        /// <summary>
        /// Gets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        public String GetBasePath()
        {
            return this.Configuration.ApiClient.RestClient.BaseUrl.ToString();
        }

        /// <summary>
        /// Sets the base path of the API client.
        /// </summary>
        /// <value>The base path</value>
        [Obsolete("SetBasePath is deprecated, please do 'Configuration.ApiClient = new ApiClient(\"http://new-path\")' instead.")]
        public void SetBasePath(String basePath)
        {
            // do nothing
        }

        /// <summary>
        /// Gets or sets the configuration object
        /// </summary>
        /// <value>An instance of the Configuration</value>
        public IO.Swagger.Client.Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public IO.Swagger.Client.ExceptionFactory ExceptionFactory
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
        public IDictionary<String, String> DefaultHeader()
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
        /// Notifies subscribers that records have changed 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>NotificationResponseEntity</returns>
        public NotificationResponseEntity RecordChangedUsingPOST (string dataPartitionId)
        {
             ApiResponse<NotificationResponseEntity> localVarResponse = RecordChangedUsingPOSTWithHttpInfo(dataPartitionId);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Notifies subscribers that records have changed 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>ApiResponse of NotificationResponseEntity</returns>
        public ApiResponse< NotificationResponseEntity > RecordChangedUsingPOSTWithHttpInfo (string dataPartitionId)
        {
            // verify the required parameter 'dataPartitionId' is set
            if (dataPartitionId == null)
                throw new ApiException(400, "Missing required parameter 'dataPartitionId' when calling NotificationApi->RecordChangedUsingPOST");

            var localVarPath = "/api/notification/v1/push-handlers/records-changed";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataPartitionId != null) localVarHeaderParams.Add("data-partition-id", this.Configuration.ApiClient.ParameterToString(dataPartitionId)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) this.Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RecordChangedUsingPOST", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NotificationResponseEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificationResponseEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificationResponseEntity)));
        }

        /// <summary>
        /// Notifies subscribers that records have changed 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>Task of NotificationResponseEntity</returns>
        public async System.Threading.Tasks.Task<NotificationResponseEntity> RecordChangedUsingPOSTAsync (string dataPartitionId)
        {
             ApiResponse<NotificationResponseEntity> localVarResponse = await RecordChangedUsingPOSTAsyncWithHttpInfo(dataPartitionId);
             return localVarResponse.Data;

        }

        /// <summary>
        /// Notifies subscribers that records have changed 
        /// </summary>
        /// <exception cref="IO.Swagger.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="dataPartitionId">tenant</param>
        /// <returns>Task of ApiResponse (NotificationResponseEntity)</returns>
        public async System.Threading.Tasks.Task<ApiResponse<NotificationResponseEntity>> RecordChangedUsingPOSTAsyncWithHttpInfo (string dataPartitionId)
        {
            // verify the required parameter 'dataPartitionId' is set
            if (dataPartitionId == null)
                throw new ApiException(400, "Missing required parameter 'dataPartitionId' when calling NotificationApi->RecordChangedUsingPOST");

            var localVarPath = "/api/notification/v1/push-handlers/records-changed";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new List<KeyValuePair<String, String>>();
            var localVarHeaderParams = new Dictionary<String, String>(this.Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = this.Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
            };
            String localVarHttpHeaderAccept = this.Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (dataPartitionId != null) localVarHeaderParams.Add("data-partition-id", this.Configuration.ApiClient.ParameterToString(dataPartitionId)); // header parameter

            // authentication (Bearer) required
            if (!String.IsNullOrEmpty(this.Configuration.GetApiKeyWithPrefix("Authorization")))
            {
                localVarHeaderParams["Authorization"] = this.Configuration.GetApiKeyWithPrefix("Authorization");
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) await this.Configuration.ApiClient.CallApiAsync(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("RecordChangedUsingPOST", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NotificationResponseEntity>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NotificationResponseEntity) this.Configuration.ApiClient.Deserialize(localVarResponse, typeof(NotificationResponseEntity)));
        }

    }
}
