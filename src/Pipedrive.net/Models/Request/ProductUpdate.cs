﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace Pipedrive.Models.Request
{
    public class ProductUpdate
    {
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("unit")]
        public string Unit { get; set; }
        [JsonProperty("tax")]
        public decimal Tax { get; set; }
        [JsonProperty("active_flag")]
        public bool Active { get; set; } = true;
        [JsonProperty("visible_to")]
        public Visibility VisibleTo { get; set; }
        [JsonProperty("owner_id")]
        public long OwnerId { get; set; }
        [JsonProperty("prices", NullValueHandling = NullValueHandling.Ignore)]
        public List<NewProductPrice> Prices { get; set; }
    }
}
