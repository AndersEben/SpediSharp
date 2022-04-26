using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqFuhrparkData : Req<ReqFuhrparkData>
    {
        private bool fuhrpark { get; set; }
        public int spieler_id { get; internal set; }

        public ReqFuhrparkData(int spieler_id)
        {
            this.fuhrpark = true;
            this.spieler_id = spieler_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
