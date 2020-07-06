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
    /// possible errors from the api
    /// </summary>
    [DataContract]
    public partial class APIError :  IEquatable<APIError>, IValidatableObject
    {
        /// <summary>
        /// Error code:   * server_error - Internal server error.   * invalid_parameter - Validation error, parameter will contain invalid field and message will contain the reason.   * invalid_body - Body could not be parsed, message will contain the reason.   * invalid_request - Validation error, the protocol used to make the request was not https.   * unauthorized - Credentials were found but permissions were not sufficient.   * unauthenticated - Credentials were not found or were not valid.   * not_found - The requested resource was not found.   * rate_limited - The request was refused because a rate limit was exceeded. There is an account wide rate limit of 3600 requests per-minute, although that is subject to change. The current remaining rate limit can be viewed by checking the X-Ratelimit-Remaining header.   * prohibited_action - The request was refused because an action was not valid for the requested resource. Typically this will happen if you try to make changes to a locked resource. 
        /// </summary>
        /// <value>Error code:   * server_error - Internal server error.   * invalid_parameter - Validation error, parameter will contain invalid field and message will contain the reason.   * invalid_body - Body could not be parsed, message will contain the reason.   * invalid_request - Validation error, the protocol used to make the request was not https.   * unauthorized - Credentials were found but permissions were not sufficient.   * unauthenticated - Credentials were not found or were not valid.   * not_found - The requested resource was not found.   * rate_limited - The request was refused because a rate limit was exceeded. There is an account wide rate limit of 3600 requests per-minute, although that is subject to change. The current remaining rate limit can be viewed by checking the X-Ratelimit-Remaining header.   * prohibited_action - The request was refused because an action was not valid for the requested resource. Typically this will happen if you try to make changes to a locked resource. </value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum Servererror for value: server_error
            /// </summary>
            [EnumMember(Value = "server_error")]
            Servererror = 1,

            /// <summary>
            /// Enum Invalidparameter for value: invalid_parameter
            /// </summary>
            [EnumMember(Value = "invalid_parameter")]
            Invalidparameter = 2,

            /// <summary>
            /// Enum Invalidbody for value: invalid_body
            /// </summary>
            [EnumMember(Value = "invalid_body")]
            Invalidbody = 3,

            /// <summary>
            /// Enum Invalidrequest for value: invalid_request
            /// </summary>
            [EnumMember(Value = "invalid_request")]
            Invalidrequest = 4,

            /// <summary>
            /// Enum Unauthorized for value: unauthorized
            /// </summary>
            [EnumMember(Value = "unauthorized")]
            Unauthorized = 5,

            /// <summary>
            /// Enum Unauthenticated for value: unauthenticated
            /// </summary>
            [EnumMember(Value = "unauthenticated")]
            Unauthenticated = 6,

            /// <summary>
            /// Enum Notfound for value: not_found
            /// </summary>
            [EnumMember(Value = "not_found")]
            Notfound = 7,

            /// <summary>
            /// Enum Ratelimited for value: rate_limited
            /// </summary>
            [EnumMember(Value = "rate_limited")]
            Ratelimited = 8,

            /// <summary>
            /// Enum Prohibitedaction for value: prohibited_action
            /// </summary>
            [EnumMember(Value = "prohibited_action")]
            Prohibitedaction = 9

        }

        /// <summary>
        /// Error code:   * server_error - Internal server error.   * invalid_parameter - Validation error, parameter will contain invalid field and message will contain the reason.   * invalid_body - Body could not be parsed, message will contain the reason.   * invalid_request - Validation error, the protocol used to make the request was not https.   * unauthorized - Credentials were found but permissions were not sufficient.   * unauthenticated - Credentials were not found or were not valid.   * not_found - The requested resource was not found.   * rate_limited - The request was refused because a rate limit was exceeded. There is an account wide rate limit of 3600 requests per-minute, although that is subject to change. The current remaining rate limit can be viewed by checking the X-Ratelimit-Remaining header.   * prohibited_action - The request was refused because an action was not valid for the requested resource. Typically this will happen if you try to make changes to a locked resource. 
        /// </summary>
        /// <value>Error code:   * server_error - Internal server error.   * invalid_parameter - Validation error, parameter will contain invalid field and message will contain the reason.   * invalid_body - Body could not be parsed, message will contain the reason.   * invalid_request - Validation error, the protocol used to make the request was not https.   * unauthorized - Credentials were found but permissions were not sufficient.   * unauthenticated - Credentials were not found or were not valid.   * not_found - The requested resource was not found.   * rate_limited - The request was refused because a rate limit was exceeded. There is an account wide rate limit of 3600 requests per-minute, although that is subject to change. The current remaining rate limit can be viewed by checking the X-Ratelimit-Remaining header.   * prohibited_action - The request was refused because an action was not valid for the requested resource. Typically this will happen if you try to make changes to a locked resource. </value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum? Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="APIError" /> class.
        /// </summary>
        /// <param name="code">Error code:   * server_error - Internal server error.   * invalid_parameter - Validation error, parameter will contain invalid field and message will contain the reason.   * invalid_body - Body could not be parsed, message will contain the reason.   * invalid_request - Validation error, the protocol used to make the request was not https.   * unauthorized - Credentials were found but permissions were not sufficient.   * unauthenticated - Credentials were not found or were not valid.   * not_found - The requested resource was not found.   * rate_limited - The request was refused because a rate limit was exceeded. There is an account wide rate limit of 3600 requests per-minute, although that is subject to change. The current remaining rate limit can be viewed by checking the X-Ratelimit-Remaining header.   * prohibited_action - The request was refused because an action was not valid for the requested resource. Typically this will happen if you try to make changes to a locked resource. .</param>
        /// <param name="message">Human readable error message.</param>
        /// <param name="_parameter">The invalid parameter, if &#39;code&#39; is invalid_parameter.</param>
        public APIError(CodeEnum? code = default(CodeEnum?), string message = default(string), string _parameter = default(string))
        {
            this.Code = code;
            this.Message = message;
            this.Parameter = _parameter;
        }
        
        /// <summary>
        /// Human readable error message
        /// </summary>
        /// <value>Human readable error message</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; set; }

        /// <summary>
        /// The invalid parameter, if &#39;code&#39; is invalid_parameter
        /// </summary>
        /// <value>The invalid parameter, if &#39;code&#39; is invalid_parameter</value>
        [DataMember(Name="parameter", EmitDefaultValue=false)]
        public string Parameter { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class APIError {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
            sb.Append("  Parameter: ").Append(Parameter).Append("\n");
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
            return this.Equals(input as APIError);
        }

        /// <summary>
        /// Returns true if APIError instances are equal
        /// </summary>
        /// <param name="input">Instance of APIError to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(APIError input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    this.Code.Equals(input.Code)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
                ) && 
                (
                    this.Parameter == input.Parameter ||
                    (this.Parameter != null &&
                    this.Parameter.Equals(input.Parameter))
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
                hashCode = hashCode * 59 + this.Code.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
                if (this.Parameter != null)
                    hashCode = hashCode * 59 + this.Parameter.GetHashCode();
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
