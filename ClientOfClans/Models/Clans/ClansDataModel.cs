﻿using Newtonsoft.Json;

namespace ClientOfClans.Models.Clans
{
    internal struct ClansDataModel
    {
        [JsonProperty("items")]
        public ClanDataModel[] Items { get; set; }

        [JsonProperty("paging")]
        public Paging Paging { get; set; }
    }
}
