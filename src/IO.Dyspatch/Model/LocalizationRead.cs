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
    /// localization metadata and latest revision for associated template
    /// </summary>
    [DataContract]
    public partial class LocalizationRead :  IEquatable<LocalizationRead>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LocalizationRead" /> class.
        /// </summary>
        /// <param name="id">An opaque, unique identifier for a localization.</param>
        /// <param name="languages">a list of locale codes that are available in the localization. See [supported languages](https://docs.dyspatch.io/localization/supported_languages/) for an exhaustive list of locale codes. .</param>
        /// <param name="url">The API url for a specific localization.</param>
        /// <param name="template">An opaque, unique identifier for a template.</param>
        /// <param name="compiled">compiled.</param>
        /// <param name="createdAt">The time of initial creation.</param>
        /// <param name="updatedAt">The time of last update.</param>
        /// <param name="name">The user-specified name of a localization.</param>
        /// <param name="localeGroup">the locale group this localization belongs to, if this field is empty the localization does not belong to any locale group.</param>
        public LocalizationRead(string id = default(string), List<string> languages = default(List<string>), string url = default(string), string template = default(string), CompiledRead compiled = default(CompiledRead), DateTimeOffset createdAt = default(DateTimeOffset), DateTimeOffset updatedAt = default(DateTimeOffset), string name = default(string), string localeGroup = default(string))
        {
            this.Id = id;
            this.Languages = languages;
            this.Url = url;
            this.Template = template;
            this.Compiled = compiled;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.LocaleGroup = localeGroup;
        }
        
        /// <summary>
        /// An opaque, unique identifier for a localization
        /// </summary>
        /// <value>An opaque, unique identifier for a localization</value>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// a list of locale codes that are available in the localization. See [supported languages](https://docs.dyspatch.io/localization/supported_languages/) for an exhaustive list of locale codes. 
        /// </summary>
        /// <value>a list of locale codes that are available in the localization. See [supported languages](https://docs.dyspatch.io/localization/supported_languages/) for an exhaustive list of locale codes. </value>
        [DataMember(Name="languages", EmitDefaultValue=false)]
        public List<string> Languages { get; set; }

        /// <summary>
        /// The API url for a specific localization
        /// </summary>
        /// <value>The API url for a specific localization</value>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// An opaque, unique identifier for a template
        /// </summary>
        /// <value>An opaque, unique identifier for a template</value>
        [DataMember(Name="template", EmitDefaultValue=false)]
        public string Template { get; set; }

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
        /// The user-specified name of a localization
        /// </summary>
        /// <value>The user-specified name of a localization</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// the locale group this localization belongs to, if this field is empty the localization does not belong to any locale group
        /// </summary>
        /// <value>the locale group this localization belongs to, if this field is empty the localization does not belong to any locale group</value>
        [DataMember(Name="localeGroup", EmitDefaultValue=false)]
        public string LocaleGroup { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class LocalizationRead {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Languages: ").Append(Languages).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  Compiled: ").Append(Compiled).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  LocaleGroup: ").Append(LocaleGroup).Append("\n");
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
            return this.Equals(input as LocalizationRead);
        }

        /// <summary>
        /// Returns true if LocalizationRead instances are equal
        /// </summary>
        /// <param name="input">Instance of LocalizationRead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LocalizationRead input)
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
                    this.Languages == input.Languages ||
                    this.Languages != null &&
                    input.Languages != null &&
                    this.Languages.SequenceEqual(input.Languages)
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
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
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.LocaleGroup == input.LocaleGroup ||
                    (this.LocaleGroup != null &&
                    this.LocaleGroup.Equals(input.LocaleGroup))
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
                if (this.Languages != null)
                    hashCode = hashCode * 59 + this.Languages.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.Compiled != null)
                    hashCode = hashCode * 59 + this.Compiled.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.LocaleGroup != null)
                    hashCode = hashCode * 59 + this.LocaleGroup.GetHashCode();
                return hashCode;
            }
        }
    }

}
