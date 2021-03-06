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
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = Sphereon.SDK.Extraction.Named.Entity.Client.SwaggerDateConverter;

namespace Sphereon.SDK.Extraction.Named.Entity.Model
{
    /// <summary>
    /// Name entity extraction response for a job
    /// </summary>
    [DataContract]
    public partial class NamedEntityExtractionResponse :  IEquatable<NamedEntityExtractionResponse>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="NamedEntityExtractionResponse" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="NamedEntities">The name entities that are extracted for each input.</param>
        /// <param name="Job">The extraction job.</param>
        /// <param name="Errors">The errors that occurred.</param>
        public NamedEntityExtractionResponse(string JobId = default(string), Dictionary<string, NamedEntityList> NamedEntities = default(Dictionary<string, NamedEntityList>), Job Job = default(Job), List<string> Errors = default(List<string>))
        {
            this.JobId = JobId;
            this.NamedEntities = NamedEntities;
            this.Job = Job;
            this.Errors = Errors;
        }
        
        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The name entities that are extracted for each input
        /// </summary>
        /// <value>The name entities that are extracted for each input</value>
        [DataMember(Name="namedEntities", EmitDefaultValue=false)]
        public Dictionary<string, NamedEntityList> NamedEntities { get; set; }

        /// <summary>
        /// The extraction job
        /// </summary>
        /// <value>The extraction job</value>
        [DataMember(Name="job", EmitDefaultValue=false)]
        public Job Job { get; set; }

        /// <summary>
        /// The errors that occurred
        /// </summary>
        /// <value>The errors that occurred</value>
        [DataMember(Name="errors", EmitDefaultValue=false)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NamedEntityExtractionResponse {\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  NamedEntities: ").Append(NamedEntities).Append("\n");
            sb.Append("  Job: ").Append(Job).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="obj">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object obj)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            return this.Equals(obj as NamedEntityExtractionResponse);
        }

        /// <summary>
        /// Returns true if NamedEntityExtractionResponse instances are equal
        /// </summary>
        /// <param name="other">Instance of NamedEntityExtractionResponse to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NamedEntityExtractionResponse other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) && 
                (
                    this.NamedEntities == other.NamedEntities ||
                    this.NamedEntities != null &&
                    this.NamedEntities.SequenceEqual(other.NamedEntities)
                ) && 
                (
                    this.Job == other.Job ||
                    this.Job != null &&
                    this.Job.Equals(other.Job)
                ) && 
                (
                    this.Errors == other.Errors ||
                    this.Errors != null &&
                    this.Errors.SequenceEqual(other.Errors)
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            // credit: http://stackoverflow.com/a/263416/677735
            unchecked // Overflow is fine, just wrap
            {
                int hash = 41;
                // Suitable nullity checks etc, of course :)
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();
                if (this.NamedEntities != null)
                    hash = hash * 59 + this.NamedEntities.GetHashCode();
                if (this.Job != null)
                    hash = hash * 59 + this.Job.GetHashCode();
                if (this.Errors != null)
                    hash = hash * 59 + this.Errors.GetHashCode();
                return hash;
            }
        }

    }

}
