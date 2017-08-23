using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkProfile
    {
        [JsonProperty("@id")]
        public String Id { get; set; }
        public String Title { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Title}";
        }

        public String Description { get; set; }
        public List<BenchmarkProfileSelected> Select { get; set; }
    }
}