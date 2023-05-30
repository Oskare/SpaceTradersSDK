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
    /// The destination or departure of a ships nav route.
    /// </summary>
    [DataContract(Name = "ShipNavRouteWaypoint")]
    public partial class ShipNavRouteWaypoint : IEquatable<ShipNavRouteWaypoint>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", IsRequired = true, EmitDefaultValue = true)]
        public WaypointType Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipNavRouteWaypoint" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipNavRouteWaypoint() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipNavRouteWaypoint" /> class.
        /// </summary>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="type">type (required).</param>
        /// <param name="systemSymbol">systemSymbol (required).</param>
        /// <param name="x">x (required).</param>
        /// <param name="y">y (required).</param>
        public ShipNavRouteWaypoint(string symbol = default(string), WaypointType type = default(WaypointType), string systemSymbol = default(string), int x = default(int), int y = default(int))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ShipNavRouteWaypoint and cannot be null");
            }
            this.Symbol = symbol;
            this.Type = type;
            // to ensure "systemSymbol" is required (not null)
            if (systemSymbol == null)
            {
                throw new ArgumentNullException("systemSymbol is a required property for ShipNavRouteWaypoint and cannot be null");
            }
            this.SystemSymbol = systemSymbol;
            this.X = x;
            this.Y = y;
        }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets SystemSymbol
        /// </summary>
        [DataMember(Name = "systemSymbol", IsRequired = true, EmitDefaultValue = true)]
        public string SystemSymbol { get; set; }

        /// <summary>
        /// Gets or Sets X
        /// </summary>
        [DataMember(Name = "x", IsRequired = true, EmitDefaultValue = true)]
        public int X { get; set; }

        /// <summary>
        /// Gets or Sets Y
        /// </summary>
        [DataMember(Name = "y", IsRequired = true, EmitDefaultValue = true)]
        public int Y { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipNavRouteWaypoint {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  SystemSymbol: ").Append(SystemSymbol).Append("\n");
            sb.Append("  X: ").Append(X).Append("\n");
            sb.Append("  Y: ").Append(Y).Append("\n");
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
            return this.Equals(input as ShipNavRouteWaypoint);
        }

        /// <summary>
        /// Returns true if ShipNavRouteWaypoint instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipNavRouteWaypoint to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipNavRouteWaypoint input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
                (
                    this.SystemSymbol == input.SystemSymbol ||
                    (this.SystemSymbol != null &&
                    this.SystemSymbol.Equals(input.SystemSymbol))
                ) && 
                (
                    this.X == input.X ||
                    this.X.Equals(input.X)
                ) && 
                (
                    this.Y == input.Y ||
                    this.Y.Equals(input.Y)
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
                if (this.Symbol != null)
                {
                    hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.SystemSymbol != null)
                {
                    hashCode = (hashCode * 59) + this.SystemSymbol.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.X.GetHashCode();
                hashCode = (hashCode * 59) + this.Y.GetHashCode();
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
            // Symbol (string) minLength
            if (this.Symbol != null && this.Symbol.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Symbol, length must be greater than 1.", new [] { "Symbol" });
            }

            // SystemSymbol (string) minLength
            if (this.SystemSymbol != null && this.SystemSymbol.Length < 1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for SystemSymbol, length must be greater than 1.", new [] { "SystemSymbol" });
            }

            yield break;
        }
    }

}
