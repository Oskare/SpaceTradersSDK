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
    /// A mount is installed on the exterier of a ship.
    /// </summary>
    [DataContract(Name = "ShipMount")]
    public partial class ShipMount : IEquatable<ShipMount>, IValidatableObject
    {
        /// <summary>
        /// Defines Symbol
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SymbolEnum
        {
            /// <summary>
            /// Enum GASSIPHONI for value: MOUNT_GAS_SIPHON_I
            /// </summary>
            [EnumMember(Value = "MOUNT_GAS_SIPHON_I")]
            GASSIPHONI = 1,

            /// <summary>
            /// Enum GASSIPHONII for value: MOUNT_GAS_SIPHON_II
            /// </summary>
            [EnumMember(Value = "MOUNT_GAS_SIPHON_II")]
            GASSIPHONII = 2,

            /// <summary>
            /// Enum GASSIPHONIII for value: MOUNT_GAS_SIPHON_III
            /// </summary>
            [EnumMember(Value = "MOUNT_GAS_SIPHON_III")]
            GASSIPHONIII = 3,

            /// <summary>
            /// Enum SURVEYORI for value: MOUNT_SURVEYOR_I
            /// </summary>
            [EnumMember(Value = "MOUNT_SURVEYOR_I")]
            SURVEYORI = 4,

            /// <summary>
            /// Enum SURVEYORII for value: MOUNT_SURVEYOR_II
            /// </summary>
            [EnumMember(Value = "MOUNT_SURVEYOR_II")]
            SURVEYORII = 5,

            /// <summary>
            /// Enum SURVEYORIII for value: MOUNT_SURVEYOR_III
            /// </summary>
            [EnumMember(Value = "MOUNT_SURVEYOR_III")]
            SURVEYORIII = 6,

            /// <summary>
            /// Enum SENSORARRAYI for value: MOUNT_SENSOR_ARRAY_I
            /// </summary>
            [EnumMember(Value = "MOUNT_SENSOR_ARRAY_I")]
            SENSORARRAYI = 7,

            /// <summary>
            /// Enum SENSORARRAYII for value: MOUNT_SENSOR_ARRAY_II
            /// </summary>
            [EnumMember(Value = "MOUNT_SENSOR_ARRAY_II")]
            SENSORARRAYII = 8,

            /// <summary>
            /// Enum SENSORARRAYIII for value: MOUNT_SENSOR_ARRAY_III
            /// </summary>
            [EnumMember(Value = "MOUNT_SENSOR_ARRAY_III")]
            SENSORARRAYIII = 9,

            /// <summary>
            /// Enum MININGLASERI for value: MOUNT_MINING_LASER_I
            /// </summary>
            [EnumMember(Value = "MOUNT_MINING_LASER_I")]
            MININGLASERI = 10,

            /// <summary>
            /// Enum MININGLASERII for value: MOUNT_MINING_LASER_II
            /// </summary>
            [EnumMember(Value = "MOUNT_MINING_LASER_II")]
            MININGLASERII = 11,

            /// <summary>
            /// Enum MININGLASERIII for value: MOUNT_MINING_LASER_III
            /// </summary>
            [EnumMember(Value = "MOUNT_MINING_LASER_III")]
            MININGLASERIII = 12,

            /// <summary>
            /// Enum LASERCANNONI for value: MOUNT_LASER_CANNON_I
            /// </summary>
            [EnumMember(Value = "MOUNT_LASER_CANNON_I")]
            LASERCANNONI = 13,

            /// <summary>
            /// Enum MISSILELAUNCHERI for value: MOUNT_MISSILE_LAUNCHER_I
            /// </summary>
            [EnumMember(Value = "MOUNT_MISSILE_LAUNCHER_I")]
            MISSILELAUNCHERI = 14,

            /// <summary>
            /// Enum TURRETI for value: MOUNT_TURRET_I
            /// </summary>
            [EnumMember(Value = "MOUNT_TURRET_I")]
            TURRETI = 15

        }


        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name = "symbol", IsRequired = true, EmitDefaultValue = true)]
        public SymbolEnum Symbol { get; set; }
        /// <summary>
        /// Defines Deposits
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DepositsEnum
        {
            /// <summary>
            /// Enum QUARTZSAND for value: QUARTZ_SAND
            /// </summary>
            [EnumMember(Value = "QUARTZ_SAND")]
            QUARTZSAND = 1,

            /// <summary>
            /// Enum SILICONCRYSTALS for value: SILICON_CRYSTALS
            /// </summary>
            [EnumMember(Value = "SILICON_CRYSTALS")]
            SILICONCRYSTALS = 2,

            /// <summary>
            /// Enum PRECIOUSSTONES for value: PRECIOUS_STONES
            /// </summary>
            [EnumMember(Value = "PRECIOUS_STONES")]
            PRECIOUSSTONES = 3,

            /// <summary>
            /// Enum ICEWATER for value: ICE_WATER
            /// </summary>
            [EnumMember(Value = "ICE_WATER")]
            ICEWATER = 4,

            /// <summary>
            /// Enum AMMONIAICE for value: AMMONIA_ICE
            /// </summary>
            [EnumMember(Value = "AMMONIA_ICE")]
            AMMONIAICE = 5,

            /// <summary>
            /// Enum IRONORE for value: IRON_ORE
            /// </summary>
            [EnumMember(Value = "IRON_ORE")]
            IRONORE = 6,

            /// <summary>
            /// Enum COPPERORE for value: COPPER_ORE
            /// </summary>
            [EnumMember(Value = "COPPER_ORE")]
            COPPERORE = 7,

            /// <summary>
            /// Enum SILVERORE for value: SILVER_ORE
            /// </summary>
            [EnumMember(Value = "SILVER_ORE")]
            SILVERORE = 8,

            /// <summary>
            /// Enum ALUMINUMORE for value: ALUMINUM_ORE
            /// </summary>
            [EnumMember(Value = "ALUMINUM_ORE")]
            ALUMINUMORE = 9,

            /// <summary>
            /// Enum GOLDORE for value: GOLD_ORE
            /// </summary>
            [EnumMember(Value = "GOLD_ORE")]
            GOLDORE = 10,

            /// <summary>
            /// Enum PLATINUMORE for value: PLATINUM_ORE
            /// </summary>
            [EnumMember(Value = "PLATINUM_ORE")]
            PLATINUMORE = 11,

            /// <summary>
            /// Enum DIAMONDS for value: DIAMONDS
            /// </summary>
            [EnumMember(Value = "DIAMONDS")]
            DIAMONDS = 12,

            /// <summary>
            /// Enum URANITEORE for value: URANITE_ORE
            /// </summary>
            [EnumMember(Value = "URANITE_ORE")]
            URANITEORE = 13,

            /// <summary>
            /// Enum MERITIUMORE for value: MERITIUM_ORE
            /// </summary>
            [EnumMember(Value = "MERITIUM_ORE")]
            MERITIUMORE = 14

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ShipMount" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ShipMount() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ShipMount" /> class.
        /// </summary>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="name">name (required).</param>
        /// <param name="description">description.</param>
        /// <param name="strength">strength.</param>
        /// <param name="deposits">deposits.</param>
        /// <param name="requirements">requirements (required).</param>
        public ShipMount(SymbolEnum symbol = default(SymbolEnum), string name = default(string), string description = default(string), int strength = default(int), List<DepositsEnum> deposits = default(List<DepositsEnum>), ShipRequirements requirements = default(ShipRequirements))
        {
            this.Symbol = symbol;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for ShipMount and cannot be null");
            }
            this.Name = name;
            // to ensure "requirements" is required (not null)
            if (requirements == null)
            {
                throw new ArgumentNullException("requirements is a required property for ShipMount and cannot be null");
            }
            this.Requirements = requirements;
            this.Description = description;
            this.Strength = strength;
            this.Deposits = deposits;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets Description
        /// </summary>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// Gets or Sets Strength
        /// </summary>
        [DataMember(Name = "strength", EmitDefaultValue = false)]
        public int Strength { get; set; }

        /// <summary>
        /// Gets or Sets Deposits
        /// </summary>
        [DataMember(Name = "deposits", EmitDefaultValue = false)]
        public List<ShipMount.DepositsEnum> Deposits { get; set; }

        /// <summary>
        /// Gets or Sets Requirements
        /// </summary>
        [DataMember(Name = "requirements", IsRequired = true, EmitDefaultValue = true)]
        public ShipRequirements Requirements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ShipMount {\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Strength: ").Append(Strength).Append("\n");
            sb.Append("  Deposits: ").Append(Deposits).Append("\n");
            sb.Append("  Requirements: ").Append(Requirements).Append("\n");
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
            return this.Equals(input as ShipMount);
        }

        /// <summary>
        /// Returns true if ShipMount instances are equal
        /// </summary>
        /// <param name="input">Instance of ShipMount to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ShipMount input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Symbol == input.Symbol ||
                    this.Symbol.Equals(input.Symbol)
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
                    this.Strength == input.Strength ||
                    this.Strength.Equals(input.Strength)
                ) && 
                (
                    this.Deposits == input.Deposits ||
                    this.Deposits != null &&
                    input.Deposits != null &&
                    this.Deposits.SequenceEqual(input.Deposits)
                ) && 
                (
                    this.Requirements == input.Requirements ||
                    (this.Requirements != null &&
                    this.Requirements.Equals(input.Requirements))
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
                hashCode = (hashCode * 59) + this.Symbol.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Strength.GetHashCode();
                if (this.Deposits != null)
                {
                    hashCode = (hashCode * 59) + this.Deposits.GetHashCode();
                }
                if (this.Requirements != null)
                {
                    hashCode = (hashCode * 59) + this.Requirements.GetHashCode();
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
            // Strength (int) minimum
            if (this.Strength < (int)0)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Strength, must be a value greater than or equal to 0.", new [] { "Strength" });
            }

            yield break;
        }
    }

}
