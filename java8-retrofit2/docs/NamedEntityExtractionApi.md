# NamedEntityExtractionApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/extraction/name/entity/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addInputText**](NamedEntityExtractionApi.md#addInputText) | **POST** extraction/name/entity/jobs/{jobid}/streams/text | Upload text
[**createJob**](NamedEntityExtractionApi.md#createJob) | **POST** extraction/name/entity/jobs | Create a name entity extraction job
[**deleteJob**](NamedEntityExtractionApi.md#deleteJob) | **DELETE** extraction/name/entity/jobs/{jobid} | Delete a job manually
[**getJob**](NamedEntityExtractionApi.md#getJob) | **GET** extraction/name/entity/jobs/{jobid} | Job definition and state
[**getResult**](NamedEntityExtractionApi.md#getResult) | **GET** extraction/name/entity/jobs/{jobid}/result | Get the extraction results
[**submitJob**](NamedEntityExtractionApi.md#submitJob) | **PUT** extraction/name/entity/jobs/{jobid} | Submit name entity extraction job for processing


<a name="addInputText"></a>
# **addInputText**
> Job addInputText(jobid, textInput)

Upload text

Upload text for name entity extraction. Name entity extraction will start after submitting the job.

### Example
```java
// Import classes:
//import com.sphereon.sdk.extraction.name.entity.handler.ApiClient;
//import com.sphereon.sdk.extraction.name.entity.handler.ApiException;
//import com.sphereon.sdk.extraction.name.entity.handler.Configuration;
//import com.sphereon.sdk.extraction.name.entity.handler.auth.*;
//import com.sphereon.sdk.extraction.name.entity.api.NamedEntityExtractionApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

NamedEntityExtractionApi apiInstance = new NamedEntityExtractionApi();
String jobid = "jobid_example"; // String | jobid
TextInput textInput = new TextInput(); // TextInput | textInput
try {
    Job result = apiInstance.addInputText(jobid, textInput);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling NamedEntityExtractionApi#addInputText");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| jobid |
 **textInput** | [**TextInput**](TextInput.md)| textInput |

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json;charset=UTF-8
 - **Accept**: application/json;charset=UTF-8

<a name="createJob"></a>
# **createJob**
> Job createJob(jobSettings)

Create a name entity extraction job

Create a name entity extraction job with settings. For optional settings defaults will be used

### Example
```java
// Import classes:
//import com.sphereon.sdk.extraction.name.entity.handler.ApiClient;
//import com.sphereon.sdk.extraction.name.entity.handler.ApiException;
//import com.sphereon.sdk.extraction.name.entity.handler.Configuration;
//import com.sphereon.sdk.extraction.name.entity.handler.auth.*;
//import com.sphereon.sdk.extraction.name.entity.api.NamedEntityExtractionApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

NamedEntityExtractionApi apiInstance = new NamedEntityExtractionApi();
JobSettings jobSettings = new JobSettings(); // JobSettings | jobSettings
try {
    Job result = apiInstance.createJob(jobSettings);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling NamedEntityExtractionApi#createJob");
    e.printStackTrace();
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

<a name="deleteJob"></a>
# **deleteJob**
> Job deleteJob(jobid)

Delete a job manually

Delete the job and all related files.

### Example
```java
// Import classes:
//import com.sphereon.sdk.extraction.name.entity.handler.ApiClient;
//import com.sphereon.sdk.extraction.name.entity.handler.ApiException;
//import com.sphereon.sdk.extraction.name.entity.handler.Configuration;
//import com.sphereon.sdk.extraction.name.entity.handler.auth.*;
//import com.sphereon.sdk.extraction.name.entity.api.NamedEntityExtractionApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

NamedEntityExtractionApi apiInstance = new NamedEntityExtractionApi();
String jobid = "jobid_example"; // String | jobid
try {
    Job result = apiInstance.deleteJob(jobid);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling NamedEntityExtractionApi#deleteJob");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| jobid |

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getJob"></a>
# **getJob**
> Job getJob(jobid)

Job definition and state

Get the name entity extraction job definition and current state. Please note that you can differentiate based on http response status.

### Example
```java
// Import classes:
//import com.sphereon.sdk.extraction.name.entity.handler.ApiClient;
//import com.sphereon.sdk.extraction.name.entity.handler.ApiException;
//import com.sphereon.sdk.extraction.name.entity.handler.Configuration;
//import com.sphereon.sdk.extraction.name.entity.handler.auth.*;
//import com.sphereon.sdk.extraction.name.entity.api.NamedEntityExtractionApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

NamedEntityExtractionApi apiInstance = new NamedEntityExtractionApi();
String jobid = "jobid_example"; // String | jobid
try {
    Job result = apiInstance.getJob(jobid);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling NamedEntityExtractionApi#getJob");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| jobid |

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="getResult"></a>
# **getResult**
> NamedEntityExtractionResponse getResult(jobid)

Get the extraction results

Get the name entities that are extracted from the text. The name entity extraction response contains a list of name entities for each text. For each name entity the weight is given with other text statistics.

### Example
```java
// Import classes:
//import com.sphereon.sdk.extraction.name.entity.handler.ApiClient;
//import com.sphereon.sdk.extraction.name.entity.handler.ApiException;
//import com.sphereon.sdk.extraction.name.entity.handler.Configuration;
//import com.sphereon.sdk.extraction.name.entity.handler.auth.*;
//import com.sphereon.sdk.extraction.name.entity.api.NamedEntityExtractionApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

NamedEntityExtractionApi apiInstance = new NamedEntityExtractionApi();
String jobid = "jobid_example"; // String | jobid
try {
    NamedEntityExtractionResponse result = apiInstance.getResult(jobid);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling NamedEntityExtractionApi#getResult");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| jobid |

### Return type

[**NamedEntityExtractionResponse**](NamedEntityExtractionResponse.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: Not defined
 - **Accept**: application/json;charset=UTF-8

<a name="submitJob"></a>
# **submitJob**
> Job submitJob(jobid, settings)

Submit name entity extraction job for processing

Start name entity extraction. The extraction is done on the previously texts. The settings supplied with the job in the request body are used for the name entity extraction. You can only submit the job after a new Job is created with status INPUTS_UPLOADED or resubmit an existing Job with status ERROR. In all cases the job Id in the path must match the jobId in the request.

### Example
```java
// Import classes:
//import com.sphereon.sdk.extraction.name.entity.handler.ApiClient;
//import com.sphereon.sdk.extraction.name.entity.handler.ApiException;
//import com.sphereon.sdk.extraction.name.entity.handler.Configuration;
//import com.sphereon.sdk.extraction.name.entity.handler.auth.*;
//import com.sphereon.sdk.extraction.name.entity.api.NamedEntityExtractionApi;

ApiClient defaultClient = Configuration.getDefaultApiClient();

// Configure OAuth2 access token for authorization: oauth2schema
OAuth oauth2schema = (OAuth) defaultClient.getAuthentication("oauth2schema");
oauth2schema.setAccessToken("YOUR ACCESS TOKEN");

NamedEntityExtractionApi apiInstance = new NamedEntityExtractionApi();
String jobid = "jobid_example"; // String | jobid
JobSettings settings = new JobSettings(); // JobSettings | settings
try {
    Job result = apiInstance.submitJob(jobid, settings);
    System.out.println(result);
} catch (ApiException e) {
    System.err.println("Exception when calling NamedEntityExtractionApi#submitJob");
    e.printStackTrace();
}
```

### Parameters

Name | Type | Description  | Notes
------------- | ------------- | ------------- | -------------
 **jobid** | **String**| jobid |
 **settings** | [**JobSettings**](JobSettings.md)| settings |

### Return type

[**Job**](Job.md)

### Authorization

[oauth2schema](../README.md#oauth2schema)

### HTTP request headers

 - **Content-Type**: application/json
 - **Accept**: application/json;charset=UTF-8

