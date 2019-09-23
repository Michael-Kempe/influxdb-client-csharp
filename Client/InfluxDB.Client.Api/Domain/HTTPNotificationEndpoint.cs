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
    /// HTTPNotificationEndpoint
    /// </summary>
    [DataContract]
    public partial class HTTPNotificationEndpoint : NotificationEndpoint,  IEquatable<HTTPNotificationEndpoint>
    {
        /// <summary>
        /// Defines Method
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
        {
            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            [EnumMember(Value = "POST")]
            POST = 1,

            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")]
            GET = 2,

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            [EnumMember(Value = "PUT")]
            PUT = 3

        }

        /// <summary>
        /// Gets or Sets Method
        /// </summary>
        [DataMember(Name="method", EmitDefaultValue=false)]
        public MethodEnum Method { get; set; }
        /// <summary>
        /// Defines AuthMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AuthMethodEnum
        {
            /// <summary>
            /// Enum None for value: none
            /// </summary>
            [EnumMember(Value = "none")]
            None = 1,

            /// <summary>
            /// Enum Basic for value: basic
            /// </summary>
            [EnumMember(Value = "basic")]
            Basic = 2,

            /// <summary>
            /// Enum Bearer for value: bearer
            /// </summary>
            [EnumMember(Value = "bearer")]
            Bearer = 3

        }

        /// <summary>
        /// Gets or Sets AuthMethod
        /// </summary>
        [DataMember(Name="authMethod", EmitDefaultValue=false)]
        public AuthMethodEnum AuthMethod { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPNotificationEndpoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected HTTPNotificationEndpoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="HTTPNotificationEndpoint" /> class.
        /// </summary>
        /// <param name="url">url (required).</param>
        /// <param name="username">username.</param>
        /// <param name="password">password.</param>
        /// <param name="token">token.</param>
        /// <param name="method">method (required).</param>
        /// <param name="authMethod">authMethod (required).</param>
        /// <param name="contentTemplate">contentTemplate.</param>
        public HTTPNotificationEndpoint(string url = default(string), string username = default(string), string password = default(string), string token = default(string), MethodEnum method = default(MethodEnum), AuthMethodEnum authMethod = default(AuthMethodEnum), string contentTemplate = default(string), string id = default(string), string orgID = default(string), string userID = default(string), string description = default(string), string name = default(string), StatusEnum? status = StatusEnum.Active, List<Label> labels = default(List<Label>), NotificationEndpointType type = default(NotificationEndpointType)) : base(id, orgID, userID, description, name, status, labels, type)
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new InvalidDataException("url is a required property for HTTPNotificationEndpoint and cannot be null");
            }
            else
            {
                this.Url = url;
            }
            // to ensure "method" is required (not null)
            if (method == null)
            {
                throw new InvalidDataException("method is a required property for HTTPNotificationEndpoint and cannot be null");
            }
            else
            {
                this.Method = method;
            }
            // to ensure "authMethod" is required (not null)
            if (authMethod == null)
            {
                throw new InvalidDataException("authMethod is a required property for HTTPNotificationEndpoint and cannot be null");
            }
            else
            {
                this.AuthMethod = authMethod;
            }
            this.Username = username;
            this.Password = password;
            this.Token = token;
            this.ContentTemplate = contentTemplate;
        }

        /// <summary>
        /// Gets or Sets Url
        /// </summary>
        [DataMember(Name="url", EmitDefaultValue=false)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets Username
        /// </summary>
        [DataMember(Name="username", EmitDefaultValue=false)]
        public string Username { get; set; }

        /// <summary>
        /// Gets or Sets Password
        /// </summary>
        [DataMember(Name="password", EmitDefaultValue=false)]
        public string Password { get; set; }

        /// <summary>
        /// Gets or Sets Token
        /// </summary>
        [DataMember(Name="token", EmitDefaultValue=false)]
        public string Token { get; set; }



        /// <summary>
        /// Gets or Sets ContentTemplate
        /// </summary>
        [DataMember(Name="contentTemplate", EmitDefaultValue=false)]
        public string ContentTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class HTTPNotificationEndpoint {\n");
            sb.Append("  ").Append(base.ToString().Replace("\n", "\n  ")).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Username: ").Append(Username).Append("\n");
            sb.Append("  Password: ").Append(Password).Append("\n");
            sb.Append("  Token: ").Append(Token).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  AuthMethod: ").Append(AuthMethod).Append("\n");
            sb.Append("  ContentTemplate: ").Append(ContentTemplate).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public override string ToJson()
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
            return this.Equals(input as HTTPNotificationEndpoint);
        }

        /// <summary>
        /// Returns true if HTTPNotificationEndpoint instances are equal
        /// </summary>
        /// <param name="input">Instance of HTTPNotificationEndpoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(HTTPNotificationEndpoint input)
        {
            if (input == null)
                return false;

            return base.Equals(input) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && base.Equals(input) && 
                (
                    this.Username == input.Username ||
                    (this.Username != null &&
                    this.Username.Equals(input.Username))
                ) && base.Equals(input) && 
                (
                    this.Password == input.Password ||
                    (this.Password != null &&
                    this.Password.Equals(input.Password))
                ) && base.Equals(input) && 
                (
                    this.Token == input.Token ||
                    (this.Token != null &&
                    this.Token.Equals(input.Token))
                ) && base.Equals(input) && 
                (
                    this.Method == input.Method ||
                    (this.Method != null &&
                    this.Method.Equals(input.Method))
                ) && base.Equals(input) && 
                (
                    this.AuthMethod == input.AuthMethod ||
                    (this.AuthMethod != null &&
                    this.AuthMethod.Equals(input.AuthMethod))
                ) && base.Equals(input) && 
                (
                    this.ContentTemplate == input.ContentTemplate ||
                    (this.ContentTemplate != null &&
                    this.ContentTemplate.Equals(input.ContentTemplate))
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
                int hashCode = base.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                if (this.Username != null)
                    hashCode = hashCode * 59 + this.Username.GetHashCode();
                if (this.Password != null)
                    hashCode = hashCode * 59 + this.Password.GetHashCode();
                if (this.Token != null)
                    hashCode = hashCode * 59 + this.Token.GetHashCode();
                if (this.Method != null)
                    hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.AuthMethod != null)
                    hashCode = hashCode * 59 + this.AuthMethod.GetHashCode();
                if (this.ContentTemplate != null)
                    hashCode = hashCode * 59 + this.ContentTemplate.GetHashCode();
                return hashCode;
            }
        }

    }

}