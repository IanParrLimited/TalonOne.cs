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
    /// CampaignSetLeafNode
    /// </summary>
    [DataContract]
    public partial class CampaignSetLeafNode :  IEquatable<CampaignSetLeafNode>, IValidatableObject
    {
        /// <summary>
        /// Indicates the node type
        /// </summary>
        /// <value>Indicates the node type</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum TypeEnum
        {
            /// <summary>
            /// Enum CAMPAIGN for value: CAMPAIGN
            /// </summary>
            [EnumMember(Value = "CAMPAIGN")]
            CAMPAIGN = 1

        }

        /// <summary>
        /// Indicates the node type
        /// </summary>
        /// <value>Indicates the node type</value>
        [DataMember(Name="type", EmitDefaultValue=true)]
        public TypeEnum Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSetLeafNode" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignSetLeafNode() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignSetLeafNode" /> class.
        /// </summary>
        /// <param name="type">Indicates the node type (required).</param>
        /// <param name="campaignId">ID of the campaign (required).</param>
        public CampaignSetLeafNode(TypeEnum type = default(TypeEnum), int campaignId = default(int))
        {
            // to ensure "type" is required (not null)
            if (type == null)
            {
                throw new InvalidDataException("type is a required property for CampaignSetLeafNode and cannot be null");
            }
            else
            {
                this.Type = type;
            }
            
            // to ensure "campaignId" is required (not null)
            if (campaignId == null)
            {
                throw new InvalidDataException("campaignId is a required property for CampaignSetLeafNode and cannot be null");
            }
            else
            {
                this.CampaignId = campaignId;
            }
            
        }
        

        /// <summary>
        /// ID of the campaign
        /// </summary>
        /// <value>ID of the campaign</value>
        [DataMember(Name="campaignId", EmitDefaultValue=true)]
        public int CampaignId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignSetLeafNode {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
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
            return this.Equals(input as CampaignSetLeafNode);
        }

        /// <summary>
        /// Returns true if CampaignSetLeafNode instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignSetLeafNode to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignSetLeafNode input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Type == input.Type ||
                    (this.Type != null &&
                    this.Type.Equals(input.Type))
                ) && 
                (
                    this.CampaignId == input.CampaignId ||
                    (this.CampaignId != null &&
                    this.CampaignId.Equals(input.CampaignId))
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
                if (this.Type != null)
                    hashCode = hashCode * 59 + this.Type.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
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
