using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XCCDFParser
{
    public class BenchmarkValueValuesConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer) { throw new NotImplementedException(); }
        public override bool CanConvert(Type objectType) { return true; }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            List<BenchmarkValueValues> retr = new List<BenchmarkValueValues>();
            var eee = serializer.Deserialize(reader) as JArray;
            foreach (var va in eee)
            {
                if (va is JValue jv)
                {
                    retr.Add(new BenchmarkValueValues() { DefaultValue = true, Selector = jv.Value.ToString() });
                }
                else if (va is JObject jo)
                {
                    retr.Add(new BenchmarkValueValues() { DefaultValue = false, Selector = jo["@selector"].ToString(), Text = jo["#text"].ToString() });
                }
            }

            return retr;
        }


    }
}