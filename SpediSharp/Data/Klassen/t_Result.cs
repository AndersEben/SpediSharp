using Newtonsoft.Json;
using SpediSharp.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    /// <summary>
    /// t_Results Temp from Server
    /// </summary>
    public class t_Result
    {

        [JsonProperty]
        public JsonType Typ { get; internal set; }
        [JsonProperty]
        public string TypMessage { get; internal set; }

        public void SetTyp(JsonType typ)
        {
            this.Typ = typ;
        }
    }
}
