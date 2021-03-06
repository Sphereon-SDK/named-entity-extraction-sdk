/*
 * Name Entity Extraction
 * The Name Entity Extraction API allows you to extract name entities from text. Name entities can be extracted from text, file or stream location. With each extracted name entity a type of entity and a probability will be given.    The flow is generally as follows:  1. Create an extraction job. If no settings are provided, default settings are used.  2. Upload content for extraction.  3. Start the extraction job.  3. Get the result when the extraction is completed.    Full API Documentation: https://docs.sphereon.com/api/extraction/name/entity/0.1/html  Interactive testing: A web based test console is available in the Sphereon API Store at https://store.sphereon.com
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package com.sphereon.sdk.extraction.name.entity.api;

import com.sphereon.sdk.extraction.name.entity.handler.ApiClient;
import com.sphereon.sdk.extraction.name.entity.handler.ApiException;
import com.sphereon.sdk.extraction.name.entity.handler.Configuration;
import com.sphereon.sdk.extraction.name.entity.model.Job;
import com.sphereon.sdk.extraction.name.entity.model.JobSettings;
import com.sphereon.sdk.extraction.name.entity.model.NamedEntityExtractionResponse;
import com.sphereon.sdk.extraction.name.entity.model.NamedEntityList;
import com.sphereon.sdk.extraction.name.entity.model.TextInput;
import org.junit.Assert;
import org.junit.Before;
import org.junit.FixMethodOrder;
import org.junit.Test;
import org.junit.runners.MethodSorters;

import java.util.Map;

/**
 * API tests for NamedEntityExtractionApi
 */
@FixMethodOrder(MethodSorters.NAME_ASCENDING)
public class NamedEntityExtractionApiTest {

    private static String jobId;
    private final NamedEntityExtractionApi api = new NamedEntityExtractionApi();

    @Before
    public void initClient() {
        ApiClient apiClient = Configuration.getDefaultApiClient();
        apiClient.setAccessToken("YOUR_API_TOKEN");
        api.setApiClient(apiClient);
    }

    /**
     * Create a name entity extraction job
     *
     * Create a name entity extraction job with settings. For optional settings defaults will be used
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void _01_createJobTest() throws ApiException {
        JobSettings jobSettings = new JobSettings();
        jobSettings.setEngine(JobSettings.EngineEnum.BASIC);

        Job response = api.createJob(jobSettings);

        Assert.assertNotNull(response);
        Assert.assertNotNull(response.getJobId());
        Assert.assertEquals(Job.StateEnum.INPUTS_UPLOADED, response.getState());

        jobId = response.getJobId();
    }

    /**
     * Upload text
     *
     * Upload text for name entity extraction. Name entity extraction will start after submitting the job.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void _02_addInputTextTest() throws ApiException {
        String text = "Gratis af te halen in Assen: een monumentaal kunstwerk. Er is één maar: het kunstwerk is 15 meter hoog.\n" +
                "Het gaat om een kunstwerk dat vanaf 1989 voor het station in Assen stond en door de Haarlemse kunstenaar Jan Jacobs Mulder is gemaakt. Het werk heet Aarde, Water, Huis en bestaat uit drie delen: een stalen sokkel met daarboven twee stalen frames.\n" +
                "Het kunstwerk is van de gemeente. Die verwijderde het in 2013 omdat het stationsgebied wordt heringericht, schrijft RTV Drenthe. De werkgroep Monumentale Kunst van erfgoedvereniging Heemschut kwam erachter dat het sindsdien - zo omschrijft Norman Vervat van de werkgroep - \"op een werf lag weg te roesten.\"\n" +
                "Plein, rotonde of verzamelaar\n" +
                "Assen gaat het niet terugplaatsen en vroeg de werkgroep te helpen bij het zoeken naar een ander \"tehuis\". Vervat: \"We denken aan een plein, park of rotonde. Of aan een verzamelaar met een grote tuin.\"\n" +
                "Hij heeft al enkele mailtjes van belangstellenden binnen. De nieuwe eigenaar moet wel over geld beschikken: het werk moet worden opgeknapt en moet bij herplaatsing een fundering krijgen (kosten: 15.000 euro). Het tienjaarlijkse onderhoud kost ook enkele duizenden euro's.";


        TextInput textInput = new TextInput();
        textInput.setText(text);
        Job response = api.addInputText(jobId, textInput);

        Assert.assertNotNull(response);
        Assert.assertNotNull(response.getInputs());
        Assert.assertEquals(1, response.getInputs().size());
        Assert.assertEquals(text, response.getInputs().get(0).getTextInput().getText());
    }

    /**
     * Submit name entity extraction job for processing
     *
     * Start name entity extraction. The extraction is done on the previously texts. The settings supplied with the job in the request body are used for the name entity extraction. You can only submit the job after a new Job is created with status INPUTS_UPLOADED or resubmit an existing Job with status ERROR. In all cases the job Id in the path must match the jobId in the request.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void _03_submitJobTest() throws ApiException {
        JobSettings settings = new JobSettings();
        settings.setEngine(JobSettings.EngineEnum.BASIC);

        Job response = api.submitJob(jobId, settings);

        Assert.assertNotNull(response);
        Assert.assertEquals(Job.StateEnum.PROCESSING, response.getState());
    }

    /**
     * Job definition and state
     *
     * Get the name entity extraction job definition and current state. Please note that you can differentiate based on http response status.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void _04_getJobTest() throws ApiException, InterruptedException {
        // poll job state change
        int sleepTime = 1000;
        int maxCount = 180; // wait at most 3 min for api to complete
        int count = 0;

        while (count < maxCount) {
            Thread.sleep(sleepTime);

            count++;
            Job response = api.getJob(jobId);
            Assert.assertNotNull(response);

            if (response.getState().equals(Job.StateEnum.DONE)) {
                Assert.assertNotNull(response.getCreationTime());
                Assert.assertNotNull(response.getUpdateTime());
                Assert.assertNotNull(response.getQueueTime());
                Assert.assertNotNull(response.getCompletionTime());

                break;
            }
        }
    }

    /**
     * Get the extraction results
     *
     * Get the name entities that are extracted from the text. The name entity extraction response contains a list of name entities for each text. For each name entity the weight is given with other text statistics.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void _05_getResultTest() throws ApiException {
        NamedEntityExtractionResponse response = api.getResult(jobId);

        Assert.assertNotNull(response);
        Assert.assertNotNull(response.getJob());
        Assert.assertNotNull(response.getNamedEntities());
        Assert.assertEquals(1, response.getNamedEntities().size());

        for (Map.Entry<String, NamedEntityList> entry : response.getNamedEntities().entrySet()) {
            System.out.println("entry = " + entry);
        }
    }

    /**
     * Delete a job manually
     *
     * Delete the job and all related files.
     *
     * @throws ApiException
     *          if the Api call fails
     */
    @Test
    public void _06_deleteJobTest() throws ApiException {
        Job response = api.deleteJob(jobId);

        Assert.assertNotNull(response);
        Assert.assertEquals(Job.StateEnum.DELETED, response.getState());
    }
    
}
