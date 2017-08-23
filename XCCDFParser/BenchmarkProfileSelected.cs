using System;
using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkProfileSelected
    {
        [JsonProperty("@idref")]
        public String Id { get; set; }
        [JsonConverter(typeof(TextBooleanConverter))]
        [JsonProperty("@selected")]
        public bool Selected { get; set; }

        public override string ToString()
        {
            return $"{Id} {nameof(Selected)}: {Selected}";
        }
    }
}