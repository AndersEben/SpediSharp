using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqFuhrparkInsert : Req<ReqFuhrparkInsert>
    {
        private bool fuhrparkinsert { get; set; }
        public t_Fahrzeuge fahrzeug { get; internal set; }

        public ReqFuhrparkInsert(t_Fahrzeuge fahrzeug)
        {
            this.fuhrparkinsert = true;
            this.fahrzeug = fahrzeug;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
