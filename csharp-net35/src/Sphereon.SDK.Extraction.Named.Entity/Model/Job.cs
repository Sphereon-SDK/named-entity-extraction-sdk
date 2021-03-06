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
    /// Extraction Job
    /// </summary>
    [DataContract]
    public partial class Job :  IEquatable<Job>
    {
        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StateEnum
        {
            
            /// <summary>
            /// Enum INPUTSUPLOADED for "INPUTS_UPLOADED"
            /// </summary>
            [EnumMember(Value = "INPUTS_UPLOADED")]
            INPUTSUPLOADED,
            
            /// <summary>
            /// Enum PROCESSING for "PROCESSING"
            /// </summary>
            [EnumMember(Value = "PROCESSING")]
            PROCESSING,
            
            /// <summary>
            /// Enum DONE for "DONE"
            /// </summary>
            [EnumMember(Value = "DONE")]
            DONE,
            
            /// <summary>
            /// Enum ERROR for "ERROR"
            /// </summary>
            [EnumMember(Value = "ERROR")]
            ERROR,
            
            /// <summary>
            /// Enum DELETED for "DELETED"
            /// </summary>
            [EnumMember(Value = "DELETED")]
            DELETED
        }

        /// <summary>
        /// The status of the job
        /// </summary>
        /// <value>The status of the job</value>
        [DataMember(Name="state", EmitDefaultValue=false)]
        public StateEnum? State { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Job() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Job" /> class.
        /// </summary>
        /// <param name="JobId">JobId.</param>
        /// <param name="Inputs">The input entries.</param>
        /// <param name="JobSettings">JobSettings (required).</param>
        public Job(string JobId = default(string), List<InputEntry> Inputs = default(List<InputEntry>), JobSettings JobSettings = default(JobSettings))
        {
            // to ensure "JobSettings" is required (not null)
            if (JobSettings == null)
            {
                throw new InvalidDataException("JobSettings is a required property for Job and cannot be null");
            }
            else
            {
                this.JobSettings = JobSettings;
            }
            this.JobId = JobId;
            this.Inputs = Inputs;
        }
        
        /// <summary>
        /// The completion date/time of this job in ISO 8601 format
        /// </summary>
        /// <value>The completion date/time of this job in ISO 8601 format</value>
        [DataMember(Name="completionTime", EmitDefaultValue=false)]
        public DateTime? CompletionTime { get; private set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name="jobId", EmitDefaultValue=false)]
        public string JobId { get; set; }

        /// <summary>
        /// The creation date/time of this job in ISO 8601 format
        /// </summary>
        /// <value>The creation date/time of this job in ISO 8601 format</value>
        [DataMember(Name="creationTime", EmitDefaultValue=false)]
        public DateTime? CreationTime { get; private set; }

        /// <summary>
        /// The input entries
        /// </summary>
        /// <value>The input entries</value>
        [DataMember(Name="inputs", EmitDefaultValue=false)]
        public List<InputEntry> Inputs { get; set; }

        /// <summary>
        /// Gets or Sets JobSettings
        /// </summary>
        [DataMember(Name="jobSettings", EmitDefaultValue=false)]
        public JobSettings JobSettings { get; set; }

        /// <summary>
        /// The last update date/time of this job in ISO 8601 format
        /// </summary>
        /// <value>The last update date/time of this job in ISO 8601 format</value>
        [DataMember(Name="updateTime", EmitDefaultValue=false)]
        public DateTime? UpdateTime { get; private set; }


        /// <summary>
        /// The queue date/time of this job in ISO 8601 format
        /// </summary>
        /// <value>The queue date/time of this job in ISO 8601 format</value>
        [DataMember(Name="queueTime", EmitDefaultValue=false)]
        public DateTime? QueueTime { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Job {\n");
            sb.Append("  CompletionTime: ").Append(CompletionTime).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  CreationTime: ").Append(CreationTime).Append("\n");
            sb.Append("  Inputs: ").Append(Inputs).Append("\n");
            sb.Append("  JobSettings: ").Append(JobSettings).Append("\n");
            sb.Append("  UpdateTime: ").Append(UpdateTime).Append("\n");
            sb.Append("  State: ").Append(State).Append("\n");
            sb.Append("  QueueTime: ").Append(QueueTime).Append("\n");
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
            return this.Equals(obj as Job);
        }

        /// <summary>
        /// Returns true if Job instances are equal
        /// </summary>
        /// <param name="other">Instance of Job to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Job other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.CompletionTime == other.CompletionTime ||
                    this.CompletionTime != null &&
                    this.CompletionTime.Equals(other.CompletionTime)
                ) && 
                (
                    this.JobId == other.JobId ||
                    this.JobId != null &&
                    this.JobId.Equals(other.JobId)
                ) && 
                (
                    this.CreationTime == other.CreationTime ||
                    this.CreationTime != null &&
                    this.CreationTime.Equals(other.CreationTime)
                ) && 
                (
                    this.Inputs == other.Inputs ||
                    this.Inputs != null &&
                    this.Inputs.SequenceEqual(other.Inputs)
                ) && 
                (
                    this.JobSettings == other.JobSettings ||
                    this.JobSettings != null &&
                    this.JobSettings.Equals(other.JobSettings)
                ) && 
                (
                    this.UpdateTime == other.UpdateTime ||
                    this.UpdateTime != null &&
                    this.UpdateTime.Equals(other.UpdateTime)
                ) && 
                (
                    this.State == other.State ||
                    this.State != null &&
                    this.State.Equals(other.State)
                ) && 
                (
                    this.QueueTime == other.QueueTime ||
                    this.QueueTime != null &&
                    this.QueueTime.Equals(other.QueueTime)
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
                if (this.CompletionTime != null)
                    hash = hash * 59 + this.CompletionTime.GetHashCode();
                if (this.JobId != null)
                    hash = hash * 59 + this.JobId.GetHashCode();
                if (this.CreationTime != null)
                    hash = hash * 59 + this.CreationTime.GetHashCode();
                if (this.Inputs != null)
                    hash = hash * 59 + this.Inputs.GetHashCode();
                if (this.JobSettings != null)
                    hash = hash * 59 + this.JobSettings.GetHashCode();
                if (this.UpdateTime != null)
                    hash = hash * 59 + this.UpdateTime.GetHashCode();
                if (this.State != null)
                    hash = hash * 59 + this.State.GetHashCode();
                if (this.QueueTime != null)
                    hash = hash * 59 + this.QueueTime.GetHashCode();
                return hash;
            }
        }

    }

}
