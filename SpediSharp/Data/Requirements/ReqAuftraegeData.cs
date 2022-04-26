using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqAuftraegeData : Req<ReqAuftraegeData>
    {
        private bool auftraege { get; set; }
        public int player_id { get; internal set; }

        public ReqAuftraegeData(int player_id)
        {
            this.auftraege = true;
            this.player_id = player_id;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
