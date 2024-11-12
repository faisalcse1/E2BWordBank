using Newtonsoft.Json;
using System.Collections.Generic;

namespace E2BWordBank
{
    public class Word
    {
        [JsonProperty("pron")]
        public List<string> Pron { get; set; }
        [JsonProperty("bn")]
        public string Bn { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("bn_syns")]
        public List<string> BnSyns { get; set; }

        [JsonProperty("en_syns")]
        public List<string> EnSyns { get; set; }

        [JsonProperty("sents")]
        public List<string> Sents { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }
}
