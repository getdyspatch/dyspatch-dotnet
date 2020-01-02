/* 
 * Dyspatch API
 *
 * # Introduction  The Dyspatch API is based on the REST paradigm, and features resource based URLs with standard HTTP response codes to indicate errors. We use standard HTTP authentication and request verbs, and all responses are JSON formatted. See our [Implementation Guide](https://docs.dyspatch.io/development/implementing_dyspatch/) for more details on how to implement Dyspatch.  ## API Client Libraries Dyspatch provides API Clients for popular languages and web frameworks.  - [Java](https://github.com/getdyspatch/dyspatch-java) - [Javascript](https://github.com/getdyspatch/dyspatch-javascript) - [Python](https://github.com/getdyspatch/dyspatch-python) - [C#](https://github.com/getdyspatch/dyspatch-dotnet) - [Go](https://github.com/getdyspatch/dyspatch-golang) - [Ruby](https://github.com/getdyspatch/dyspatch-ruby)  
 *
 * The version of the OpenAPI document: 2019.10
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
    /// list of template metadata
    /// </summary>
    [DataContract]
    public partial class TemplatesRead :  IEquatable<TemplatesRead>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplatesRead" /> class.
        /// </summary>
        /// <param name="cursor">cursor.</param>
        /// <param name="data">A list of template metadata objects.</param>
        public TemplatesRead(Cursor cursor = default(Cursor), List<TemplateMetaRead> data = default(List<TemplateMetaRead>))
        {
            this.Cursor = cursor;
            this.Data = data;
        }
        
        /// <summary>
        /// Gets or Sets Cursor
        /// </summary>
        [DataMember(Name="cursor", EmitDefaultValue=false)]
        public Cursor Cursor { get; set; }

        /// <summary>
        /// A list of template metadata objects
        /// </summary>
        /// <value>A list of template metadata objects</value>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<TemplateMetaRead> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TemplatesRead {\n");
            sb.Append("  Cursor: ").Append(Cursor).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as TemplatesRead);
        }

        /// <summary>
        /// Returns true if TemplatesRead instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplatesRead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplatesRead input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Cursor == input.Cursor ||
                    (this.Cursor != null &&
                    this.Cursor.Equals(input.Cursor))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    input.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.Cursor != null)
                    hashCode = hashCode * 59 + this.Cursor.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                return hashCode;
            }
        }
    }

}
