# NameEntityExtraction.NamedEntityExtractionApi

All URIs are relative to *https://gw.api.cloud.sphereon.com/extraction/name/entity/0.1*

Method | HTTP request | Description
------------- | ------------- | -------------
[**addInputText**](NamedEntityExtractionApi.md#addInputText) | **POST** /extraction/name/entity/jobs/{jobid}/streams/text | Upload text
[**createJob**](NamedEntityExtractionApi.md#createJob) | **POST** /extraction/name/entity/jobs | Create a name entity extraction job
[**deleteJob**](NamedEntityExtractionApi.md#deleteJob) | **DELETE** /extraction/name/entity/jobs/{jobid} | Delete a job manually
[**getJob**](NamedEntityExtractionApi.md#getJob) | **GET** /extraction/name/entity/jobs/{jobid} | Job definition and state
[**getResult**](NamedEntityExtractionApi.md#getResult) | **GET** /extraction/name/entity/jobs/{jobid}/result | Get the extraction results
[**submitJob**](NamedEntityExtractionApi.md#submitJob) | **PUT** /extraction/name/entity/jobs/{jobid} | Submit name entity extraction job for processing


<a name="addInputText"></a>
# **addInputText**
> Job addInputText(jobid, textInput)

Upload text

Upload text for name entity extraction. Name entity extraction will start after submitting the job.

### Example
```javascript
var NameEntityExtraction = require('name_entity_extraction');
var defaultClient = NameEntityExtraction.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new NameEntityExtraction.NamedEntityExtractionApi();

var jobid = "jobid_example"; // String | jobid

var textInput = new NameEntityExtraction.TextInput(); // TextInput | textInput


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.addInputText(jobid, textInput, callback);
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
```javascript
var NameEntityExtraction = require('name_entity_extraction');
var defaultClient = NameEntityExtraction.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new NameEntityExtraction.NamedEntityExtractionApi();

var jobSettings = new NameEntityExtraction.JobSettings(); // JobSettings | jobSettings


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.createJob(jobSettings, callback);
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
```javascript
var NameEntityExtraction = require('name_entity_extraction');
var defaultClient = NameEntityExtraction.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new NameEntityExtraction.NamedEntityExtractionApi();

var jobid = "jobid_example"; // String | jobid


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.deleteJob(jobid, callback);
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
```javascript
var NameEntityExtraction = require('name_entity_extraction');
var defaultClient = NameEntityExtraction.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new NameEntityExtraction.NamedEntityExtractionApi();

var jobid = "jobid_example"; // String | jobid


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getJob(jobid, callback);
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
```javascript
var NameEntityExtraction = require('name_entity_extraction');
var defaultClient = NameEntityExtraction.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new NameEntityExtraction.NamedEntityExtractionApi();

var jobid = "jobid_example"; // String | jobid


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.getResult(jobid, callback);
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
```javascript
var NameEntityExtraction = require('name_entity_extraction');
var defaultClient = NameEntityExtraction.ApiClient.instance;

// Configure OAuth2 access token for authorization: oauth2schema
var oauth2schema = defaultClient.authentications['oauth2schema'];
oauth2schema.accessToken = 'YOUR ACCESS TOKEN';

var apiInstance = new NameEntityExtraction.NamedEntityExtractionApi();

var jobid = "jobid_example"; // String | jobid

var settings = new NameEntityExtraction.JobSettings(); // JobSettings | settings


var callback = function(error, data, response) {
  if (error) {
    console.error(error);
  } else {
    console.log('API called successfully. Returned data: ' + data);
  }
};
apiInstance.submitJob(jobid, settings, callback);
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

