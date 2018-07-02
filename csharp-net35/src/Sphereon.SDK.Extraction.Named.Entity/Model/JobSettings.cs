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
    /// Job settings
    /// </summary>
    [DataContract]
    public partial class JobSettings :  IEquatable<JobSettings>
    {
        /// <summary>
        /// The engine defines the quality that will be used to process the job
        /// </summary>
        /// <value>The engine defines the quality that will be used to process the job</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EngineEnum
        {
            
            /// <summary>
            /// Enum BASIC for "BASIC"
            /// </summary>
            [EnumMember(Value = "BASIC")]
            BASIC
        }

        /// <summary>
        /// The engine defines the quality that will be used to process the job
        /// </summary>
        /// <value>The engine defines the quality that will be used to process the job</value>
        [DataMember(Name="engine", EmitDefaultValue=false)]
        public EngineEnum? Engine { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobSettings" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected JobSettings() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="JobSettings" /> class.
        /// </summary>
        /// <param name="Engine">The engine defines the quality that will be used to process the job (required).</param>
        public JobSettings(EngineEnum? Engine = default(EngineEnum?))
        {
            // to ensure "Engine" is required (not null)
            if (Engine == null)
            {
                throw new InvalidDataException("Engine is a required property for JobSettings and cannot be null");
            }
            else
            {
                this.Engine = Engine;
            }
        }
        

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class JobSettings {\n");
            sb.Append("  Engine: ").Append(Engine).Append("\n");
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
            return this.Equals(obj as JobSettings);
        }

        /// <summary>
        /// Returns true if JobSettings instances are equal
        /// </summary>
        /// <param name="other">Instance of JobSettings to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(JobSettings other)
        {
            // credit: http://stackoverflow.com/a/10454552/677735
            if (other == null)
                return false;

            return 
                (
                    this.Engine == other.Engine ||
                    this.Engine != null &&
                    this.Engine.Equals(other.Engine)
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
                if (this.Engine != null)
                    hash = hash * 59 + this.Engine.GetHashCode();
                return hash;
            }
        }

    }

}