/* 
 * Name Entity Extraction
 *
 * The Name Entity Extraction API allows you to extract name entities from text. Name entities can be extracted from text, file or stream location. With each extracted name entity a type of entity and a probability will be given.    The flow is generally as follows:  1. Create an extraction job. If no settings are provided, default settings are used.  2. Upload content for extraction.  3. Start the extraction job.  3. Get the result when the extraction is completed.    Full API Documentation: https://docs.sphereon.com/api/extraction/name/entity/0.1/html  Interactive testing: A web based test console is available in the Sphereon API Store at https://store.sphereon.com
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using RestSharp;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using Sphereon.SDK.Extraction.Named.Entity.Model;

namespace Sphereon.SDK.Extraction.Named.Entity.Api
{
    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public interface INamedEntityExtractionApi : IApiAccessor
    {
        #region Synchronous Operations
        /// <summary>
        /// Upload text
        /// </summary>
        /// <remarks>
        /// Upload text for name entity extraction. Name entity extraction will start after submitting the job.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="textInput">textInput</param>
        /// <returns>Job</returns>
        Job AddInputText (string jobid, TextInput textInput);

        /// <summary>
        /// Upload text
        /// </summary>
        /// <remarks>
        /// Upload text for name entity extraction. Name entity extraction will start after submitting the job.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="textInput">textInput</param>
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> AddInputTextWithHttpInfo (string jobid, TextInput textInput);
        /// <summary>
        /// Create a name entity extraction job
        /// </summary>
        /// <remarks>
        /// Create a name entity extraction job with settings. For optional settings defaults will be used
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobSettings">jobSettings</param>
        /// <returns>Job</returns>
        Job CreateJob (JobSettings jobSettings);

        /// <summary>
        /// Create a name entity extraction job
        /// </summary>
        /// <remarks>
        /// Create a name entity extraction job with settings. For optional settings defaults will be used
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobSettings">jobSettings</param>
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> CreateJobWithHttpInfo (JobSettings jobSettings);
        /// <summary>
        /// Delete a job manually
        /// </summary>
        /// <remarks>
        /// Delete the job and all related files.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>Job</returns>
        Job DeleteJob (string jobid);

        /// <summary>
        /// Delete a job manually
        /// </summary>
        /// <remarks>
        /// Delete the job and all related files.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> DeleteJobWithHttpInfo (string jobid);
        /// <summary>
        /// Job definition and state
        /// </summary>
        /// <remarks>
        /// Get the name entity extraction job definition and current state. Please note that you can differentiate based on http response status.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>Job</returns>
        Job GetJob (string jobid);

        /// <summary>
        /// Job definition and state
        /// </summary>
        /// <remarks>
        /// Get the name entity extraction job definition and current state. Please note that you can differentiate based on http response status.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> GetJobWithHttpInfo (string jobid);
        /// <summary>
        /// Get the extraction results
        /// </summary>
        /// <remarks>
        /// Get the name entities that are extracted from the text. The name entity extraction response contains a list of name entities for each text. For each name entity the weight is given with other text statistics.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>NamedEntityExtractionResponse</returns>
        NamedEntityExtractionResponse GetResult (string jobid);

        /// <summary>
        /// Get the extraction results
        /// </summary>
        /// <remarks>
        /// Get the name entities that are extracted from the text. The name entity extraction response contains a list of name entities for each text. For each name entity the weight is given with other text statistics.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>ApiResponse of NamedEntityExtractionResponse</returns>
        ApiResponse<NamedEntityExtractionResponse> GetResultWithHttpInfo (string jobid);
        /// <summary>
        /// Submit name entity extraction job for processing
        /// </summary>
        /// <remarks>
        /// Start name entity extraction. The extraction is done on the previously texts. The settings supplied with the job in the request body are used for the name entity extraction. You can only submit the job after a new Job is created with status INPUTS_UPLOADED or resubmit an existing Job with status ERROR. In all cases the job Id in the path must match the jobId in the request.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="settings">settings</param>
        /// <returns>Job</returns>
        Job SubmitJob (string jobid, JobSettings settings);

        /// <summary>
        /// Submit name entity extraction job for processing
        /// </summary>
        /// <remarks>
        /// Start name entity extraction. The extraction is done on the previously texts. The settings supplied with the job in the request body are used for the name entity extraction. You can only submit the job after a new Job is created with status INPUTS_UPLOADED or resubmit an existing Job with status ERROR. In all cases the job Id in the path must match the jobId in the request.
        /// </remarks>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="settings">settings</param>
        /// <returns>ApiResponse of Job</returns>
        ApiResponse<Job> SubmitJobWithHttpInfo (string jobid, JobSettings settings);
        #endregion Synchronous Operations
    }

    /// <summary>
    /// Represents a collection of functions to interact with the API endpoints
    /// </summary>
    public partial class NamedEntityExtractionApi : INamedEntityExtractionApi
    {
        private Sphereon.SDK.Extraction.Named.Entity.Client.ExceptionFactory _exceptionFactory = (name, response) => null;

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityExtractionApi"/> class.
        /// </summary>
        /// <returns></returns>
        public NamedEntityExtractionApi(String basePath)
        {
            this.Configuration = new Configuration(new ApiClient(basePath));

            ExceptionFactory = Sphereon.SDK.Extraction.Named.Entity.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityExtractionApi"/> class
        /// using Configuration object
        /// </summary>
        /// <param name="configuration">An instance of Configuration</param>
        /// <returns></returns>
        public NamedEntityExtractionApi(Configuration configuration = null)
        {
            if (configuration == null) // use the default one in Configuration
                this.Configuration = Configuration.Default;
            else
                this.Configuration = configuration;

            ExceptionFactory = Sphereon.SDK.Extraction.Named.Entity.Client.Configuration.DefaultExceptionFactory;

            // ensure API client has configuration ready
            if (Configuration.ApiClient.Configuration == null)
            {
                this.Configuration.ApiClient.Configuration = this.Configuration;
            }
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
        public Configuration Configuration {get; set;}

        /// <summary>
        /// Provides a factory method hook for the creation of exceptions.
        /// </summary>
        public Sphereon.SDK.Extraction.Named.Entity.Client.ExceptionFactory ExceptionFactory
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
        public Dictionary<String, String> DefaultHeader()
        {
            return this.Configuration.DefaultHeader;
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
        /// Upload text Upload text for name entity extraction. Name entity extraction will start after submitting the job.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="textInput">textInput</param>
        /// <returns>Job</returns>
        public Job AddInputText (string jobid, TextInput textInput)
        {
             ApiResponse<Job> localVarResponse = AddInputTextWithHttpInfo(jobid, textInput);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Upload text Upload text for name entity extraction. Name entity extraction will start after submitting the job.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="textInput">textInput</param>
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > AddInputTextWithHttpInfo (string jobid, TextInput textInput)
        {
            // verify the required parameter 'jobid' is set
            if (jobid == null)
                throw new ApiException(400, "Missing required parameter 'jobid' when calling NamedEntityExtractionApi->AddInputText");
            // verify the required parameter 'textInput' is set
            if (textInput == null)
                throw new ApiException(400, "Missing required parameter 'textInput' when calling NamedEntityExtractionApi->AddInputText");

            var localVarPath = "/extraction/name/entity/jobs/{jobid}/streams/text";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobid != null) localVarPathParams.Add("jobid", Configuration.ApiClient.ParameterToString(jobid)); // path parameter
            if (textInput != null && textInput.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(textInput); // http body (model) parameter
            }
            else
            {
                localVarPostBody = textInput; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("AddInputText", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
        }

        /// <summary>
        /// Create a name entity extraction job Create a name entity extraction job with settings. For optional settings defaults will be used
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobSettings">jobSettings</param>
        /// <returns>Job</returns>
        public Job CreateJob (JobSettings jobSettings)
        {
             ApiResponse<Job> localVarResponse = CreateJobWithHttpInfo(jobSettings);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Create a name entity extraction job Create a name entity extraction job with settings. For optional settings defaults will be used
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobSettings">jobSettings</param>
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > CreateJobWithHttpInfo (JobSettings jobSettings)
        {
            // verify the required parameter 'jobSettings' is set
            if (jobSettings == null)
                throw new ApiException(400, "Missing required parameter 'jobSettings' when calling NamedEntityExtractionApi->CreateJob");

            var localVarPath = "/extraction/name/entity/jobs";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobSettings != null && jobSettings.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(jobSettings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = jobSettings; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.POST, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("CreateJob", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
        }

        /// <summary>
        /// Delete a job manually Delete the job and all related files.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>Job</returns>
        public Job DeleteJob (string jobid)
        {
             ApiResponse<Job> localVarResponse = DeleteJobWithHttpInfo(jobid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Delete a job manually Delete the job and all related files.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > DeleteJobWithHttpInfo (string jobid)
        {
            // verify the required parameter 'jobid' is set
            if (jobid == null)
                throw new ApiException(400, "Missing required parameter 'jobid' when calling NamedEntityExtractionApi->DeleteJob");

            var localVarPath = "/extraction/name/entity/jobs/{jobid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobid != null) localVarPathParams.Add("jobid", Configuration.ApiClient.ParameterToString(jobid)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.DELETE, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("DeleteJob", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
        }

        /// <summary>
        /// Job definition and state Get the name entity extraction job definition and current state. Please note that you can differentiate based on http response status.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>Job</returns>
        public Job GetJob (string jobid)
        {
             ApiResponse<Job> localVarResponse = GetJobWithHttpInfo(jobid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Job definition and state Get the name entity extraction job definition and current state. Please note that you can differentiate based on http response status.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > GetJobWithHttpInfo (string jobid)
        {
            // verify the required parameter 'jobid' is set
            if (jobid == null)
                throw new ApiException(400, "Missing required parameter 'jobid' when calling NamedEntityExtractionApi->GetJob");

            var localVarPath = "/extraction/name/entity/jobs/{jobid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobid != null) localVarPathParams.Add("jobid", Configuration.ApiClient.ParameterToString(jobid)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetJob", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
        }

        /// <summary>
        /// Get the extraction results Get the name entities that are extracted from the text. The name entity extraction response contains a list of name entities for each text. For each name entity the weight is given with other text statistics.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>NamedEntityExtractionResponse</returns>
        public NamedEntityExtractionResponse GetResult (string jobid)
        {
             ApiResponse<NamedEntityExtractionResponse> localVarResponse = GetResultWithHttpInfo(jobid);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Get the extraction results Get the name entities that are extracted from the text. The name entity extraction response contains a list of name entities for each text. For each name entity the weight is given with other text statistics.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <returns>ApiResponse of NamedEntityExtractionResponse</returns>
        public ApiResponse< NamedEntityExtractionResponse > GetResultWithHttpInfo (string jobid)
        {
            // verify the required parameter 'jobid' is set
            if (jobid == null)
                throw new ApiException(400, "Missing required parameter 'jobid' when calling NamedEntityExtractionApi->GetResult");

            var localVarPath = "/extraction/name/entity/jobs/{jobid}/result";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobid != null) localVarPathParams.Add("jobid", Configuration.ApiClient.ParameterToString(jobid)); // path parameter

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.GET, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("GetResult", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<NamedEntityExtractionResponse>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (NamedEntityExtractionResponse) Configuration.ApiClient.Deserialize(localVarResponse, typeof(NamedEntityExtractionResponse)));
        }

        /// <summary>
        /// Submit name entity extraction job for processing Start name entity extraction. The extraction is done on the previously texts. The settings supplied with the job in the request body are used for the name entity extraction. You can only submit the job after a new Job is created with status INPUTS_UPLOADED or resubmit an existing Job with status ERROR. In all cases the job Id in the path must match the jobId in the request.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="settings">settings</param>
        /// <returns>Job</returns>
        public Job SubmitJob (string jobid, JobSettings settings)
        {
             ApiResponse<Job> localVarResponse = SubmitJobWithHttpInfo(jobid, settings);
             return localVarResponse.Data;
        }

        /// <summary>
        /// Submit name entity extraction job for processing Start name entity extraction. The extraction is done on the previously texts. The settings supplied with the job in the request body are used for the name entity extraction. You can only submit the job after a new Job is created with status INPUTS_UPLOADED or resubmit an existing Job with status ERROR. In all cases the job Id in the path must match the jobId in the request.
        /// </summary>
        /// <exception cref="Sphereon.SDK.Extraction.Named.Entity.Client.ApiException">Thrown when fails to make API call</exception>
        /// <param name="jobid">jobid</param>
        /// <param name="settings">settings</param>
        /// <returns>ApiResponse of Job</returns>
        public ApiResponse< Job > SubmitJobWithHttpInfo (string jobid, JobSettings settings)
        {
            // verify the required parameter 'jobid' is set
            if (jobid == null)
                throw new ApiException(400, "Missing required parameter 'jobid' when calling NamedEntityExtractionApi->SubmitJob");
            // verify the required parameter 'settings' is set
            if (settings == null)
                throw new ApiException(400, "Missing required parameter 'settings' when calling NamedEntityExtractionApi->SubmitJob");

            var localVarPath = "/extraction/name/entity/jobs/{jobid}";
            var localVarPathParams = new Dictionary<String, String>();
            var localVarQueryParams = new Dictionary<String, String>();
            var localVarHeaderParams = new Dictionary<String, String>(Configuration.DefaultHeader);
            var localVarFormParams = new Dictionary<String, String>();
            var localVarFileParams = new Dictionary<String, FileParameter>();
            Object localVarPostBody = null;

            // to determine the Content-Type header
            String[] localVarHttpContentTypes = new String[] {
                "application/json"
            };
            String localVarHttpContentType = Configuration.ApiClient.SelectHeaderContentType(localVarHttpContentTypes);

            // to determine the Accept header
            String[] localVarHttpHeaderAccepts = new String[] {
                "application/json;charset=UTF-8"
            };
            String localVarHttpHeaderAccept = Configuration.ApiClient.SelectHeaderAccept(localVarHttpHeaderAccepts);
            if (localVarHttpHeaderAccept != null)
                localVarHeaderParams.Add("Accept", localVarHttpHeaderAccept);

            if (jobid != null) localVarPathParams.Add("jobid", Configuration.ApiClient.ParameterToString(jobid)); // path parameter
            if (settings != null && settings.GetType() != typeof(byte[]))
            {
                localVarPostBody = Configuration.ApiClient.Serialize(settings); // http body (model) parameter
            }
            else
            {
                localVarPostBody = settings; // byte array
            }

            // authentication (oauth2schema) required
            // oauth required
            if (!String.IsNullOrEmpty(Configuration.AccessToken))
            {
                localVarHeaderParams["Authorization"] = "Bearer " + Configuration.AccessToken;
            }

            // make the HTTP request
            IRestResponse localVarResponse = (IRestResponse) Configuration.ApiClient.CallApi(localVarPath,
                Method.PUT, localVarQueryParams, localVarPostBody, localVarHeaderParams, localVarFormParams, localVarFileParams,
                localVarPathParams, localVarHttpContentType);

            int localVarStatusCode = (int) localVarResponse.StatusCode;

            if (ExceptionFactory != null)
            {
                Exception exception = ExceptionFactory("SubmitJob", localVarResponse);
                if (exception != null) throw exception;
            }

            return new ApiResponse<Job>(localVarStatusCode,
                localVarResponse.Headers.ToDictionary(x => x.Name, x => x.Value.ToString()),
                (Job) Configuration.ApiClient.Deserialize(localVarResponse, typeof(Job)));
        }

    }
}