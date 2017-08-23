using Newtonsoft.Json;

namespace XCCDFParser
{
    public class BenchmarkValueValues
    {
        [JsonProperty("@selector")]
        public string Selector { get; set; }
        [JsonProperty("#text")]
        public string Text { get; set; }

        public bool DefaultValue { get; set; }
    }
}