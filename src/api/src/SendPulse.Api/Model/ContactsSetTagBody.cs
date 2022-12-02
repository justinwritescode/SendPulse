/*
 * Telegram service API
 *
 * Using the API for Telegram chatbots, you can integrate your system with SendPulse’s chatbots service and get detailed information about your account, bots, subscribers, variables, flows, and chats. You can also create campaigns, launch flows, assign and remove variables and tags.               On the right, there is a button for authorizing requests made on this page. Click “Authorize,” then insert the ID and Secret from your account.               To perform a request directly from the page, click the \"Try it out\" button within each method block. Then fill in input fields if any (for URL parameters, the description is right below the URL request; for body parameters, the description is under the “Scheme” button to the right of the example), and click “Run.” You'll find the server response and description of received parameters below.
 *
 * OpenAPI spec version: 1.0.0
 * Contact: justin@justinwritescode.com
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
using SwaggerDateConverter = SendPulse.Api.Client.SwaggerDateConverter;

namespace SendPulse.Api.Model
{
    /// <summary>
    /// ContactsSetTagBody
    /// </summary>
    [DataContract]
        internal partial class ContactsSetTagBody :  IEquatable<ContactsSetTagBody>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactsSetTagBody" /> class.
        /// </summary>
        /// <param name="contactId">Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact. (required).</param>
        /// <param name="tags">List of tags to assign to the contact (required).</param>
        public ContactsSetTagBody(string contactId = default(string), Collection<string> tags = default(Collection<string>))
        {
            // to ensure "contactId" is required (not null)
            if (contactId == null)
            {
                throw new InvalidDataException("contactId is a required property for ContactsSetTagBody and cannot be null");
            }
            else
            {
                this.ContactId = contactId;
            }
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new InvalidDataException("tags is a required property for ContactsSetTagBody and cannot be null");
            }
            else
            {
                this.Tags = tags;
            }
        }

        /// <summary>
        /// Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.
        /// </summary>
        /// <value>Contact ID. Can be obtained with a contact search by tag or variable. You can also find it in your account in the address bar of a chat window with the desired contact.</value>
        [DataMember(Name="contact_id", EmitDefaultValue=true)]
        public string ContactId { get; set; }

        /// <summary>
        /// List of tags to assign to the contact
        /// </summary>
        /// <value>List of tags to assign to the contact</value>
        [DataMember(Name="tags", EmitDefaultValue=true)]
        public Collection<string> Tags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ContactsSetTagBody {\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
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
            return this.Equals(input as ContactsSetTagBody);
        }

        /// <summary>
        /// Returns true if ContactsSetTagBody instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactsSetTagBody to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactsSetTagBody input)
        {
            if (input == null)
                return false;

            return
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
                ) &&
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
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
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
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
