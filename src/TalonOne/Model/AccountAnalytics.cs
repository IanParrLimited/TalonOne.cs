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
    /// AccountAnalytics
    /// </summary>
    [DataContract]
    public partial class AccountAnalytics :  IEquatable<AccountAnalytics>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAnalytics" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountAnalytics() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountAnalytics" /> class.
        /// </summary>
        /// <param name="applications">Total Number of Applications inside the account (required).</param>
        /// <param name="activeCampaigns">Total Number of Active Applications inside the account (required).</param>
        /// <param name="campaigns">Total Number of campaigns inside the account (required).</param>
        /// <param name="coupons">Total Number of coupons inside the account (required).</param>
        /// <param name="activeCoupons">Total Number of active coupons inside the account (required).</param>
        /// <param name="expiredCoupons">Total Number of expired coupons inside the account (required).</param>
        /// <param name="customAttributes">Total Number of custom attributes inside the account (required).</param>
        /// <param name="referralCodes">Total Number of referral codes inside the account (required).</param>
        /// <param name="activeReferralCodes">Total Number of active referral codes inside the account (required).</param>
        /// <param name="expiredReferralCodes">Total Number of expired referral codes inside the account (required).</param>
        /// <param name="users">Total Number of users inside the account (required).</param>
        /// <param name="roles">Total Number of roles inside the account (required).</param>
        /// <param name="webhooks">Total Number of webhooks inside the account (required).</param>
        /// <param name="loyaltyPrograms">Total Number of loyalty programs inside the account (required).</param>
        public AccountAnalytics(int? applications = default(int?), int? activeCampaigns = default(int?), int? campaigns = default(int?), int? coupons = default(int?), int? activeCoupons = default(int?), int? expiredCoupons = default(int?), int? customAttributes = default(int?), int? referralCodes = default(int?), int? activeReferralCodes = default(int?), int? expiredReferralCodes = default(int?), int? users = default(int?), int? roles = default(int?), int? webhooks = default(int?), int? loyaltyPrograms = default(int?))
        {
            // to ensure "applications" is required (not null)
            if (applications == null)
            {
                throw new InvalidDataException("applications is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.Applications = applications;
            }
            // to ensure "activeCampaigns" is required (not null)
            if (activeCampaigns == null)
            {
                throw new InvalidDataException("activeCampaigns is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.ActiveCampaigns = activeCampaigns;
            }
            // to ensure "campaigns" is required (not null)
            if (campaigns == null)
            {
                throw new InvalidDataException("campaigns is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.Campaigns = campaigns;
            }
            // to ensure "coupons" is required (not null)
            if (coupons == null)
            {
                throw new InvalidDataException("coupons is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.Coupons = coupons;
            }
            // to ensure "activeCoupons" is required (not null)
            if (activeCoupons == null)
            {
                throw new InvalidDataException("activeCoupons is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.ActiveCoupons = activeCoupons;
            }
            // to ensure "expiredCoupons" is required (not null)
            if (expiredCoupons == null)
            {
                throw new InvalidDataException("expiredCoupons is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.ExpiredCoupons = expiredCoupons;
            }
            // to ensure "customAttributes" is required (not null)
            if (customAttributes == null)
            {
                throw new InvalidDataException("customAttributes is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.CustomAttributes = customAttributes;
            }
            // to ensure "referralCodes" is required (not null)
            if (referralCodes == null)
            {
                throw new InvalidDataException("referralCodes is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.ReferralCodes = referralCodes;
            }
            // to ensure "activeReferralCodes" is required (not null)
            if (activeReferralCodes == null)
            {
                throw new InvalidDataException("activeReferralCodes is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.ActiveReferralCodes = activeReferralCodes;
            }
            // to ensure "expiredReferralCodes" is required (not null)
            if (expiredReferralCodes == null)
            {
                throw new InvalidDataException("expiredReferralCodes is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.ExpiredReferralCodes = expiredReferralCodes;
            }
            // to ensure "users" is required (not null)
            if (users == null)
            {
                throw new InvalidDataException("users is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.Users = users;
            }
            // to ensure "roles" is required (not null)
            if (roles == null)
            {
                throw new InvalidDataException("roles is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.Roles = roles;
            }
            // to ensure "webhooks" is required (not null)
            if (webhooks == null)
            {
                throw new InvalidDataException("webhooks is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.Webhooks = webhooks;
            }
            // to ensure "loyaltyPrograms" is required (not null)
            if (loyaltyPrograms == null)
            {
                throw new InvalidDataException("loyaltyPrograms is a required property for AccountAnalytics and cannot be null");
            }
            else
            {
                this.LoyaltyPrograms = loyaltyPrograms;
            }
        }
        
        /// <summary>
        /// Total Number of Applications inside the account
        /// </summary>
        /// <value>Total Number of Applications inside the account</value>
        [DataMember(Name="applications", EmitDefaultValue=false)]
        public int? Applications { get; set; }

        /// <summary>
        /// Total Number of Active Applications inside the account
        /// </summary>
        /// <value>Total Number of Active Applications inside the account</value>
        [DataMember(Name="activeCampaigns", EmitDefaultValue=false)]
        public int? ActiveCampaigns { get; set; }

        /// <summary>
        /// Total Number of campaigns inside the account
        /// </summary>
        /// <value>Total Number of campaigns inside the account</value>
        [DataMember(Name="campaigns", EmitDefaultValue=false)]
        public int? Campaigns { get; set; }

        /// <summary>
        /// Total Number of coupons inside the account
        /// </summary>
        /// <value>Total Number of coupons inside the account</value>
        [DataMember(Name="coupons", EmitDefaultValue=false)]
        public int? Coupons { get; set; }

        /// <summary>
        /// Total Number of active coupons inside the account
        /// </summary>
        /// <value>Total Number of active coupons inside the account</value>
        [DataMember(Name="activeCoupons", EmitDefaultValue=false)]
        public int? ActiveCoupons { get; set; }

        /// <summary>
        /// Total Number of expired coupons inside the account
        /// </summary>
        /// <value>Total Number of expired coupons inside the account</value>
        [DataMember(Name="expiredCoupons", EmitDefaultValue=false)]
        public int? ExpiredCoupons { get; set; }

        /// <summary>
        /// Total Number of custom attributes inside the account
        /// </summary>
        /// <value>Total Number of custom attributes inside the account</value>
        [DataMember(Name="customAttributes", EmitDefaultValue=false)]
        public int? CustomAttributes { get; set; }

        /// <summary>
        /// Total Number of referral codes inside the account
        /// </summary>
        /// <value>Total Number of referral codes inside the account</value>
        [DataMember(Name="referralCodes", EmitDefaultValue=false)]
        public int? ReferralCodes { get; set; }

        /// <summary>
        /// Total Number of active referral codes inside the account
        /// </summary>
        /// <value>Total Number of active referral codes inside the account</value>
        [DataMember(Name="activeReferralCodes", EmitDefaultValue=false)]
        public int? ActiveReferralCodes { get; set; }

        /// <summary>
        /// Total Number of expired referral codes inside the account
        /// </summary>
        /// <value>Total Number of expired referral codes inside the account</value>
        [DataMember(Name="expiredReferralCodes", EmitDefaultValue=false)]
        public int? ExpiredReferralCodes { get; set; }

        /// <summary>
        /// Total Number of users inside the account
        /// </summary>
        /// <value>Total Number of users inside the account</value>
        [DataMember(Name="users", EmitDefaultValue=false)]
        public int? Users { get; set; }

        /// <summary>
        /// Total Number of roles inside the account
        /// </summary>
        /// <value>Total Number of roles inside the account</value>
        [DataMember(Name="roles", EmitDefaultValue=false)]
        public int? Roles { get; set; }

        /// <summary>
        /// Total Number of webhooks inside the account
        /// </summary>
        /// <value>Total Number of webhooks inside the account</value>
        [DataMember(Name="webhooks", EmitDefaultValue=false)]
        public int? Webhooks { get; set; }

        /// <summary>
        /// Total Number of loyalty programs inside the account
        /// </summary>
        /// <value>Total Number of loyalty programs inside the account</value>
        [DataMember(Name="loyaltyPrograms", EmitDefaultValue=false)]
        public int? LoyaltyPrograms { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AccountAnalytics {\n");
            sb.Append("  Applications: ").Append(Applications).Append("\n");
            sb.Append("  ActiveCampaigns: ").Append(ActiveCampaigns).Append("\n");
            sb.Append("  Campaigns: ").Append(Campaigns).Append("\n");
            sb.Append("  Coupons: ").Append(Coupons).Append("\n");
            sb.Append("  ActiveCoupons: ").Append(ActiveCoupons).Append("\n");
            sb.Append("  ExpiredCoupons: ").Append(ExpiredCoupons).Append("\n");
            sb.Append("  CustomAttributes: ").Append(CustomAttributes).Append("\n");
            sb.Append("  ReferralCodes: ").Append(ReferralCodes).Append("\n");
            sb.Append("  ActiveReferralCodes: ").Append(ActiveReferralCodes).Append("\n");
            sb.Append("  ExpiredReferralCodes: ").Append(ExpiredReferralCodes).Append("\n");
            sb.Append("  Users: ").Append(Users).Append("\n");
            sb.Append("  Roles: ").Append(Roles).Append("\n");
            sb.Append("  Webhooks: ").Append(Webhooks).Append("\n");
            sb.Append("  LoyaltyPrograms: ").Append(LoyaltyPrograms).Append("\n");
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
            return this.Equals(input as AccountAnalytics);
        }

        /// <summary>
        /// Returns true if AccountAnalytics instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountAnalytics to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountAnalytics input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Applications == input.Applications ||
                    (this.Applications != null &&
                    this.Applications.Equals(input.Applications))
                ) && 
                (
                    this.ActiveCampaigns == input.ActiveCampaigns ||
                    (this.ActiveCampaigns != null &&
                    this.ActiveCampaigns.Equals(input.ActiveCampaigns))
                ) && 
                (
                    this.Campaigns == input.Campaigns ||
                    (this.Campaigns != null &&
                    this.Campaigns.Equals(input.Campaigns))
                ) && 
                (
                    this.Coupons == input.Coupons ||
                    (this.Coupons != null &&
                    this.Coupons.Equals(input.Coupons))
                ) && 
                (
                    this.ActiveCoupons == input.ActiveCoupons ||
                    (this.ActiveCoupons != null &&
                    this.ActiveCoupons.Equals(input.ActiveCoupons))
                ) && 
                (
                    this.ExpiredCoupons == input.ExpiredCoupons ||
                    (this.ExpiredCoupons != null &&
                    this.ExpiredCoupons.Equals(input.ExpiredCoupons))
                ) && 
                (
                    this.CustomAttributes == input.CustomAttributes ||
                    (this.CustomAttributes != null &&
                    this.CustomAttributes.Equals(input.CustomAttributes))
                ) && 
                (
                    this.ReferralCodes == input.ReferralCodes ||
                    (this.ReferralCodes != null &&
                    this.ReferralCodes.Equals(input.ReferralCodes))
                ) && 
                (
                    this.ActiveReferralCodes == input.ActiveReferralCodes ||
                    (this.ActiveReferralCodes != null &&
                    this.ActiveReferralCodes.Equals(input.ActiveReferralCodes))
                ) && 
                (
                    this.ExpiredReferralCodes == input.ExpiredReferralCodes ||
                    (this.ExpiredReferralCodes != null &&
                    this.ExpiredReferralCodes.Equals(input.ExpiredReferralCodes))
                ) && 
                (
                    this.Users == input.Users ||
                    (this.Users != null &&
                    this.Users.Equals(input.Users))
                ) && 
                (
                    this.Roles == input.Roles ||
                    (this.Roles != null &&
                    this.Roles.Equals(input.Roles))
                ) && 
                (
                    this.Webhooks == input.Webhooks ||
                    (this.Webhooks != null &&
                    this.Webhooks.Equals(input.Webhooks))
                ) && 
                (
                    this.LoyaltyPrograms == input.LoyaltyPrograms ||
                    (this.LoyaltyPrograms != null &&
                    this.LoyaltyPrograms.Equals(input.LoyaltyPrograms))
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
                if (this.Applications != null)
                    hashCode = hashCode * 59 + this.Applications.GetHashCode();
                if (this.ActiveCampaigns != null)
                    hashCode = hashCode * 59 + this.ActiveCampaigns.GetHashCode();
                if (this.Campaigns != null)
                    hashCode = hashCode * 59 + this.Campaigns.GetHashCode();
                if (this.Coupons != null)
                    hashCode = hashCode * 59 + this.Coupons.GetHashCode();
                if (this.ActiveCoupons != null)
                    hashCode = hashCode * 59 + this.ActiveCoupons.GetHashCode();
                if (this.ExpiredCoupons != null)
                    hashCode = hashCode * 59 + this.ExpiredCoupons.GetHashCode();
                if (this.CustomAttributes != null)
                    hashCode = hashCode * 59 + this.CustomAttributes.GetHashCode();
                if (this.ReferralCodes != null)
                    hashCode = hashCode * 59 + this.ReferralCodes.GetHashCode();
                if (this.ActiveReferralCodes != null)
                    hashCode = hashCode * 59 + this.ActiveReferralCodes.GetHashCode();
                if (this.ExpiredReferralCodes != null)
                    hashCode = hashCode * 59 + this.ExpiredReferralCodes.GetHashCode();
                if (this.Users != null)
                    hashCode = hashCode * 59 + this.Users.GetHashCode();
                if (this.Roles != null)
                    hashCode = hashCode * 59 + this.Roles.GetHashCode();
                if (this.Webhooks != null)
                    hashCode = hashCode * 59 + this.Webhooks.GetHashCode();
                if (this.LoyaltyPrograms != null)
                    hashCode = hashCode * 59 + this.LoyaltyPrograms.GetHashCode();
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