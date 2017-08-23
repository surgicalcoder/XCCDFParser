using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace XCCDFParser
{
    public class CheckValueSquisherConverter : JsonConverter
    {
        private class CheckValueSquisherConverterContainerLevel1
        {

        }

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            //JObject deserialize = serializer.Deserialize(reader) as JObject;
            BenchmarkCheckRuleCheck check = new BenchmarkCheckRuleCheck();
            JObject eee = serializer.Deserialize(reader) as JObject;
            if (eee["check-content-ref"] != null)
            {
                check.Name = eee["check-content-ref"]["@name"].Value<string>();
                check.Href = eee["check-content-ref"]["@href"].Value<string>();
            }
            else
            {
                check.Name = eee["@name"].Value<string>();
                check.Href = eee["@href"].Value<string>();
            }

            if (eee["check-content"] != null)
            {
                check.ManualCheckId = eee["@system"].Value<string>();
                check.ManualCheckText = eee["check-content"].Value<string>();
            }

            if (eee["check-export"] != null)
            {
                check.CheckExportVarId = eee["check-export"]["@value-id"].Value<String>();
                check.CheckExportValueId = eee["check-export"]["@export-name"].Value<String>();
            }
            return check;
        }

        public override bool CanWrite => false;
        public override bool CanConvert(Type objectType)
        {
            return true;
        }
    }
}