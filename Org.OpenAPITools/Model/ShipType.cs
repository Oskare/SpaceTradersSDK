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
    /// Defines ShipType
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ShipType
    {
        /// <summary>
        /// Enum PROBE for value: SHIP_PROBE
        /// </summary>
        [EnumMember(Value = "SHIP_PROBE")]
        PROBE = 1,

        /// <summary>
        /// Enum MININGDRONE for value: SHIP_MINING_DRONE
        /// </summary>
        [EnumMember(Value = "SHIP_MINING_DRONE")]
        MININGDRONE = 2,

        /// <summary>
        /// Enum INTERCEPTOR for value: SHIP_INTERCEPTOR
        /// </summary>
        [EnumMember(Value = "SHIP_INTERCEPTOR")]
        INTERCEPTOR = 3,

        /// <summary>
        /// Enum LIGHTHAULER for value: SHIP_LIGHT_HAULER
        /// </summary>
        [EnumMember(Value = "SHIP_LIGHT_HAULER")]
        LIGHTHAULER = 4,

        /// <summary>
        /// Enum COMMANDFRIGATE for value: SHIP_COMMAND_FRIGATE
        /// </summary>
        [EnumMember(Value = "SHIP_COMMAND_FRIGATE")]
        COMMANDFRIGATE = 5,

        /// <summary>
        /// Enum EXPLORER for value: SHIP_EXPLORER
        /// </summary>
        [EnumMember(Value = "SHIP_EXPLORER")]
        EXPLORER = 6,

        /// <summary>
        /// Enum HEAVYFREIGHTER for value: SHIP_HEAVY_FREIGHTER
        /// </summary>
        [EnumMember(Value = "SHIP_HEAVY_FREIGHTER")]
        HEAVYFREIGHTER = 7,

        /// <summary>
        /// Enum LIGHTSHUTTLE for value: SHIP_LIGHT_SHUTTLE
        /// </summary>
        [EnumMember(Value = "SHIP_LIGHT_SHUTTLE")]
        LIGHTSHUTTLE = 8,

        /// <summary>
        /// Enum OREHOUND for value: SHIP_ORE_HOUND
        /// </summary>
        [EnumMember(Value = "SHIP_ORE_HOUND")]
        OREHOUND = 9,

        /// <summary>
        /// Enum REFININGFREIGHTER for value: SHIP_REFINING_FREIGHTER
        /// </summary>
        [EnumMember(Value = "SHIP_REFINING_FREIGHTER")]
        REFININGFREIGHTER = 10

    }

}