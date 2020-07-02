/* 
 * Dyspatch API
 *
 * # Introduction  The Dyspatch API is based on the REST paradigm, and features resource based URLs with standard HTTP response codes to indicate errors. We use standard HTTP authentication and request verbs, and all responses are JSON formatted. See our [Implementation Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more details on how to implement Dyspatch.  ## API Client Libraries Dyspatch provides API Clients for popular languages and web frameworks.  - [Java](https://github.com/getdyspatch/dyspatch-java) - [Javascript](https://github.com/getdyspatch/dyspatch-javascript) - [Python](https://github.com/getdyspatch/dyspatch-python) - [C#](https://github.com/getdyspatch/dyspatch-dotnet) - [Go](https://github.com/getdyspatch/dyspatch-golang) - [Ruby](https://github.com/getdyspatch/dyspatch-ruby) 
 *
 * The version of the OpenAPI document: 2020.04
 * Contact: support@dyspatch.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using OpenAPIDateConverter = IO.Dyspatch.Client.OpenAPIDateConverter;

namespace IO.Dyspatch.Model
{
    /// <summary>
    /// draft metadata
    /// </summary>
    [DataContract]
    public partial class DraftMetaRead :  IEquatable<DraftMetaRead>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DraftMetaRead" /> class.
        /// </summary>
        /// <param name="id">An opaque, unique identifier for a draft.</param>
        /// <param name="templateId">An opaque, unique identifier for a template.</param>
        /// <param name="name">The name of a draft.</param>
        /// <param name="url">The API url for a specific draft.</param>
        /// <param name="createdAt">The time of initial creation.</param>
        /// <param name="updatedAt">The time of last update.</param>
        public DraftMetaRead(string id = default(string), string templateId = default(string), string name = default(string), string url = default(string), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset))
        {
            this.Id = id;
            this.TemplateId = templateId;
            this.Name = name;
            this.Url = url;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }
        
        /// <summary>
        /// An opaque, unique identifier for a draft
        /// </summary>
        /// <value>An opaque, unique identifier for a draft</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// An opaque, unique identifier for a template
        /// </summary>
        /// <value>An opaque, unique identifier for a template</value>
        [DataMember(Name="templateId", EmitDefaultValue=false)]
        public string TemplateId { get; set; }

        /// <summary>
        /// The name of a draft
        /// </summary>
        /// <value>The name of a draft</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// The API url for a specific draft
        /// </summary>
        /// <value>The API url for a specific draft</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// The time of initial creation
        /// </summary>
        /// <value>The time of initial creation</value>
        [DataMember(Name="createdAt", EmitDefaultValue=false)]
        public DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The time of last update
        /// </summary>
        /// <value>The time of last update</value>
        [DataMember(Name="updatedAt", EmitDefaultValue=false)]
        public DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DraftMetaRead {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as DraftMetaRead);
        }

        /// <summary>
        /// Returns true if DraftMetaRead instances are equal
        /// </summary>
        /// <param name="input">Instance of DraftMetaRead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DraftMetaRead input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                return hashCode;
            }
        }
    }

}
