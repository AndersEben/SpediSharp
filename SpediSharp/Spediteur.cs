using Newtonsoft.Json;
using SpediSharp.Data;
using SpediSharp.Data.Klassen;
using SpediSharp.Data.Requirements;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SpediSharp
{
    public class Spediteur
    {
        public t_Spieler GetUserLogin(ReqUserLogin user)
        {
            t_Spieler result = null;

            string url = URLdata.BaseURL + URLdata.UserLogin;

            url += user.GetString();

            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");
            var waiter = response.Wait(new TimeSpan(0,0,5));

            if(waiter)
                result = JsonConvert.DeserializeObject<t_Spieler>(response.Result);

            return result;
        }
    }
}
