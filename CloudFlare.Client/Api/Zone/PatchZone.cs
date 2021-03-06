﻿using System.Collections.Generic;
using System.Runtime.Serialization;
using CloudFlare.Client.Models;
using Newtonsoft.Json;

namespace CloudFlare.Client.Api.Zone
{
    public class PatchZone
    {
        /// <summary>
        /// <see cref="Models.Zone.Paused"/>
        /// </summary>
        [JsonProperty("paused", NullValueHandling = NullValueHandling.Ignore)]
        public bool Paused { get; set; }

        /// <summary>
        /// An array of domains used for custom name servers. This is only available for Business and Enterprise plans.
        /// </summary>
        [JsonProperty("vanity_name_servers", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false)]
        public IEnumerable<string> VanityNameServers { get; set; }

        /// <summary>
        /// <see cref="Models.Zone.Plan"/>
        /// </summary>
        [JsonProperty("plan", NullValueHandling = NullValueHandling.Ignore)]
        [DataMember(EmitDefaultValue = false)]
        public Plan Plan { get; set; }
    }
}