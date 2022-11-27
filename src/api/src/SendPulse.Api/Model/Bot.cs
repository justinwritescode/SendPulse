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
    /// Bot
    /// </summary>
    [DataContract]
        internal partial class Bot :  IEquatable<Bot>, IValidatableObject
    {
        /// <summary>
        ///                      * &#x60;3&#x60; - active                      * &#x60;4&#x60; - inactive                  
        /// </summary>
        /// <value>                     * &#x60;3&#x60; - active                      * &#x60;4&#x60; - inactive                  </value>
        [JsonConverter(typeof(StringEnumConverter))]
                internal enum StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_3 for value: 3
            /// </summary>
            [EnumMember(Value = "3")]
            NUMBER_3 = 1,
            /// <summary>
            /// Enum NUMBER_4 for value: 4
            /// </summary>
            [EnumMember(Value = "4")]
            NUMBER_4 = 2        }
        /// <summary>
        ///                      * &#x60;3&#x60; - active                      * &#x60;4&#x60; - inactive                  
        /// </summary>
        /// <value>                     * &#x60;3&#x60; - active                      * &#x60;4&#x60; - inactive                  </value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="Bot" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="channelData">channelData.</param>
        /// <param name="inbox">inbox.</param>
        /// <param name="commandsMenu">commandsMenu.</param>
        /// <param name="status">                     * &#x60;3&#x60; - active                      * &#x60;4&#x60; - inactive                  .</param>
        /// <param name="createdAt">createdAt.</param>
        public Bot(string id = default(string), BotChannelData channelData = default(BotChannelData), BotInbox inbox = default(BotInbox), BotCommandsMenu commandsMenu = default(BotCommandsMenu), StatusEnum? status = default(StatusEnum?), string createdAt = default(string))
        {
            this.Id = id;
            this.ChannelData = channelData;
            this.Inbox = inbox;
            this.CommandsMenu = commandsMenu;
            this.Status = status;
            this.CreatedAt = createdAt;
        }
        
        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=true)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets ChannelData
        /// </summary>
        [DataMember(Name="channel_data", EmitDefaultValue=true)]
        public BotChannelData ChannelData { get; set; }

        /// <summary>
        /// Gets or Sets Inbox
        /// </summary>
        [DataMember(Name="inbox", EmitDefaultValue=true)]
        public BotInbox Inbox { get; set; }

        /// <summary>
        /// Gets or Sets CommandsMenu
        /// </summary>
        [DataMember(Name="commands_menu", EmitDefaultValue=true)]
        public BotCommandsMenu CommandsMenu { get; set; }


        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name="created_at", EmitDefaultValue=true)]
        public string CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>string presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Bot {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  ChannelData: ").Append(ChannelData).Append("\n");
            sb.Append("  Inbox: ").Append(Inbox).Append("\n");
            sb.Append("  CommandsMenu: ").Append(CommandsMenu).Append("\n");
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
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Bot);
        }

        /// <summary>
        /// Returns true if Bot instances are equal
        /// </summary>
        /// <param name="input">Instance of Bot to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Bot input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.ChannelData == input.ChannelData ||
                    (this.ChannelData != null &&
                    this.ChannelData.Equals(input.ChannelData))
                ) && 
                (
                    this.Inbox == input.Inbox ||
                    (this.Inbox != null &&
                    this.Inbox.Equals(input.Inbox))
                ) && 
                (
                    this.CommandsMenu == input.CommandsMenu ||
                    (this.CommandsMenu != null &&
                    this.CommandsMenu.Equals(input.CommandsMenu))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.ChannelData != null)
                    hashCode = hashCode * 59 + this.ChannelData.GetHashCode();
                if (this.Inbox != null)
                    hashCode = hashCode * 59 + this.Inbox.GetHashCode();
                if (this.CommandsMenu != null)
                    hashCode = hashCode * 59 + this.CommandsMenu.GetHashCode();
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
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }
}
