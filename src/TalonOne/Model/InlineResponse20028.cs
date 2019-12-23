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
    /// InlineResponse20028
    /// </summary>
    [DataContract]
    public partial class InlineResponse20028 :  IEquatable<InlineResponse20028>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20028" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InlineResponse20028() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineResponse20028" /> class.
        /// </summary>
        /// <param name="totalResultSize">totalResultSize (required).</param>
        /// <param name="data">data (required).</param>
        public InlineResponse20028(int? totalResultSize = default(int?), List<Import> data = default(List<Import>))
        {
            // to ensure "totalResultSize" is required (not null)
            if (totalResultSize == null)
            {
                throw new InvalidDataException("totalResultSize is a required property for InlineResponse20028 and cannot be null");
            }
            else
            {
                this.TotalResultSize = totalResultSize;
            }
            // to ensure "data" is required (not null)
            if (data == null)
            {
                throw new InvalidDataException("data is a required property for InlineResponse20028 and cannot be null");
            }
            else
            {
                this.Data = data;
            }
        }
        
        /// <summary>
        /// Gets or Sets TotalResultSize
        /// </summary>
        [DataMember(Name="totalResultSize", EmitDefaultValue=false)]
        public int? TotalResultSize { get; set; }

        /// <summary>
        /// Gets or Sets Data
        /// </summary>
        [DataMember(Name="data", EmitDefaultValue=false)]
        public List<Import> Data { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineResponse20028 {\n");
            sb.Append("  TotalResultSize: ").Append(TotalResultSize).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
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
            return this.Equals(input as InlineResponse20028);
        }

        /// <summary>
        /// Returns true if InlineResponse20028 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineResponse20028 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineResponse20028 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalResultSize == input.TotalResultSize ||
                    (this.TotalResultSize != null &&
                    this.TotalResultSize.Equals(input.TotalResultSize))
                ) && 
                (
                    this.Data == input.Data ||
                    this.Data != null &&
                    this.Data.SequenceEqual(input.Data)
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
                if (this.TotalResultSize != null)
                    hashCode = hashCode * 59 + this.TotalResultSize.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
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
