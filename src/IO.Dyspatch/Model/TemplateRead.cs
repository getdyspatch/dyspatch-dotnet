/* 
 * Dyspatch API
 *
 * # Introduction  The Dyspatch API is based on the REST paradigm, and features resource based URLs with standard HTTP response codes to indicate errors. We use standard HTTP authentication and request verbs, and all responses are JSON formatted. See our [Implementation Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more details on how to implement Dyspatch.  ## API Client Libraries Dyspatch provides API Clients for popular languages and web frameworks.  - [Java](https://github.com/getdyspatch/dyspatch-java) - [Javascript](https://github.com/getdyspatch/dyspatch-javascript) - [Python](https://github.com/getdyspatch/dyspatch-python) - [C#](https://github.com/getdyspatch/dyspatch-dotnet) - [Go](https://github.com/getdyspatch/dyspatch-golang) - [Ruby](https://github.com/getdyspatch/dyspatch-ruby) 
 *
 * The version of the OpenAPI document: 2020.08
 * Contact: support@dyspatch.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
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
using OpenAPIDateConverter = IO.Dyspatch.Client.OpenAPIDateConverter;

namespace IO.Dyspatch.Model
{
    /// <summary>
    /// list of template metadata
    /// </summary>
    [DataContract]
    public partial class TemplateRead :  IEquatable<TemplateRead>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateRead" /> class.
        /// </summary>
        /// <param name="id">An opaque, unique identifier for a template.</param>
        /// <param name="name">The name of a template.</param>
        /// <param name="description">A description of the template.</param>
        /// <param name="url">The API url for a specific template.</param>
        /// <param name="compiled">compiled.</param>
        /// <param name="createdAt">The time of initial creation.</param>
        /// <param name="updatedAt">The time of last update.</param>
        /// <param name="localizations">A list of the Template&#39;s available localizations.</param>
        public TemplateRead(string id = default(string), string name = default(string), string description = default(string), string url = default(string), CompiledRead compiled = default(CompiledRead), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset), List<LocalizationMetaRead> localizations = default(List<LocalizationMetaRead>))
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;
            this.Url = url;
            this.Compiled = compiled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Localizations = localizations;
        }
        
        /// <summary>
        /// An opaque, unique identifier for a template
        /// </summary>
        /// <value>An opaque, unique identifier for a template</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The name of a template
        /// </summary>
        /// <value>The name of a template</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// A description of the template
        /// </summary>
        /// <value>A description of the template</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// The API url for a specific template
        /// </summary>
        /// <value>The API url for a specific template</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Compiled
        /// </summary>
        [DataMember(Name="compiled", EmitDefaultValue=false)]
        public CompiledRead Compiled { get; set; }

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
        /// A list of the Template&#39;s available localizations
        /// </summary>
        /// <value>A list of the Template&#39;s available localizations</value>
        [DataMember(Name="localizations", EmitDefaultValue=false)]
        public List<LocalizationMetaRead> Localizations { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplateRead {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Compiled: ").Append(Compiled).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Localizations: ").Append(Localizations).Append("\n");
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
            return this.Equals(input as TemplateRead);
        }

        /// <summary>
        /// Returns true if TemplateRead instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateRead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateRead input)
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Compiled == input.Compiled ||
                    (this.Compiled != null &&
                    this.Compiled.Equals(input.Compiled))
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
                ) && 
                (
                    this.Localizations == input.Localizations ||
                    this.Localizations != null &&
                    input.Localizations != null &&
                    this.Localizations.SequenceEqual(input.Localizations)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Compiled != null)
                    hashCode = hashCode * 59 + this.Compiled.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Localizations != null)
                    hashCode = hashCode * 59 + this.Localizations.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
