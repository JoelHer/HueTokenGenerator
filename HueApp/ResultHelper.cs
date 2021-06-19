using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace HueApp
{
    public partial class ResultHelper
    {
        [JsonProperty("success")]
        public Success Success { get; set; }
    }

    public partial class Success
    {
        [JsonProperty("username")]
        public string Username { get; set; }
    }

    public partial class ResultHelper
    {
        public static ResultHelper[] FromJson(string json) => JsonConvert.DeserializeObject<ResultHelper[]>(json, Converter.Settings);
    }

    public static class Serialize
    {
        public static string ToJson(this ResultHelper[] self) => JsonConvert.SerializeObject(self, Converter.Settings);
    }

    public class Converter
    {
        public static readonly JsonSerializerSettings Settings = new JsonSerializerSettings
        {
            MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
            DateParseHandling = DateParseHandling.None,
        };
    }
}
