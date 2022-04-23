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

        public ReqUserLogin(string email, string passwort)
        {
            if (email == null || email == "" || passwort == null || passwort == "")
                throw new ArgumentException("Parameter invalid");

            this.userlogin = true;
            this.mail = email;
            this.pass = passwort;
        }


        public string GetString()
        {
            string result = "?";

            bool start = true;

            foreach (var field in typeof(ReqUserLogin).GetProperties())
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
