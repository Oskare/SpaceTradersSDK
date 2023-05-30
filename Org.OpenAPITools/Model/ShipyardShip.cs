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
    /// ShipyardShip
    /// </summary>
    [DataContract(Name = "ShipyardShip")]
    public partial class ShipyardShip : IEquatable<ShipyardShip>, IValidatableObject
    {

        /// <summary>
        /// Gets or Sets Type
        /// </summary>
        [DataMember(Name = "type", EmitDefaultValue = false)]
        public ShipType? Type { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipyardShip" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipyardShip() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipyardShip" /> class.
        /// </summary>
        /// <param name="type">type.</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description (required).</param>
        /// <param name="purchasePrice">purchasePrice (required).</param>
        /// <param name="frame">frame (required).</param>
        /// <param name="reactor">reactor (required).</param>
        /// <param name="engine">engine (required).</param>
        /// <param name="modules">modules (required).</param>
        /// <param name="mounts">mounts (required).</param>
        public ShipyardShip(ShipType? type = default(ShipType?), string name = default(string), string description = default(string), int purchasePrice = default(int), ShipFrame frame = default(ShipFrame), ShipReactor reactor = default(ShipReactor), ShipEngine engine = default(ShipEngine), List<ShipModule> modules = default(List<ShipModule>), List<ShipMount> mounts = default(List<ShipMount>))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ShipyardShip and cannot be null");
            }
            this.Name = name;
            // to ensure "description" is required (not null)
            if (description == null)
            {
                throw new ArgumentNullException("description is a required property for ShipyardShip and cannot be null");
            }
            this.Description = description;
            this.PurchasePrice = purchasePrice;
            // to ensure "frame" is required (not null)
            if (frame == null)
            {
                throw new ArgumentNullException("frame is a required property for ShipyardShip and cannot be null");
            }
            this.Frame = frame;
            // to ensure "reactor" is required (not null)
            if (reactor == null)
            {
                throw new ArgumentNullException("reactor is a required property for ShipyardShip and cannot be null");
            }
            this.Reactor = reactor;
            // to ensure "engine" is required (not null)
            if (engine == null)
            {
                throw new ArgumentNullException("engine is a required property for ShipyardShip and cannot be null");
            }
            this.Engine = engine;
            // to ensure "modules" is required (not null)
            if (modules == null)
            {
                throw new ArgumentNullException("modules is a required property for ShipyardShip and cannot be null");
            }
            this.Modules = modules;
            // to ensure "mounts" is required (not null)
            if (mounts == null)
            {
                throw new ArgumentNullException("mounts is a required property for ShipyardShip and cannot be null");
            }
            this.Mounts = mounts;
            this.Type = type;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", IsRequired = true, EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets PurchasePrice
        /// </summary>
        [DataMember(Name = "purchasePrice", IsRequired = true, EmitDefaultValue = true)]
        public int PurchasePrice { get; set; }

        /// <summary>
        /// Gets or Sets Frame
        /// </summary>
        [DataMember(Name = "frame", IsRequired = true, EmitDefaultValue = true)]
        public ShipFrame Frame { get; set; }

        /// <summary>
        /// Gets or Sets Reactor
        /// </summary>
        [DataMember(Name = "reactor", IsRequired = true, EmitDefaultValue = true)]
        public ShipReactor Reactor { get; set; }

        /// <summary>
        /// Gets or Sets Engine
        /// </summary>
        [DataMember(Name = "engine", IsRequired = true, EmitDefaultValue = true)]
        public ShipEngine Engine { get; set; }

        /// <summary>
        /// Gets or Sets Modules
        /// </summary>
        [DataMember(Name = "modules", IsRequired = true, EmitDefaultValue = true)]
        public List<ShipModule> Modules { get; set; }

        /// <summary>
        /// Gets or Sets Mounts
        /// </summary>
        [DataMember(Name = "mounts", IsRequired = true, EmitDefaultValue = true)]
        public List<ShipMount> Mounts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipyardShip {\n");
            sb.Append("  Type: ").Append(Type).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  PurchasePrice: ").Append(PurchasePrice).Append("\n");
            sb.Append("  Frame: ").Append(Frame).Append("\n");
            sb.Append("  Reactor: ").Append(Reactor).Append("\n");
            sb.Append("  Engine: ").Append(Engine).Append("\n");
            sb.Append("  Modules: ").Append(Modules).Append("\n");
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
            return this.Equals(input as ShipyardShip);
        }

        /// <summary>
        /// Returns true if ShipyardShip instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipyardShip to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipyardShip input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Type == input.Type ||
                    this.Type.Equals(input.Type)
                ) && 
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
                    this.PurchasePrice == input.PurchasePrice ||
                    this.PurchasePrice.Equals(input.PurchasePrice)
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
                    this.Modules == input.Modules ||
                    this.Modules != null &&
                    input.Modules != null &&
                    this.Modules.SequenceEqual(input.Modules)
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
                hashCode = (hashCode * 59) + this.Type.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PurchasePrice.GetHashCode();
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
                if (this.Modules != null)
                {
                    hashCode = (hashCode * 59) + this.Modules.GetHashCode();
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
