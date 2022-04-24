using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    /// <summary>
    /// ReqUserDataUpdate
    /// </summary>
    public class ReqUserDataUpdate : Req<ReqUserDataUpdate>
    {
        private bool userdataupdate { get; set; }
        public t_Spieler player { get; internal set; }

        public ReqUserDataUpdate(t_Spieler player)
        {
            this.player = player;
            this.userdataupdate = true;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }

        /// <summary>
        /// GetPlayer
        /// </summary>
        /// <returns>current set Player</returns>
        public t_Spieler GetPlayer()
        {
            return this.player;
        }
    }
}
