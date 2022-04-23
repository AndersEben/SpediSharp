using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    public class ReqUserLogin
    {
        public string mail { get; internal set; }
        public string pass { get; internal set; }

        public bool userlogin { get; internal set; }

        public ReqUserLogin(string mail, string passwort)
        {
            this.userlogin = true;
            this.mail = mail;
            this.pass = passwort;
        }

        public string GetString()
        {
            string result = "?";

            bool start = true;

            foreach (var field in typeof(ReqUserLogin).GetFields())
            {
                if (field.GetValue(this) != null)
                {

                    if (!start)
                        result += "&";

                    result += field.Name + "=" + field.GetValue(this);

                    if (start)
                        start = !start;
                }
            }

            return result;
        }
    }
}
