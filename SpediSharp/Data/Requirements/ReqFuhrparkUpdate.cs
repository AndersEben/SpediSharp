using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqFuhrparkUpdate : Req<ReqFuhrparkUpdate>
    {
        private bool fuhrparkupdate { get; set; }
        public t_Fahrzeuge fahrzeug { get; internal set; }

        public ReqFuhrparkUpdate(t_Fahrzeuge fahrzeug)
        {
            this.fuhrparkupdate = true;
            this.fahrzeug = fahrzeug;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
