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
    /// MultiApplicationEntity
    /// </summary>
    [DataContract]
    public partial class MultiApplicationEntity :  IEquatable<MultiApplicationEntity>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiApplicationEntity" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected MultiApplicationEntity() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="MultiApplicationEntity" /> class.
        /// </summary>
        /// <param name="applicationIds">The IDs of the applications that are related to this entity. (required).</param>
        public MultiApplicationEntity(List<int> applicationIds = default(List<int>))
        {
            // to ensure "applicationIds" is required (not null)
            if (applicationIds == null)
            {
                throw new InvalidDataException("applicationIds is a required property for MultiApplicationEntity and cannot be null");
            }
            else
            {
                this.ApplicationIds = applicationIds;
            }
            
        }
        
        /// <summary>
        /// The IDs of the applications that are related to this entity.
        /// </summary>
        /// <value>The IDs of the applications that are related to this entity.</value>
        [DataMember(Name="applicationIds", EmitDefaultValue=true)]
        public List<int> ApplicationIds { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class MultiApplicationEntity {\n");
            sb.Append("  ApplicationIds: ").Append(ApplicationIds).Append("\n");
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
            return this.Equals(input as MultiApplicationEntity);
        }

        /// <summary>
        /// Returns true if MultiApplicationEntity instances are equal
        /// </summary>
        /// <param name="input">Instance of MultiApplicationEntity to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(MultiApplicationEntity input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.ApplicationIds == input.ApplicationIds ||
                    this.ApplicationIds != null &&
                    input.ApplicationIds != null &&
                    this.ApplicationIds.SequenceEqual(input.ApplicationIds)
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
                if (this.ApplicationIds != null)
                    hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
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
