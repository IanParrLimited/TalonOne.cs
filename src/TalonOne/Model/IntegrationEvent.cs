/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * The version of the OpenAPI document: 1.0.0
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
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = TalonOne.Client.OpenAPIDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// IntegrationEvent
    /// </summary>
    [DataContract]
    public partial class IntegrationEvent :  IEquatable<IntegrationEvent>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationEvent" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected IntegrationEvent() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="IntegrationEvent" /> class.
        /// </summary>
        /// <param name="profileId">ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID..</param>
        /// <param name="type">A string representing the event. Must not be a reserved event name. (required).</param>
        /// <param name="attributes">Arbitrary additional JSON data associated with the event. (required).</param>
        public IntegrationEvent(string profileId = default(string), string type = default(string), Object attributes = default(Object))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for IntegrationEvent and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "attributes" is required (not null)
            if (attributes == null)
            {
                throw new InvalidDataException("attributes is a required property for IntegrationEvent and cannot be null");
            }
            else
            {
                this.Attributes = attributes;
            }
            
            this.ProfileId = profileId;
        }
        
        /// <summary>
        /// ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.
        /// </summary>
        /// <value>ID of the customers profile as used within this Talon.One account. May be omitted or set to the empty string if the customer does not yet have a known profile ID.</value>
        [DataMember(Name="profileId", EmitDefaultValue=false)]
        public string ProfileId { get; set; }

        /// <summary>
        /// A string representing the event. Must not be a reserved event name.
        /// </summary>
        /// <value>A string representing the event. Must not be a reserved event name.</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public string Type { get; set; }

        /// <summary>
        /// Arbitrary additional JSON data associated with the event.
        /// </summary>
        /// <value>Arbitrary additional JSON data associated with the event.</value>
        [DataMember(Name="attributes", EmitDefaultValue=true)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class IntegrationEvent {\n");
            sb.Append("  ProfileId: ").Append(ProfileId).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
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
            return this.Equals(input as IntegrationEvent);
        }

        /// <summary>
        /// Returns true if IntegrationEvent instances are equal
        /// </summary>
        /// <param name="input">Instance of IntegrationEvent to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(IntegrationEvent input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ProfileId == input.ProfileId ||
                    (this.ProfileId != null &&
                    this.ProfileId.Equals(input.ProfileId))
                ) && 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
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
                if (this.ProfileId != null)
                    hashCode = hashCode * 59 + this.ProfileId.GetHashCode();
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
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

            // Type (string) minLength
            if(this.Type != null && this.Type.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Type, length must be greater than 1.", new [] { "Type" });
            }
            
            yield break;
        }
    }

}
