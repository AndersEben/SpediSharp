using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    /// <summary>
    /// ReqUserData
    /// </summary>
    public class ReqUserData : Req<ReqUserData>
    {
        public int player_id { get; internal set; }
        private bool userdata { get; set; }

        public ReqUserData(t_Spieler player)
        {
            this.player_id = player.S_ID;
            this.userdata = true;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
