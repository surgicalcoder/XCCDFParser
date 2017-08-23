using System;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkCheck
    {
        [JsonProperty("@id")]
        public String Id { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Title}";
        }

        public BenchmarkCheckRule Rule { get; set; }
    }
}