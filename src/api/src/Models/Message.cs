﻿/*
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
using SendPulse.Api.Enums;

namespace SendPulse.Api.Models
{
    /// <summary>
    /// Message
    /// </summary>
    [DataContract]
    public partial class Message : IEquatable<Message>, IValidatableObject
    {
        /// <summary>
        ///                      * &#x60;1&#x60; - in                      * &#x60;2&#x60; - out
        /// </summary>
        /// <value>                     * &#x60;1&#x60; - in                      * &#x60;2&#x60; - out                  </value>
        [DataMember(Name = "direction", EmitDefaultValue = true)]
        public DirectionEnum? Direction { get; set; }

        /// <summary>
        ///                      * &#x60;1&#x60; - new
        /// </summary>
        /// <value>                     * &#x60;1&#x60; - new                  </value>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public MessageStatusEnum? Status { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Message" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="contactId">contactId.</param>
        /// <param name="botId">botId.</param>
        /// <param name="campaignId">campaignId.</param>
        /// <param name="data">https://core.telegram.org/bots/api#message.</param>
        /// <param name="direction">                     * &#x60;1&#x60; - in                      * &#x60;2&#x60; - out                  .</param>
        /// <param name="status">                     * &#x60;1&#x60; - new                  .</param>
        /// <param name="createdAt">createdAt.</param>
        public Message(
            string id = default(string),
            string contactId = default(string),
            string botId = default(string),
            string campaignId = default(string),
            Telegram.Bot.Types.Message data = default(Telegram.Bot.Types.Message),
            DirectionEnum? direction = default(DirectionEnum?),
            MessageStatusEnum? status = default(MessageStatusEnum?),
            string createdAt = default(string)
        )
        {
            this.Id = id;
            this.ContactId = contactId;
            this.BotId = botId;
            this.CampaignId = campaignId;
            this.Data = data;
            this.Direction = direction;
            this.Status = status;
            this.CreatedAt = createdAt;
        }

        public Message() { }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ContactId
        /// </summary>
        [DataMember(Name = "contact_id", EmitDefaultValue = true)]
        public string ContactId { get; set; }

        /// <summary>
        /// Gets or Sets BotId
        /// </summary>
        [DataMember(Name = "bot_id", EmitDefaultValue = true)]
        public string BotId { get; set; }

        /// <summary>
        /// Gets or Sets CampaignId
        /// </summary>
        [DataMember(Name = "campaign_id", EmitDefaultValue = true)]
        public string CampaignId { get; set; }

        /// <summary>
        /// https://core.telegram.org/bots/api#message
        /// </summary>
        /// <value>https://core.telegram.org/bots/api#message</value>
        [DataMember(Name = "data", EmitDefaultValue = true)]
        public global::Telegram.Bot.Types.Message Data { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "created_at", EmitDefaultValue = true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Message {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  BotId: ").Append(BotId).Append("\n");
            sb.Append("  CampaignId: ").Append(CampaignId).Append("\n");
            sb.Append("  Data: ").Append(Data).Append("\n");
            sb.Append("  Direction: ").Append(Direction).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
        /// <param name="input">object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Message);
        }

        /// <summary>
        /// Returns true if Message instances are equal
        /// </summary>
        /// <param name="input">Instance of Message to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Message input)
        {
            if (input == null)
                return false;

            return (this.Id == input.Id || (this.Id != null && this.Id.Equals(input.Id)))
                && (
                    this.ContactId == input.ContactId
                    || (this.ContactId != null && this.ContactId.Equals(input.ContactId))
                )
                && (
                    this.BotId == input.BotId
                    || (this.BotId != null && this.BotId.Equals(input.BotId))
                )
                && (
                    this.CampaignId == input.CampaignId
                    || (this.CampaignId != null && this.CampaignId.Equals(input.CampaignId))
                )
                && (this.Data == input.Data || (this.Data != null && this.Data.Equals(input.Data)))
                && (
                    this.Direction == input.Direction
                    || (this.Direction != null && this.Direction.Equals(input.Direction))
                )
                && (
                    this.Status == input.Status
                    || (this.Status != null && this.Status.Equals(input.Status))
                )
                && (
                    this.CreatedAt == input.CreatedAt
                    || (this.CreatedAt != null && this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.ContactId != null)
                    hashCode = hashCode * 59 + this.ContactId.GetHashCode();
                if (this.BotId != null)
                    hashCode = hashCode * 59 + this.BotId.GetHashCode();
                if (this.CampaignId != null)
                    hashCode = hashCode * 59 + this.CampaignId.GetHashCode();
                if (this.Data != null)
                    hashCode = hashCode * 59 + this.Data.GetHashCode();
                if (this.Direction != null)
                    hashCode = hashCode * 59 + this.Direction.GetHashCode();
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(
            ValidationContext validationContext
        )
        {
            yield break;
        }

        [JExtension]
        public JExtensionDict ExtensionData { get; set; }
    }
}