using System;
using System.Collections.Generic;

namespace XCCDFParser
{
    public class Benchmark
    {
        public String Title { get; set; }

        public override string ToString()
        {
            return $"{nameof(Title)}: {Title}, {nameof(Description)}: {nameof(Version)}: {Version}";
        }

        public String Description { get; set; }
        public String Version { get; set; }
        public List<BenchmarkProfile> Profile { get; set; }
        public List<BenchmarkCheck> Group { get; set; }
        public List<BenchmarkValue> Value { get; set; }
    }
}
