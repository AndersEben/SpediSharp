using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Fahrzeuge : t_Result
    {
        [JsonProperty]
        public int F_ID { get; internal set; }
        [JsonProperty]
        public string Bezeichnung { get; internal set; }
        [JsonProperty]
        public int Spieler_ID { get; internal set; }
        [JsonProperty]
        public bool IsGekauft { get; internal set; }
        [JsonProperty]
        public string ErwerbDatum { get; internal set; }
        [JsonProperty]
        public string Abgabedatum { get; internal set; }
        [JsonProperty]
        public string Standort { get; internal set; }
        [JsonProperty]
        public bool HatAuftrag { get; internal set; }
        [JsonProperty]
        public int Auftragsnummer { get; internal set; }

        public void SetFahrzeug(int f_id, string bezeichnung, int s_id, bool gekauft, string erwerb, string abgabe, string standort, bool hatauftrag, int auftragsnummer)
        {
            this.F_ID = f_id;
            this.Bezeichnung = bezeichnung;
            this.Spieler_ID = s_id;
            this.IsGekauft = gekauft;
            this.ErwerbDatum = erwerb;
            this.Abgabedatum = abgabe;
            this.Standort = standort;
            this.HatAuftrag = hatauftrag;
            this.Auftragsnummer = auftragsnummer;
        }

        public void DeleteAuftrag(string standort)
        {
            this.Standort = standort;
            this.HatAuftrag = false;
            this.Auftragsnummer = 0;
        }
    }
}
