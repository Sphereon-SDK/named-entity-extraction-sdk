# named-entity-extraction-sdk-java8-okhttp-gson

## Requirements

Building the API client library requires [Maven](https://maven.apache.org/) to be installed.

## Installation

To install the API client library to your local Maven repository, simply execute:

```shell
mvn install
```

To deploy it to a remote Maven repository instead, configure the settings of the repository and execute:

```shell
mvn deploy
```

Refer to the [official documentation](https://maven.apache.org/plugins/maven-deploy-plugin/usage.html) for more information.

### Maven users

Add this dependency to your project's POM:

```xml
<dependency>
    <groupId>com.sphereon.sdk</groupId>
    <artifactId>named-entity-extraction-sdk-java8-okhttp-gson</artifactId>
    <version>0.1.0-SNAPSHOT</version>
    <scope>compile</scope>
</dependency>
```

### Gradle users

Add this dependency to your project's build file:

```groovy
compile "com.sphereon.sdk:named-entity-extraction-sdk-java8-okhttp-gson:0.1.0-SNAPSHOT"
```

### Others

At first generate the JAR by executing:

    mvn package

Then manually install the following JARs:

* target/named-entity-extraction-sdk-java8-okhttp-gson-0.1.0-SNAPSHOT.jar
* target/lib/*.jar

## Getting Started

Please follow the [installation](#installation) instruction and execute the following Java code:

```java

import com.sphereon.sdk.extraction.name.entity.handler.*;
import com.sphereon.sdk.extraction.name.entity.handler.auth.*;
import com.sphereon.sdk.extraction.name.entity.model.*;
import com.sphereon.sdk.extraction.name.entity.api.NamedEntityExtractionApi;

import java.io.File;
import java.util.*;

public class NamedEntityExtractionApiExample {

    public static void main(String[] args) {
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
    }
}

```

## Documentation for API Endpoints

All URIs are relative to *https://gw.api.cloud.sphereon.com/extraction/name/entity/0.1*

Class | Method | HTTP request | Description
------------ | ------------- | ------------- | -------------
*NamedEntityExtractionApi* | [**addInputText**](docs/NamedEntityExtractionApi.md#addInputText) | **POST** /extraction/name/entity/jobs/{jobid}/streams/text | Upload text
*NamedEntityExtractionApi* | [**createJob**](docs/NamedEntityExtractionApi.md#createJob) | **POST** /extraction/name/entity/jobs | Create a name entity extraction job
*NamedEntityExtractionApi* | [**deleteJob**](docs/NamedEntityExtractionApi.md#deleteJob) | **DELETE** /extraction/name/entity/jobs/{jobid} | Delete a job manually
*NamedEntityExtractionApi* | [**getJob**](docs/NamedEntityExtractionApi.md#getJob) | **GET** /extraction/name/entity/jobs/{jobid} | Job definition and state
*NamedEntityExtractionApi* | [**getResult**](docs/NamedEntityExtractionApi.md#getResult) | **GET** /extraction/name/entity/jobs/{jobid}/result | Get the extraction results
*NamedEntityExtractionApi* | [**submitJob**](docs/NamedEntityExtractionApi.md#submitJob) | **PUT** /extraction/name/entity/jobs/{jobid} | Submit name entity extraction job for processing


## Documentation for Models

 - [Error](docs/Error.md)
 - [ErrorResponse](docs/ErrorResponse.md)
 - [InputEntry](docs/InputEntry.md)
 - [Job](docs/Job.md)
 - [JobSettings](docs/JobSettings.md)
 - [NamedEntity](docs/NamedEntity.md)
 - [NamedEntityExtractionResponse](docs/NamedEntityExtractionResponse.md)
 - [NamedEntityList](docs/NamedEntityList.md)
 - [TextInput](docs/TextInput.md)


## Documentation for Authorization

Authentication schemes defined for the API:
### oauth2schema

- **Type**: OAuth
- **Flow**: application
- **Authorization URL**: 
- **Scopes**: 
  - global: accessEverything


## Recommendation

It's recommended to create an instance of `ApiClient` per thread in a multithreaded environment to avoid any potential issues.

## Author

dev@sphereon.com

