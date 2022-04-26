using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqAuftraegeInsert : Req<ReqAuftraegeInsert>
    {
        private bool auftraginsert { get; set; }
        public t_Auftraege auftraege { get; internal set; }

        public ReqAuftraegeInsert(t_Auftraege auftrage)
        {
            this.auftraginsert = true;
            this.auftraege = auftraege;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
