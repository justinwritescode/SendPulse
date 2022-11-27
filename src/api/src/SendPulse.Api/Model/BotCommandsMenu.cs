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
    /// BotCommandsMenu
    /// </summary>
    [DataContract]
        internal partial class BotCommandsMenu :  IEquatable<BotCommandsMenu>, IValidatableObject
    {
        /// <summary>
        ///                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  
        /// </summary>
        /// <value>                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  </value>
        [JsonConverter(typeof(StringEnumConverter))]
                internal enum StatusEnum
        {
            /// <summary>
            /// Enum NUMBER_1 for value: 1
            /// </summary>
            [EnumMember(Value = "1")]
            NUMBER_1 = 1,
            /// <summary>
            /// Enum NUMBER_2 for value: 2
            /// </summary>
            [EnumMember(Value = "2")]
            NUMBER_2 = 2        }
        /// <summary>
        ///                      * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  
        /// </summary>
        /// <value>                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  </value>
        [DataMember(Name="status", EmitDefaultValue=true)]
        public StatusEnum? Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="BotCommandsMenu" /> class.
        /// </summary>
        /// <param name="status">                     * &#x60;1&#x60; - active                      * &#x60;2&#x60; - inactive                  .</param>
        /// <param name="commands">commands.</param>
        public BotCommandsMenu(StatusEnum? status = default(StatusEnum?), Collection<BotCommandsMenuCommands> commands = default(Collection<BotCommandsMenuCommands>))
        {
            this.Status = status;
            this.Commands = commands;
        }
        

        /// <summary>
        /// Gets or Sets Commands
        /// </summary>
        [DataMember(Name="commands", EmitDefaultValue=true)]
        public Collection<BotCommandsMenuCommands> Commands { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BotCommandsMenu {\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  Commands: ").Append(Commands).Append("\n");
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
            return this.Equals(input as BotCommandsMenu);
        }

        /// <summary>
        /// Returns true if BotCommandsMenu instances are equal
        /// </summary>
        /// <param name="input">Instance of BotCommandsMenu to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BotCommandsMenu input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.Commands == input.Commands ||
                    this.Commands != null &&
                    input.Commands != null &&
                    this.Commands.SequenceEqual(input.Commands)
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.Commands != null)
                    hashCode = hashCode * 59 + this.Commands.GetHashCode();
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
