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
    public enum SystemType
    {
        /// <summary>
        /// Enum NEUTRONSTAR for value: NEUTRON_STAR
        /// </summary>
        [EnumMember(Value = "NEUTRON_STAR")]
        NEUTRONSTAR = 1,

        /// <summary>
        /// Enum REDSTAR for value: RED_STAR
        /// </summary>
        [EnumMember(Value = "RED_STAR")]
        REDSTAR = 2,

        /// <summary>
        /// Enum ORANGESTAR for value: ORANGE_STAR
        /// </summary>
        [EnumMember(Value = "ORANGE_STAR")]
        ORANGESTAR = 3,

        /// <summary>
        /// Enum BLUESTAR for value: BLUE_STAR
        /// </summary>
        [EnumMember(Value = "BLUE_STAR")]
        BLUESTAR = 4,

        /// <summary>
        /// Enum YOUNGSTAR for value: YOUNG_STAR
        /// </summary>
        [EnumMember(Value = "YOUNG_STAR")]
        YOUNGSTAR = 5,

        /// <summary>
        /// Enum WHITEDWARF for value: WHITE_DWARF
        /// </summary>
        [EnumMember(Value = "WHITE_DWARF")]
        WHITEDWARF = 6,

        /// <summary>
        /// Enum BLACKHOLE for value: BLACK_HOLE
        /// </summary>
        [EnumMember(Value = "BLACK_HOLE")]
        BLACKHOLE = 7,

        /// <summary>
        /// Enum HYPERGIANT for value: HYPERGIANT
        /// </summary>
        [EnumMember(Value = "HYPERGIANT")]
        HYPERGIANT = 8,

        /// <summary>
        /// Enum NEBULA for value: NEBULA
        /// </summary>
        [EnumMember(Value = "NEBULA")]
        NEBULA = 9,

        /// <summary>
        /// Enum UNSTABLE for value: UNSTABLE
        /// </summary>
        [EnumMember(Value = "UNSTABLE")]
        UNSTABLE = 10

    }

}
