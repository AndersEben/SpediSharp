using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Orte : t_Result
    {
        [JsonProperty]
        public int O_ID { get; internal set; }
        [JsonProperty]
        public string Ortsname { get; internal set; }

    }
}
