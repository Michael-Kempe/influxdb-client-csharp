/* 
 * Influx API Service
 *
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * OpenAPI spec version: 0.1.0
 * 
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
using OpenAPIDateConverter = InfluxDB.Client.Api.Client.OpenAPIDateConverter;

namespace InfluxDB.Client.Api.Domain
{
    /// <summary>
    /// Error
    /// </summary>
    [DataContract]
    public partial class Error :  IEquatable<Error>
    {
        /// <summary>
        /// Code is the machine-readable error code.
        /// </summary>
        /// <value>Code is the machine-readable error code.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CodeEnum
        {
            /// <summary>
            /// Enum Internalerror for value: internal error
            /// </summary>
            [EnumMember(Value = "internal error")]
            Internalerror = 1,

            /// <summary>
            /// Enum Notfound for value: not found
            /// </summary>
            [EnumMember(Value = "not found")]
            Notfound = 2,

            /// <summary>
            /// Enum Conflict for value: conflict
            /// </summary>
            [EnumMember(Value = "conflict")]
            Conflict = 3,

            /// <summary>
            /// Enum Invalid for value: invalid
            /// </summary>
            [EnumMember(Value = "invalid")]
            Invalid = 4,

            /// <summary>
            /// Enum Unprocessableentity for value: unprocessable entity
            /// </summary>
            [EnumMember(Value = "unprocessable entity")]
            Unprocessableentity = 5,

            /// <summary>
            /// Enum Emptyvalue for value: empty value
            /// </summary>
            [EnumMember(Value = "empty value")]
            Emptyvalue = 6,

            /// <summary>
            /// Enum Unavailable for value: unavailable
            /// </summary>
            [EnumMember(Value = "unavailable")]
            Unavailable = 7,

            /// <summary>
            /// Enum Forbidden for value: forbidden
            /// </summary>
            [EnumMember(Value = "forbidden")]
            Forbidden = 8,

            /// <summary>
            /// Enum Toomanyrequests for value: too many requests
            /// </summary>
            [EnumMember(Value = "too many requests")]
            Toomanyrequests = 9,

            /// <summary>
            /// Enum Unauthorized for value: unauthorized
            /// </summary>
            [EnumMember(Value = "unauthorized")]
            Unauthorized = 10,

            /// <summary>
            /// Enum Methodnotallowed for value: method not allowed
            /// </summary>
            [EnumMember(Value = "method not allowed")]
            Methodnotallowed = 11

        }

        /// <summary>
        /// Code is the machine-readable error code.
        /// </summary>
        /// <value>Code is the machine-readable error code.</value>
        [DataMember(Name="code", EmitDefaultValue=false)]
        public CodeEnum Code { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Error" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        public Error()
        {
        }


        /// <summary>
        /// Message is a human-readable message.
        /// </summary>
        /// <value>Message is a human-readable message.</value>
        [DataMember(Name="message", EmitDefaultValue=false)]
        public string Message { get; private set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Error {\n");
            sb.Append("  Code: ").Append(Code).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as Error);
        }

        /// <summary>
        /// Returns true if Error instances are equal
        /// </summary>
        /// <param name="input">Instance of Error to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Error input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Code == input.Code ||
                    (this.Code.Equals(input.Code))
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                return hashCode;
            }
        }

    }

}
