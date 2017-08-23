using System;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkCheckRuleIdent
    {
        [JsonProperty("@system")] public String System { get; set; }

        public override string ToString()
        {
            return $"{nameof(System)}: {System}, {nameof(Text)}: {Text}";
        }

        [JsonProperty("#text")] public String Text { get; set; }

    }
}