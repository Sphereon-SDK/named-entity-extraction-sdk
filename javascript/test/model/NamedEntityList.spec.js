/**
 * Name Entity Extraction
 * The Name Entity Extraction API allows you to extract name entities from text. Name entities can be extracted from text, file or stream location. With each extracted name entity a type of entity and a probability will be given.    The flow is generally as follows:  1. Create an extraction job. If no settings are provided, default settings are used.  2. Upload content for extraction.  3. Start the extraction job.  3. Get the result when the extraction is completed.    Full API Documentation: https://docs.sphereon.com/api/extraction/name/entity/0.1/html  Interactive testing: A web based test console is available in the Sphereon API Store at https://store.sphereon.com
 *
 * OpenAPI spec version: 0.1
 * Contact: dev@sphereon.com
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 *
 * Swagger Codegen version: 2.2.3
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD.
    define(['expect.js', '../../src/index'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    factory(require('expect.js'), require('../../src/index'));
  } else {
    // Browser globals (root is window)
    factory(root.expect, root.NameEntityExtraction);
  }
}(this, function(expect, NameEntityExtraction) {
  'use strict';

  var instance;

  beforeEach(function() {
    instance = new NameEntityExtraction.NamedEntityList();
  });

  var getProperty = function(object, getter, property) {
    // Use getter method if present; otherwise, get the property directly.
    if (typeof object[getter] === 'function')
      return object[getter]();
    else
      return object[property];
  }

  var setProperty = function(object, setter, property, value) {
    // Use setter method if present; otherwise, set the property directly.
    if (typeof object[setter] === 'function')
      object[setter](value);
    else
      object[property] = value;
  }

  describe('NamedEntityList', function() {
    it('should create an instance of NamedEntityList', function() {
      // uncomment below and update the code to test NamedEntityList
      //var instane = new NameEntityExtraction.NamedEntityList();
      //expect(instance).to.be.a(NameEntityExtraction.NamedEntityList);
    });

    it('should have the property namedEntities (base name: "namedEntities")', function() {
      // uncomment below and update the code to test the property namedEntities
      //var instane = new NameEntityExtraction.NamedEntityList();
      //expect(instance).to.be();
    });

  });

}));
