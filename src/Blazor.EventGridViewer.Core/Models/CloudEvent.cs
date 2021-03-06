﻿using Newtonsoft.Json;

namespace Blazor.EventGridViewer.Core.Models
{
    // Reference: https://github.com/cloudevents/spec/blob/v1.0/spec.md#example
    public class CloudEvent
    {
        [JsonProperty("specversion")]
        public string SpecVersion { get; set; }

        [JsonProperty("type")]
        public string Type { get; set; }

        [JsonProperty("source")]
        public string Source { get; set; }

        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("time")]
        public string Time { get; set; }

        [JsonProperty("data")]
        public object Data { get; set; }
    }
}
