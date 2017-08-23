using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkCheckRule
    {
        [JsonProperty("@id")]
        public String Id { get; set; }

        [JsonProperty("@severity")]
        public String Severity { get; set; }
        [JsonProperty("@weight")] //TODO
        public String Weight { get; set; }
        public String Version { get; set; }
        public String Title { get; set; }
        public String Description { get; set; }
        public BenchmarkCheckRuleReference Reference { get; set; }

        public BenchmarkCheckRuleFixText FixText { get; set; }
        [JsonConverter(typeof(SingleValueArrayConverter<BenchmarkCheckRuleIdent>))] public List<BenchmarkCheckRuleIdent> Ident { get; set; }

        [JsonConverter(typeof(CheckValueSquisherConverter))] public BenchmarkCheckRuleCheck Check { get; set; }

        public override string ToString()
        {
            return $"[{Id}] {Title}";
        }
    }
}