using System;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkCheckRuleReference
    {
        [JsonProperty("dc:title")]
        public String Title { get; set; }
        [JsonProperty("dc:publisher")]
        public String Publisher { get; set; }
        [JsonProperty("dc:type")]
        public String Type { get; set; }
        [JsonProperty("dc:subject")]
        public String Subject { get; set; }
        [JsonProperty("dc:identifier")]
        public String Identifier { get; set; }

    }
}