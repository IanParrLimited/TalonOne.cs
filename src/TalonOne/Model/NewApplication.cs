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
    /// NewApplication
    /// </summary>
    [DataContract]
    public partial class NewApplication :  IEquatable<NewApplication>, IValidatableObject
    {
        /// <summary>
        /// A string indicating how should campaigns in this application deal with case sensitivity on coupon codes.
        /// </summary>
        /// <value>A string indicating how should campaigns in this application deal with case sensitivity on coupon codes.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CaseSensitivityEnum
        {
            /// <summary>
            /// Enum Sensitive for value: sensitive
            /// </summary>
            [EnumMember(Value = "sensitive")]
            Sensitive = 1,

            /// <summary>
            /// Enum InsensitiveUppercase for value: insensitive-uppercase
            /// </summary>
            [EnumMember(Value = "insensitive-uppercase")]
            InsensitiveUppercase = 2,

            /// <summary>
            /// Enum InsensitiveLowercase for value: insensitive-lowercase
            /// </summary>
            [EnumMember(Value = "insensitive-lowercase")]
            InsensitiveLowercase = 3

        }

        /// <summary>
        /// A string indicating how should campaigns in this application deal with case sensitivity on coupon codes.
        /// </summary>
        /// <value>A string indicating how should campaigns in this application deal with case sensitivity on coupon codes.</value>
        [DataMember(Name="caseSensitivity", EmitDefaultValue=false)]
        public CaseSensitivityEnum? CaseSensitivity { get; set; }
        /// <summary>
        /// Default priority for campaigns created in this application, can be one of (universal, stackable, exclusive). If no value is provided, this is set to \&quot;universal\&quot;
        /// </summary>
        /// <value>Default priority for campaigns created in this application, can be one of (universal, stackable, exclusive). If no value is provided, this is set to \&quot;universal\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CampaignPriorityEnum
        {
            /// <summary>
            /// Enum Universal for value: universal
            /// </summary>
            [EnumMember(Value = "universal")]
            Universal = 1,

            /// <summary>
            /// Enum Stackable for value: stackable
            /// </summary>
            [EnumMember(Value = "stackable")]
            Stackable = 2,

            /// <summary>
            /// Enum Exclusive for value: exclusive
            /// </summary>
            [EnumMember(Value = "exclusive")]
            Exclusive = 3

        }

        /// <summary>
        /// Default priority for campaigns created in this application, can be one of (universal, stackable, exclusive). If no value is provided, this is set to \&quot;universal\&quot;
        /// </summary>
        /// <value>Default priority for campaigns created in this application, can be one of (universal, stackable, exclusive). If no value is provided, this is set to \&quot;universal\&quot;</value>
        [DataMember(Name="campaignPriority", EmitDefaultValue=false)]
        public CampaignPriorityEnum? CampaignPriority { get; set; }
        /// <summary>
        /// The strategy used when choosing exclusive campaigns for evaluation, can be one of (listOrder, lowestDiscount, highestDiscount). If no value is provided, this is set to \&quot;listOrder\&quot;
        /// </summary>
        /// <value>The strategy used when choosing exclusive campaigns for evaluation, can be one of (listOrder, lowestDiscount, highestDiscount). If no value is provided, this is set to \&quot;listOrder\&quot;</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ExclusiveCampaignsStrategyEnum
        {
            /// <summary>
            /// Enum ListOrder for value: listOrder
            /// </summary>
            [EnumMember(Value = "listOrder")]
            ListOrder = 1,

            /// <summary>
            /// Enum LowestDiscount for value: lowestDiscount
            /// </summary>
            [EnumMember(Value = "lowestDiscount")]
            LowestDiscount = 2,

            /// <summary>
            /// Enum HighestDiscount for value: highestDiscount
            /// </summary>
            [EnumMember(Value = "highestDiscount")]
            HighestDiscount = 3

        }

        /// <summary>
        /// The strategy used when choosing exclusive campaigns for evaluation, can be one of (listOrder, lowestDiscount, highestDiscount). If no value is provided, this is set to \&quot;listOrder\&quot;
        /// </summary>
        /// <value>The strategy used when choosing exclusive campaigns for evaluation, can be one of (listOrder, lowestDiscount, highestDiscount). If no value is provided, this is set to \&quot;listOrder\&quot;</value>
        [DataMember(Name="exclusiveCampaignsStrategy", EmitDefaultValue=false)]
        public ExclusiveCampaignsStrategyEnum? ExclusiveCampaignsStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplication" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected NewApplication() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="NewApplication" /> class.
        /// </summary>
        /// <param name="name">The name of this application. (required).</param>
        /// <param name="description">A longer description of the application..</param>
        /// <param name="timezone">A string containing an IANA timezone descriptor. (required).</param>
        /// <param name="currency">A string describing a default currency for new customer sessions. (required).</param>
        /// <param name="caseSensitivity">A string indicating how should campaigns in this application deal with case sensitivity on coupon codes..</param>
        /// <param name="attributes">Arbitrary properties associated with this campaign.</param>
        /// <param name="limits">Default limits for campaigns created in this application.</param>
        /// <param name="campaignPriority">Default priority for campaigns created in this application, can be one of (universal, stackable, exclusive). If no value is provided, this is set to \&quot;universal\&quot;.</param>
        /// <param name="exclusiveCampaignsStrategy">The strategy used when choosing exclusive campaigns for evaluation, can be one of (listOrder, lowestDiscount, highestDiscount). If no value is provided, this is set to \&quot;listOrder\&quot;.</param>
        /// <param name="enableCascadingDiscounts">Flag indicating if discounts should cascade for this application.</param>
        /// <param name="enableFlattenedCartItems">Flag indicating if cart items of quantity larger than one should be separated into different items of quantity one.</param>
        /// <param name="attributesSettings">attributesSettings.</param>
        /// <param name="sandbox">Flag indicating if this is a live or sandbox application.</param>
        /// <param name="key">Hex key for HMAC-signing API calls as coming from this application (16 hex digits).</param>
        public NewApplication(string name = default(string), string description = default(string), string timezone = default(string), string currency = default(string), CaseSensitivityEnum? caseSensitivity = default(CaseSensitivityEnum?), Object attributes = default(Object), List<LimitConfig> limits = default(List<LimitConfig>), CampaignPriorityEnum? campaignPriority = default(CampaignPriorityEnum?), ExclusiveCampaignsStrategyEnum? exclusiveCampaignsStrategy = default(ExclusiveCampaignsStrategyEnum?), bool enableCascadingDiscounts = default(bool), bool enableFlattenedCartItems = default(bool), AttributesSettings attributesSettings = default(AttributesSettings), bool sandbox = default(bool), string key = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new InvalidDataException("name is a required property for NewApplication and cannot be null");
            }
            else
            {
                this.Name = name;
            }
            
            // to ensure "timezone" is required (not null)
            if (timezone == null)
            {
                throw new InvalidDataException("timezone is a required property for NewApplication and cannot be null");
            }
            else
            {
                this.Timezone = timezone;
            }
            
            // to ensure "currency" is required (not null)
            if (currency == null)
            {
                throw new InvalidDataException("currency is a required property for NewApplication and cannot be null");
            }
            else
            {
                this.Currency = currency;
            }
            
            this.Description = description;
            this.CaseSensitivity = caseSensitivity;
            this.Attributes = attributes;
            this.Limits = limits;
            this.CampaignPriority = campaignPriority;
            this.ExclusiveCampaignsStrategy = exclusiveCampaignsStrategy;
            this.EnableCascadingDiscounts = enableCascadingDiscounts;
            this.EnableFlattenedCartItems = enableFlattenedCartItems;
            this.AttributesSettings = attributesSettings;
            this.Sandbox = sandbox;
            this.Key = key;
        }
        
        /// <summary>
        /// The name of this application.
        /// </summary>
        /// <value>The name of this application.</value>
        [DataMember(Name="name", EmitDefaultValue=true)]
        public string Name { get; set; }

        /// <summary>
        /// A longer description of the application.
        /// </summary>
        /// <value>A longer description of the application.</value>
        [DataMember(Name="description", EmitDefaultValue=false)]
        public string Description { get; set; }

        /// <summary>
        /// A string containing an IANA timezone descriptor.
        /// </summary>
        /// <value>A string containing an IANA timezone descriptor.</value>
        [DataMember(Name="timezone", EmitDefaultValue=true)]
        public string Timezone { get; set; }

        /// <summary>
        /// A string describing a default currency for new customer sessions.
        /// </summary>
        /// <value>A string describing a default currency for new customer sessions.</value>
        [DataMember(Name="currency", EmitDefaultValue=true)]
        public string Currency { get; set; }


        /// <summary>
        /// Arbitrary properties associated with this campaign
        /// </summary>
        /// <value>Arbitrary properties associated with this campaign</value>
        [DataMember(Name="attributes", EmitDefaultValue=false)]
        public Object Attributes { get; set; }

        /// <summary>
        /// Default limits for campaigns created in this application
        /// </summary>
        /// <value>Default limits for campaigns created in this application</value>
        [DataMember(Name="limits", EmitDefaultValue=false)]
        public List<LimitConfig> Limits { get; set; }



        /// <summary>
        /// Flag indicating if discounts should cascade for this application
        /// </summary>
        /// <value>Flag indicating if discounts should cascade for this application</value>
        [DataMember(Name="enableCascadingDiscounts", EmitDefaultValue=false)]
        public bool EnableCascadingDiscounts { get; set; }

        /// <summary>
        /// Flag indicating if cart items of quantity larger than one should be separated into different items of quantity one
        /// </summary>
        /// <value>Flag indicating if cart items of quantity larger than one should be separated into different items of quantity one</value>
        [DataMember(Name="enableFlattenedCartItems", EmitDefaultValue=false)]
        public bool EnableFlattenedCartItems { get; set; }

        /// <summary>
        /// Gets or Sets AttributesSettings
        /// </summary>
        [DataMember(Name="attributesSettings", EmitDefaultValue=false)]
        public AttributesSettings AttributesSettings { get; set; }

        /// <summary>
        /// Flag indicating if this is a live or sandbox application
        /// </summary>
        /// <value>Flag indicating if this is a live or sandbox application</value>
        [DataMember(Name="sandbox", EmitDefaultValue=false)]
        public bool Sandbox { get; set; }

        /// <summary>
        /// Hex key for HMAC-signing API calls as coming from this application (16 hex digits)
        /// </summary>
        /// <value>Hex key for HMAC-signing API calls as coming from this application (16 hex digits)</value>
        [DataMember(Name="key", EmitDefaultValue=false)]
        public string Key { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class NewApplication {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Timezone: ").Append(Timezone).Append("\n");
            sb.Append("  Currency: ").Append(Currency).Append("\n");
            sb.Append("  CaseSensitivity: ").Append(CaseSensitivity).Append("\n");
            sb.Append("  Attributes: ").Append(Attributes).Append("\n");
            sb.Append("  Limits: ").Append(Limits).Append("\n");
            sb.Append("  CampaignPriority: ").Append(CampaignPriority).Append("\n");
            sb.Append("  ExclusiveCampaignsStrategy: ").Append(ExclusiveCampaignsStrategy).Append("\n");
            sb.Append("  EnableCascadingDiscounts: ").Append(EnableCascadingDiscounts).Append("\n");
            sb.Append("  EnableFlattenedCartItems: ").Append(EnableFlattenedCartItems).Append("\n");
            sb.Append("  AttributesSettings: ").Append(AttributesSettings).Append("\n");
            sb.Append("  Sandbox: ").Append(Sandbox).Append("\n");
            sb.Append("  Key: ").Append(Key).Append("\n");
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
            return this.Equals(input as NewApplication);
        }

        /// <summary>
        /// Returns true if NewApplication instances are equal
        /// </summary>
        /// <param name="input">Instance of NewApplication to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(NewApplication input)
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
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Timezone == input.Timezone ||
                    (this.Timezone != null &&
                    this.Timezone.Equals(input.Timezone))
                ) && 
                (
                    this.Currency == input.Currency ||
                    (this.Currency != null &&
                    this.Currency.Equals(input.Currency))
                ) && 
                (
                    this.CaseSensitivity == input.CaseSensitivity ||
                    (this.CaseSensitivity != null &&
                    this.CaseSensitivity.Equals(input.CaseSensitivity))
                ) && 
                (
                    this.Attributes == input.Attributes ||
                    (this.Attributes != null &&
                    this.Attributes.Equals(input.Attributes))
                ) && 
                (
                    this.Limits == input.Limits ||
                    this.Limits != null &&
                    input.Limits != null &&
                    this.Limits.SequenceEqual(input.Limits)
                ) && 
                (
                    this.CampaignPriority == input.CampaignPriority ||
                    (this.CampaignPriority != null &&
                    this.CampaignPriority.Equals(input.CampaignPriority))
                ) && 
                (
                    this.ExclusiveCampaignsStrategy == input.ExclusiveCampaignsStrategy ||
                    (this.ExclusiveCampaignsStrategy != null &&
                    this.ExclusiveCampaignsStrategy.Equals(input.ExclusiveCampaignsStrategy))
                ) && 
                (
                    this.EnableCascadingDiscounts == input.EnableCascadingDiscounts ||
                    (this.EnableCascadingDiscounts != null &&
                    this.EnableCascadingDiscounts.Equals(input.EnableCascadingDiscounts))
                ) && 
                (
                    this.EnableFlattenedCartItems == input.EnableFlattenedCartItems ||
                    (this.EnableFlattenedCartItems != null &&
                    this.EnableFlattenedCartItems.Equals(input.EnableFlattenedCartItems))
                ) && 
                (
                    this.AttributesSettings == input.AttributesSettings ||
                    (this.AttributesSettings != null &&
                    this.AttributesSettings.Equals(input.AttributesSettings))
                ) && 
                (
                    this.Sandbox == input.Sandbox ||
                    (this.Sandbox != null &&
                    this.Sandbox.Equals(input.Sandbox))
                ) && 
                (
                    this.Key == input.Key ||
                    (this.Key != null &&
                    this.Key.Equals(input.Key))
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
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Timezone != null)
                    hashCode = hashCode * 59 + this.Timezone.GetHashCode();
                if (this.Currency != null)
                    hashCode = hashCode * 59 + this.Currency.GetHashCode();
                if (this.CaseSensitivity != null)
                    hashCode = hashCode * 59 + this.CaseSensitivity.GetHashCode();
                if (this.Attributes != null)
                    hashCode = hashCode * 59 + this.Attributes.GetHashCode();
                if (this.Limits != null)
                    hashCode = hashCode * 59 + this.Limits.GetHashCode();
                if (this.CampaignPriority != null)
                    hashCode = hashCode * 59 + this.CampaignPriority.GetHashCode();
                if (this.ExclusiveCampaignsStrategy != null)
                    hashCode = hashCode * 59 + this.ExclusiveCampaignsStrategy.GetHashCode();
                if (this.EnableCascadingDiscounts != null)
                    hashCode = hashCode * 59 + this.EnableCascadingDiscounts.GetHashCode();
                if (this.EnableFlattenedCartItems != null)
                    hashCode = hashCode * 59 + this.EnableFlattenedCartItems.GetHashCode();
                if (this.AttributesSettings != null)
                    hashCode = hashCode * 59 + this.AttributesSettings.GetHashCode();
                if (this.Sandbox != null)
                    hashCode = hashCode * 59 + this.Sandbox.GetHashCode();
                if (this.Key != null)
                    hashCode = hashCode * 59 + this.Key.GetHashCode();
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

            // Name (string) minLength
            if(this.Name != null && this.Name.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Name, length must be greater than 1.", new [] { "Name" });
            }
            

            // Timezone (string) minLength
            if(this.Timezone != null && this.Timezone.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Timezone, length must be greater than 1.", new [] { "Timezone" });
            }
            

            // Currency (string) minLength
            if(this.Currency != null && this.Currency.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Currency, length must be greater than 1.", new [] { "Currency" });
            }
            

            
            // Key (string) pattern
            Regex regexKey = new Regex(@"^[a-fA-F0-9]{16}$", RegexOptions.CultureInvariant);
            if (false == regexKey.Match(this.Key).Success)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Key, must match a pattern of " + regexKey, new [] { "Key" });
            }

            yield break;
        }
    }

}
