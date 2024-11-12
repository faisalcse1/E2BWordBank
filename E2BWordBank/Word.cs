using Newtonsoft.Json;

namespace E2BWordBank
{
    public class Word
    {
        [JsonProperty("pron")]
        public string Pron { get; set; }
        [JsonProperty("bn")]
        public string Bn { get; set; }

        [JsonProperty("en")]
        public string En { get; set; }

        [JsonProperty("bn_syns")]
        public object BnSyns { get; set; }

        [JsonProperty("en_syns")]
        public object EnSyns { get; set; }

        [JsonProperty("sents")]
        public object Sents { get; set; }

        [JsonProperty("details")]
        public string Details { get; set; }
    }
}
