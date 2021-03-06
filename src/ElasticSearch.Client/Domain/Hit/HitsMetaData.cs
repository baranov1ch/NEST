﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace ElasticSearch.Client
{
    [JsonObject]
    public class HitsMetaData<T> where T : class
    {
        [JsonProperty("total")]
        public int Total { get; internal set; }

        [JsonProperty("max_score")]
        public double MaxScore { get; internal set; }

        [JsonProperty("hits")]
        public List<Hit<T>> Hits { get; internal set; }
    }
}
