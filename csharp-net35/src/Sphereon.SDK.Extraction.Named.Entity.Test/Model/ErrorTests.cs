/* 
 * Name Entity Extraction
 *
 * The Name Entity Extraction API allows you to extract name entities from text. Name entities can be extracted from text, file or stream location. With each extracted name entity a type of entity and a probability will be given.    The flow is generally as follows:  1. Create an extraction job. If no settings are provided, default settings are used.  2. Upload content for extraction.  3. Start the extraction job.  3. Get the result when the extraction is completed.    Full API Documentation: https://docs.sphereon.com/api/extraction/name/entity/0.1/html  Interactive testing: A web based test console is available in the Sphereon API Store at https://store.sphereon.com
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */


using NUnit.Framework;

using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using Sphereon.SDK.Extraction.Named.Entity.Api;
using Sphereon.SDK.Extraction.Named.Entity.Model;
using Sphereon.SDK.Extraction.Named.Entity.Client;
using System.Reflection;

namespace Sphereon.SDK.Extraction.Named.Entity.Test
{
    /// <summary>
    ///  Class for testing Error
    /// </summary>
    /// <remarks>
    /// This file is automatically generated by Swagger Codegen.
    /// Please update the test case below to test the model.
    /// </remarks>
    [TestFixture]
    public class ErrorTests
    {
        // TODO uncomment below to declare an instance variable for Error
        //private Error instance;

        /// <summary>
        /// Setup before each test
        /// </summary>
        [SetUp]
        public void Init()
        {
            // TODO uncomment below to create an instance of Error
            //instance = new Error();
        }

        /// <summary>
        /// Clean up after each test
        /// </summary>
        [TearDown]
        public void Cleanup()
        {

        }

        /// <summary>
        /// Test an instance of Error
        /// </summary>
        [Test]
        public void ErrorInstanceTest()
        {
            // TODO uncomment below to test "IsInstanceOfType" Error
            //Assert.IsInstanceOfType<Error> (instance, "variable 'instance' is a Error");
        }

        /// <summary>
        /// Test the property 'Code'
        /// </summary>
        [Test]
        public void CodeTest()
        {
            // TODO unit test for the property 'Code'
        }
        /// <summary>
        /// Test the property 'Level'
        /// </summary>
        [Test]
        public void LevelTest()
        {
            // TODO unit test for the property 'Level'
        }
        /// <summary>
        /// Test the property 'Cause'
        /// </summary>
        [Test]
        public void CauseTest()
        {
            // TODO unit test for the property 'Cause'
        }
        /// <summary>
        /// Test the property 'Message'
        /// </summary>
        [Test]
        public void MessageTest()
        {
            // TODO unit test for the property 'Message'
        }

    }

}
