using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Spieler_Score : t_Result
    {
        [JsonProperty]
        public string Spielername { get; internal set; }
        [JsonProperty]
        public float Bargeld { get; internal set; }
        [JsonProperty]
        public float Kontostand { get; internal set; }
    }
}
