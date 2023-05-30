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
    /// The type of waypoint.
    /// </summary>
    /// <value>The type of waypoint.</value>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum WaypointType
    {
        /// <summary>
        /// Enum PLANET for value: PLANET
        /// </summary>
        [EnumMember(Value = "PLANET")]
        PLANET = 1,

        /// <summary>
        /// Enum GASGIANT for value: GAS_GIANT
        /// </summary>
        [EnumMember(Value = "GAS_GIANT")]
        GASGIANT = 2,

        /// <summary>
        /// Enum MOON for value: MOON
        /// </summary>
        [EnumMember(Value = "MOON")]
        MOON = 3,

        /// <summary>
        /// Enum ORBITALSTATION for value: ORBITAL_STATION
        /// </summary>
        [EnumMember(Value = "ORBITAL_STATION")]
        ORBITALSTATION = 4,

        /// <summary>
        /// Enum JUMPGATE for value: JUMP_GATE
        /// </summary>
        [EnumMember(Value = "JUMP_GATE")]
        JUMPGATE = 5,

        /// <summary>
        /// Enum ASTEROIDFIELD for value: ASTEROID_FIELD
        /// </summary>
        [EnumMember(Value = "ASTEROID_FIELD")]
        ASTEROIDFIELD = 6,

        /// <summary>
        /// Enum NEBULA for value: NEBULA
        /// </summary>
        [EnumMember(Value = "NEBULA")]
        NEBULA = 7,

        /// <summary>
        /// Enum DEBRISFIELD for value: DEBRIS_FIELD
        /// </summary>
        [EnumMember(Value = "DEBRIS_FIELD")]
        DEBRISFIELD = 8,

        /// <summary>
        /// Enum GRAVITYWELL for value: GRAVITY_WELL
        /// </summary>
        [EnumMember(Value = "GRAVITY_WELL")]
        GRAVITYWELL = 9

    }

}
