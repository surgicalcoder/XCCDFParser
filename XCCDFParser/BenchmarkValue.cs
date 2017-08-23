using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkValue
    {
        [JsonProperty("@id")]
        public String Id { get; set; }

        [JsonProperty("@type")]
        public String Type { get; set; }

        [JsonProperty("@operator")]
        public String Operator { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }

        [JsonConverter(typeof(BenchmarkValueValuesConverter))]
        public List<BenchmarkValueValues> Value { get; set; }
    }
}