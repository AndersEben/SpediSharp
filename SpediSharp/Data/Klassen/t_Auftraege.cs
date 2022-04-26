using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Klassen
{
    public class t_Auftraege : t_Result
    {
        [JsonProperty]
        public int A_ID { get; internal set; }
        [JsonProperty]
        public string Abhol { get; internal set; }
        [JsonProperty]
        public string Liefer { get; internal set; }
        [JsonProperty]
        public string Bezeichnung { get; internal set; }
        [JsonProperty]
        public float Menge { get; internal set; }
        [JsonProperty]
        public float Wert { get; internal set; }
        [JsonProperty]
        public int Status { get; internal set; }
        [JsonProperty]
        public int Spieler_ID { get; internal set; }
        [JsonProperty]
        public int Fahrzeug_ID { get; internal set; }

        public void SetAuftrag(string abhol, string liefer, string bezeichnung, float menge, float wert, int status, int spieler_id, int fahrzeug_id)
        {
            this.Abhol = abhol;
            this.Liefer = liefer;
            this.Bezeichnung = bezeichnung;
            this.Menge = menge;
            this.Wert = wert;
            this.Status = status;
            this.Spieler_ID = spieler_id;
            this.Fahrzeug_ID = fahrzeug_id;
        }

        public void UpdateAuftrag(string abhol, string liefer, string bezeichnung, float menge, float wert, int status, int spieler_id, int fahrzeug_id)
        {
            this.Abhol = abhol;
            this.Liefer = liefer;
            this.Bezeichnung = bezeichnung;
            this.Menge = menge;
            this.Wert = wert;
            this.Status = status;
            this.Spieler_ID = spieler_id;
            this.Fahrzeug_ID = fahrzeug_id;
        }

        public void SetAuftragsID(int id)
        {
            this.A_ID = id;
        }

    }
}
