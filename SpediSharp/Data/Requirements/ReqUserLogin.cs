using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    /// <summary>
    /// ReqUserLogin
    /// </summary>
    public class ReqUserLogin : Req<ReqUserLogin>
    {
        public string mail { get; internal set; }
        public string pass { get; internal set; }
        public bool userlogin { get; internal set; }

        public ReqUserLogin(string email, string passwort)
        {
            this.userlogin = true;
            this.mail = email;
            this.pass = passwort;

            if (!CheckProp())
                throw new ArgumentNullException("Parameter invalid");
        }
    }
}
