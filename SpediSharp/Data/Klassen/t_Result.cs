﻿using Newtonsoft.Json;
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
        public string type { get; internal set; }
        [JsonProperty]
        public string result { get; internal set; }
    }
}