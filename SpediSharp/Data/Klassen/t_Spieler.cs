using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Spieler : t_Result
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

        public void SetSpieler(string spielername, string mail, string passwort, float bargeld, float kontostand, string standort)
        {
            this.Spielername = spielername;
            this.Mail = mail;
            this.Passwort = passwort;
            this.Bargeld = bargeld;
            this.Kontostand = kontostand;
            this.Startort = standort;
        }

    }
}
