using System;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkCheckRuleFixText
    {
        [JsonProperty("@fixref")] public String FixRef { get; set; }
        [JsonProperty("#text")] public String Text { get; set; }

    }
}