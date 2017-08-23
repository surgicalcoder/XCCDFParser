using System;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkCheckRuleCheck
    {
        [JsonProperty("@name")]
        public String Name { get; set; }
        [JsonProperty("@href")]
        public String Href { get; set; }

        public String ManualCheckText { get; set; }
        public String ManualCheckId { get; set; }

        public String CheckExportValueId { get; set; }
        public String CheckExportVarId { get; set; }

        public override string ToString()
        {
            return $"{nameof(Name)}: {Name}, {nameof(Href)}: {Href}";
        }
    }
}