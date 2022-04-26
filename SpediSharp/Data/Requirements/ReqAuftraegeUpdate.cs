using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqAuftraegeUpdate : Req<ReqAuftraegeUpdate>
    {
        private bool auftraegeupdate { get; set; }
        public t_Auftraege auftrag { get; internal set; }

        public ReqAuftraegeUpdate(t_Auftraege auftrag)
        {
            this.auftraegeupdate = true;
            this.auftrag = auftrag;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
