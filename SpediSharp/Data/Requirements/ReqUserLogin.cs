using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqUserLogin : Req<ReqUserLogin>
    {
        public string mail { get; internal set; }
        public string pass { get; internal set; }
        private bool userlogin { get; set; }

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
