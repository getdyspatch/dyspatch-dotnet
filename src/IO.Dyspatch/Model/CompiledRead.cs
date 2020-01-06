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
    /// revision data
    /// </summary>
    [DataContract]
    public partial class CompiledRead :  IEquatable<CompiledRead>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CompiledRead" /> class.
        /// </summary>
        /// <param name="sender">Sender address.</param>
        /// <param name="replyTo">Reply-To address.</param>
        /// <param name="subject">Base64 encoded template subject line.</param>
        /// <param name="html">Base64 encoded template HTML body.</param>
        /// <param name="text">Base64 encoded template text body.</param>
        public CompiledRead(string sender = default(string), string replyTo = default(string), byte[] subject = default(byte[]), byte[] html = default(byte[]), byte[] text = default(byte[]))
        {
            this.Sender = sender;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.Html = html;
            this.Text = text;
        }
        
        /// <summary>
        /// Sender address
        /// </summary>
        /// <value>Sender address</value>
        [DataMember(Name="sender", EmitDefaultValue=false)]
        public string Sender { get; set; }

        /// <summary>
        /// Reply-To address
        /// </summary>
        /// <value>Reply-To address</value>
        [DataMember(Name="replyTo", EmitDefaultValue=false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Base64 encoded template subject line
        /// </summary>
        /// <value>Base64 encoded template subject line</value>
        [DataMember(Name="subject", EmitDefaultValue=false)]
        public byte[] Subject { get; set; }

        /// <summary>
        /// Base64 encoded template HTML body
        /// </summary>
        /// <value>Base64 encoded template HTML body</value>
        [DataMember(Name="html", EmitDefaultValue=false)]
        public byte[] Html { get; set; }

        /// <summary>
        /// Base64 encoded template text body
        /// </summary>
        /// <value>Base64 encoded template text body</value>
        [DataMember(Name="text", EmitDefaultValue=false)]
        public byte[] Text { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CompiledRead {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
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
            return this.Equals(input as CompiledRead);
        }

        /// <summary>
        /// Returns true if CompiledRead instances are equal
        /// </summary>
        /// <param name="input">Instance of CompiledRead to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CompiledRead input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
                ) && 
                (
                    this.Text == input.Text ||
                    (this.Text != null &&
                    this.Text.Equals(input.Text))
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
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Html != null)
                    hashCode = hashCode * 59 + this.Html.GetHashCode();
                if (this.Text != null)
                    hashCode = hashCode * 59 + this.Text.GetHashCode();
                return hashCode;
            }
        }
    }

}
