using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Waren : t_Result
    {
        [JsonProperty]
        public int Ware_ID { get; internal set; }
        [JsonProperty]
        public string W_Bezeichnung { get; internal set; }
        [JsonProperty]
        public int W_Verladung { get; internal set; }
        [JsonProperty]
        public float W_Preis { get; internal set; }
        [JsonProperty]
        public int W_Einheit { get; internal set; }
        [JsonProperty]
        public int W_Merkmal { get; internal set; }


        public void SetWare(string bezeichnung, int verladung, float preis, int einheit, int merkmal)
        {
            this.W_Bezeichnung = bezeichnung;
            this.W_Verladung = verladung;
            this.W_Preis = preis;
            this.W_Einheit = einheit;
            this.W_Merkmal = merkmal;
        }
    }
}
