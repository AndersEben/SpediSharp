using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqUserInsert : Req<ReqUserInsert>
    {
        private bool userinsert { get; set; }
        public t_Spieler player { get; internal set; }
        public ReqUserInsert(t_Spieler player)
        {
            this.player = player;
            this.userinsert = true;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
