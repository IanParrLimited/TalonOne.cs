/* 
 * Talon.One API
 *
 * The Talon.One API is used to manage applications and campaigns, as well as to integrate with your application. The operations in the _Integration API_ section are used to integrate with our platform, while the other operations are used to manage applications and campaigns.  ### Where is the API?  The API is available at the same hostname as these docs. For example, if you are reading this page at `https://mycompany.talon.one/docs/api/`, the URL for the [updateCustomerProfile][] operation is `https://mycompany.talon.one/v1/customer_profiles/id`  [updateCustomerProfile]: #operation- -v1-customer_profiles- -integrationId- -put 
 *
 * OpenAPI spec version: 1.0.0
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
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
using SwaggerDateConverter = TalonOne.Client.SwaggerDateConverter;

namespace TalonOne.Model
{
    /// <summary>
    /// CampaignCopy
    /// </summary>
    [DataContract]
    public partial class CampaignCopy :  IEquatable<CampaignCopy>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignCopy" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CampaignCopy() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CampaignCopy" /> class.
        /// </summary>
        /// <param name="name">Name of the copied campaign (Defaults to \&quot;Copy of original campaign name\&quot;).</param>
        /// <param name="applicationIds">Application IDs of the applications to which a campaign should be copied to (required).</param>
        /// <param name="description">A detailed description of the campaign..</param>
        /// <param name="startTime">Datetime when the campaign will become active..</param>
        /// <param name="endTime">Datetime when the campaign will become in-active..</param>
        /// <param name="tags">A list of tags for the campaign..</param>
        public CampaignCopy(string name = default(string), List<string> applicationIds = default(List<string>), string description = default(string), DateTime? startTime = default(DateTime?), DateTime? endTime = default(DateTime?), List<string> tags = default(List<string>))
        {
            // to ensure "applicationIds" is required (not null)
            if (applicationIds == null)
            {
                throw new InvalidDataException("applicationIds is a required property for CampaignCopy and cannot be null");
            }
            else
            {
                this.ApplicationIds = applicationIds;
            }
            this.Name = name;
            this.Description = description;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.Tags = tags;
        }
        
        /// <summary>
        /// Name of the copied campaign (Defaults to \&quot;Copy of original campaign name\&quot;)
        /// </summary>
        /// <value>Name of the copied campaign (Defaults to \&quot;Copy of original campaign name\&quot;)</value>
        [DataMember(Name="name", EmitDefaultValue=false)]
        public string Name { get; set; }

        /// <summary>
        /// Application IDs of the applications to which a campaign should be copied to
        /// </summary>
        /// <value>Application IDs of the applications to which a campaign should be copied to</value>
        [DataMember(Name="applicationIds", EmitDefaultValue=false)]
        public List<string> ApplicationIds { get; set; }

        /// <summary>
        /// A detailed description of the campaign.
        /// </summary>
        /// <value>A detailed description of the campaign.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// Datetime when the campaign will become active.
        /// </summary>
        /// <value>Datetime when the campaign will become active.</value>
        [DataMember(Name="startTime", EmitDefaultValue=false)]
        public DateTime? StartTime { get; set; }

        /// <summary>
        /// Datetime when the campaign will become in-active.
        /// </summary>
        /// <value>Datetime when the campaign will become in-active.</value>
        [DataMember(Name="endTime", EmitDefaultValue=false)]
        public DateTime? EndTime { get; set; }

        /// <summary>
        /// A list of tags for the campaign.
        /// </summary>
        /// <value>A list of tags for the campaign.</value>
        [DataMember(Name="tags", EmitDefaultValue=false)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CampaignCopy {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ApplicationIds: ").Append(ApplicationIds).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  StartTime: ").Append(StartTime).Append("\n");
            sb.Append("  EndTime: ").Append(EndTime).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
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
            return this.Equals(input as CampaignCopy);
        }

        /// <summary>
        /// Returns true if CampaignCopy instances are equal
        /// </summary>
        /// <param name="input">Instance of CampaignCopy to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CampaignCopy input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ApplicationIds == input.ApplicationIds ||
                    this.ApplicationIds != null &&
                    this.ApplicationIds.SequenceEqual(input.ApplicationIds)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.StartTime == input.StartTime ||
                    (this.StartTime != null &&
                    this.StartTime.Equals(input.StartTime))
                ) && 
                (
                    this.EndTime == input.EndTime ||
                    (this.EndTime != null &&
                    this.EndTime.Equals(input.EndTime))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ApplicationIds != null)
                    hashCode = hashCode * 59 + this.ApplicationIds.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.StartTime != null)
                    hashCode = hashCode * 59 + this.StartTime.GetHashCode();
                if (this.EndTime != null)
                    hashCode = hashCode * 59 + this.EndTime.GetHashCode();
                if (this.Tags != null)
                    hashCode = hashCode * 59 + this.Tags.GetHashCode();
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
