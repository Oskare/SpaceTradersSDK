/*
 * SpaceTraders API
 *
 * SpaceTraders is an open-universe game and learning platform that offers a set of HTTP endpoints to control a fleet of ships and explore a multiplayer universe.  The API is documented using [OpenAPI](https://github.com/SpaceTradersAPI/api-docs). You can send your first request right here in your browser to check the status of the game server.  ```json http {   \"method\": \"GET\",   \"url\": \"https://api.spacetraders.io/v2\", } ```  Unlike a traditional game, SpaceTraders does not have a first-party client or app to play the game. Instead, you can use the API to build your own client, write a script to automate your ships, or try an app built by the community.  We have a [Discord channel](https://discord.com/invite/jh6zurdWk5) where you can share your projects, ask questions, and get help from other players.   
 *
 * The version of the OpenAPI document: 2.0.0
 * Contact: joel@spacetraders.io
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = Org.OpenAPITools.Client.OpenAPIDateConverter;

namespace Org.OpenAPITools.Model
{
    /// <summary>
    /// ShipFuelConsumed
    /// </summary>
    [DataContract(Name = "ShipFuel_consumed")]
    public partial class ShipFuelConsumed : IEquatable<ShipFuelConsumed>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipFuelConsumed" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipFuelConsumed() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipFuelConsumed" /> class.
        /// </summary>
        /// <param name="amount">The amount of fuel consumed by the most recent transit or action. (required).</param>
        /// <param name="timestamp">The time at which the fuel was consumed. (required).</param>
        public ShipFuelConsumed(int amount = default(int), DateTime timestamp = default(DateTime))
        {
            this.Amount = amount;
            this.Timestamp = timestamp;
        }

        /// <summary>
        /// The amount of fuel consumed by the most recent transit or action.
        /// </summary>
        /// <value>The amount of fuel consumed by the most recent transit or action.</value>
        [DataMember(Name = "amount", IsRequired = true, EmitDefaultValue = true)]
        public int Amount { get; set; }

        /// <summary>
        /// The time at which the fuel was consumed.
        /// </summary>
        /// <value>The time at which the fuel was consumed.</value>
        [DataMember(Name = "timestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipFuelConsumed {\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as ShipFuelConsumed);
        }

        /// <summary>
        /// Returns true if ShipFuelConsumed instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipFuelConsumed to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipFuelConsumed input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) && 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
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
                hashCode = (hashCode * 59) + this.Amount.GetHashCode();
                if (this.Timestamp != null)
                {
                    hashCode = (hashCode * 59) + this.Timestamp.GetHashCode();
                }
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
            // Amount (int) minimum
            if (this.Amount < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Amount, must be a value greater than or equal to 0.", new [] { "Amount" });
            }

            yield break;
        }
    }

}
