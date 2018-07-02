# Sphereon.SDK.Extraction.Named.Entity.Api.NamedEntityExtractionApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/extraction/name/entity/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**AddInputText**](NamedEntityExtractionApi.md#addinputtext) | **POST** /extraction/name/entity/jobs/{jobid}/streams/text | Upload text
[**CreateJob**](NamedEntityExtractionApi.md#createjob) | **POST** /extraction/name/entity/jobs | Create a name entity extraction job
[**DeleteJob**](NamedEntityExtractionApi.md#deletejob) | **DELETE** /extraction/name/entity/jobs/{jobid} | Delete a job manually
[**GetJob**](NamedEntityExtractionApi.md#getjob) | **GET** /extraction/name/entity/jobs/{jobid} | Job definition and state
[**GetResult**](NamedEntityExtractionApi.md#getresult) | **GET** /extraction/name/entity/jobs/{jobid}/result | Get the extraction results
[**SubmitJob**](NamedEntityExtractionApi.md#submitjob) | **PUT** /extraction/name/entity/jobs/{jobid} | Submit name entity extraction job for processing


<a name="addinputtext"></a>
# **AddInputText**
> Job AddInputText (string jobid, TextInput textInput)

Upload text

Upload text for name entity extraction. Name entity extraction will start after submitting the job.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Extraction.Named.Entity.Api;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using Sphereon.SDK.Extraction.Named.Entity.Model;

namespace Example
{
    public class AddInputTextExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NamedEntityExtractionApi();
            var jobid = jobid_example;  // string | jobid
            var textInput = new TextInput(); // TextInput | textInput

            try
            {
                // Upload text
                Job result = apiInstance.AddInputText(jobid, textInput);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NamedEntityExtractionApi.AddInputText: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| jobid | 
 **textInput** | [**TextInput**](TextInput.md)| textInput | 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="createjob"></a>
# **CreateJob**
> Job CreateJob (JobSettings jobSettings)

Create a name entity extraction job

Create a name entity extraction job with settings. For optional settings defaults will be used

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Extraction.Named.Entity.Api;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using Sphereon.SDK.Extraction.Named.Entity.Model;

namespace Example
{
    public class CreateJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NamedEntityExtractionApi();
            var jobSettings = new JobSettings(); // JobSettings | jobSettings

            try
            {
                // Create a name entity extraction job
                Job result = apiInstance.CreateJob(jobSettings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NamedEntityExtractionApi.CreateJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobSettings** | [**JobSettings**](JobSettings.md)| jobSettings | 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="deletejob"></a>
# **DeleteJob**
> Job DeleteJob (string jobid)

Delete a job manually

Delete the job and all related files.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Extraction.Named.Entity.Api;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using Sphereon.SDK.Extraction.Named.Entity.Model;

namespace Example
{
    public class DeleteJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NamedEntityExtractionApi();
            var jobid = jobid_example;  // string | jobid

            try
            {
                // Delete a job manually
                Job result = apiInstance.DeleteJob(jobid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NamedEntityExtractionApi.DeleteJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| jobid | 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getjob"></a>
# **GetJob**
> Job GetJob (string jobid)

Job definition and state

Get the name entity extraction job definition and current state. Please note that you can differentiate based on http response status.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Extraction.Named.Entity.Api;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using Sphereon.SDK.Extraction.Named.Entity.Model;

namespace Example
{
    public class GetJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NamedEntityExtractionApi();
            var jobid = jobid_example;  // string | jobid

            try
            {
                // Job definition and state
                Job result = apiInstance.GetJob(jobid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NamedEntityExtractionApi.GetJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| jobid | 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="getresult"></a>
# **GetResult**
> NamedEntityExtractionResponse GetResult (string jobid)

Get the extraction results

Get the name entities that are extracted from the text. The name entity extraction response contains a list of name entities for each text. For each name entity the weight is given with other text statistics.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Extraction.Named.Entity.Api;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using Sphereon.SDK.Extraction.Named.Entity.Model;

namespace Example
{
    public class GetResultExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NamedEntityExtractionApi();
            var jobid = jobid_example;  // string | jobid

            try
            {
                // Get the extraction results
                NamedEntityExtractionResponse result = apiInstance.GetResult(jobid);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NamedEntityExtractionApi.GetResult: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| jobid | 

### Return type

[**NamedEntityExtractionResponse**](NamedEntityExtractionResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

<a name="submitjob"></a>
# **SubmitJob**
> Job SubmitJob (string jobid, JobSettings settings)

Submit name entity extraction job for processing

Start name entity extraction. The extraction is done on the previously texts. The settings supplied with the job in the request body are used for the name entity extraction. You can only submit the job after a new Job is created with status INPUTS_UPLOADED or resubmit an existing Job with status ERROR. In all cases the job Id in the path must match the jobId in the request.

### Example
```csharp
using System;
using System.Diagnostics;
using Sphereon.SDK.Extraction.Named.Entity.Api;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using Sphereon.SDK.Extraction.Named.Entity.Model;

namespace Example
{
    public class SubmitJobExample
    {
        public void main()
        {
            // Configure OAuth2 access token for authorization: oauth2schema
            Configuration.Default.AccessToken = "YOUR_ACCESS_TOKEN";

            var apiInstance = new NamedEntityExtractionApi();
            var jobid = jobid_example;  // string | jobid
            var settings = new JobSettings(); // JobSettings | settings

            try
            {
                // Submit name entity extraction job for processing
                Job result = apiInstance.SubmitJob(jobid, settings);
                Debug.WriteLine(result);
            }
            catch (Exception e)
            {
                Debug.Print("Exception when calling NamedEntityExtractionApi.SubmitJob: " + e.Message );
            }
        }
    }
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **string**| jobid | 
 **settings** | [**JobSettings**](JobSettings.md)| settings | 

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

[[Back to top]](#) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to Model list]](../README.md#documentation-for-models) [[Back to README]](../README.md)

