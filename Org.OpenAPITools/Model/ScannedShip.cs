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
    /// The ship that was scanned. Details include information about the ship that could be detected by the scanner.
    /// </summary>
    [DataContract(Name = "ScannedShip")]
    public partial class ScannedShip : IEquatable<ScannedShip>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannedShip" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScannedShip() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScannedShip" /> class.
        /// </summary>
        /// <param name="symbol">The globally unique identifier of the ship. (required).</param>
        /// <param name="registration">registration (required).</param>
        /// <param name="nav">nav (required).</param>
        /// <param name="frame">frame.</param>
        /// <param name="reactor">reactor.</param>
        /// <param name="engine">engine (required).</param>
        /// <param name="mounts">mounts.</param>
        public ScannedShip(string symbol = default(string), ShipRegistration registration = default(ShipRegistration), ShipNav nav = default(ShipNav), ScannedShipFrame frame = default(ScannedShipFrame), ScannedShipReactor reactor = default(ScannedShipReactor), ScannedShipEngine engine = default(ScannedShipEngine), List<ScannedShipMountsInner> mounts = default(List<ScannedShipMountsInner>))
        {
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new ArgumentNullException("symbol is a required property for ScannedShip and cannot be null");
            }
            this.Symbol = symbol;
            // to ensure "registration" is required (not null)
            if (registration == null)
            {
                throw new ArgumentNullException("registration is a required property for ScannedShip and cannot be null");
            }
            this.Registration = registration;
            // to ensure "nav" is required (not null)
            if (nav == null)
            {
                throw new ArgumentNullException("nav is a required property for ScannedShip and cannot be null");
            }
            this.Nav = nav;
            // to ensure "engine" is required (not null)
            if (engine == null)
            {
                throw new ArgumentNullException("engine is a required property for ScannedShip and cannot be null");
            }
            this.Engine = engine;
            this.Frame = frame;
            this.Reactor = reactor;
            this.Mounts = mounts;
        }

        /// <summary>
        /// The globally unique identifier of the ship.
        /// </summary>
        /// <value>The globally unique identifier of the ship.</value>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets Registration
        /// </summary>
        [DataMember(Name = "registration", IsRequired = true, EmitDefaultValue = true)]
        public ShipRegistration Registration { get; set; }

        /// <summary>
        /// Gets or Sets Nav
        /// </summary>
        [DataMember(Name = "nav", IsRequired = true, EmitDefaultValue = true)]
        public ShipNav Nav { get; set; }

        /// <summary>
        /// Gets or Sets Frame
        /// </summary>
        [DataMember(Name = "frame", EmitDefaultValue = false)]
        public ScannedShipFrame Frame { get; set; }

        /// <summary>
        /// Gets or Sets Reactor
        /// </summary>
        [DataMember(Name = "reactor", EmitDefaultValue = false)]
        public ScannedShipReactor Reactor { get; set; }

        /// <summary>
        /// Gets or Sets Engine
        /// </summary>
        [DataMember(Name = "engine", IsRequired = true, EmitDefaultValue = true)]
        public ScannedShipEngine Engine { get; set; }

        /// <summary>
        /// Gets or Sets Mounts
        /// </summary>
        [DataMember(Name = "mounts", EmitDefaultValue = false)]
        public List<ScannedShipMountsInner> Mounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScannedShip {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Registration: ").Append(Registration).Append("\n");
            sb.Append("  Nav: ").Append(Nav).Append("\n");
            sb.Append("  Frame: ").Append(Frame).Append("\n");
            sb.Append("  Reactor: ").Append(Reactor).Append("\n");
            sb.Append("  Engine: ").Append(Engine).Append("\n");
            sb.Append("  Mounts: ").Append(Mounts).Append("\n");
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
            return this.Equals(input as ScannedShip);
        }

        /// <summary>
        /// Returns true if ScannedShip instances are equal
        /// </summary>
        /// <param name="input">Instance of ScannedShip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScannedShip input)
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
                    this.Registration == input.Registration ||
                    (this.Registration != null &&
                    this.Registration.Equals(input.Registration))
                ) && 
                (
                    this.Nav == input.Nav ||
                    (this.Nav != null &&
                    this.Nav.Equals(input.Nav))
                ) && 
                (
                    this.Frame == input.Frame ||
                    (this.Frame != null &&
                    this.Frame.Equals(input.Frame))
                ) && 
                (
                    this.Reactor == input.Reactor ||
                    (this.Reactor != null &&
                    this.Reactor.Equals(input.Reactor))
                ) && 
                (
                    this.Engine == input.Engine ||
                    (this.Engine != null &&
                    this.Engine.Equals(input.Engine))
                ) && 
                (
                    this.Mounts == input.Mounts ||
                    this.Mounts != null &&
                    input.Mounts != null &&
                    this.Mounts.SequenceEqual(input.Mounts)
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
                if (this.Registration != null)
                {
                    hashCode = (hashCode * 59) + this.Registration.GetHashCode();
                }
                if (this.Nav != null)
                {
                    hashCode = (hashCode * 59) + this.Nav.GetHashCode();
                }
                if (this.Frame != null)
                {
                    hashCode = (hashCode * 59) + this.Frame.GetHashCode();
                }
                if (this.Reactor != null)
                {
                    hashCode = (hashCode * 59) + this.Reactor.GetHashCode();
                }
                if (this.Engine != null)
                {
                    hashCode = (hashCode * 59) + this.Engine.GetHashCode();
                }
                if (this.Mounts != null)
                {
                    hashCode = (hashCode * 59) + this.Mounts.GetHashCode();
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
            yield break;
        }
    }

}
