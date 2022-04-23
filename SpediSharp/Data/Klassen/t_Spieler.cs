using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Spieler
    {

        [JsonProperty]
        public int S_ID { get; internal set; }
        [JsonProperty]
        public string Spielername { get; internal set; }
        [JsonProperty]
        public string Mail { get; internal set; }
        [JsonProperty]
        public string Passwort { get; internal set; }
        [JsonProperty]
        public float Bargeld { get; internal set; }
        [JsonProperty]
        public float Kontostand { get; internal set; }
        [JsonProperty]
        public string Startort { get; internal set; }
    }
}
