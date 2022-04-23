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
    class Spediteur
    {
        public async Task<t_Spieler> GetUserLogin(ReqUserLogin user)
        {
            t_Spieler result = null;

            string url = URLdata.BaseURL + URLdata.UserLogin;

            url += user.GetString();

            var response = await Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            result = JsonConvert.DeserializeObject<t_Spieler>(response);

            return result;
        }
    }
}
