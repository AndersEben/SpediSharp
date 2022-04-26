using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Routen : t_Result
    {
        [JsonProperty]
        public int R_ID { get; internal set; }
        [JsonProperty]
        public string Route { get; internal set; }
        [JsonProperty]
        public int Distanz { get; internal set; }
    }
}
