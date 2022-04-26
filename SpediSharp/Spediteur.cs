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
    /// <summary>
    /// Spediteur Class
    /// </summary>
    public class Spediteur
    {
        
        #region User

        /// <summary>
        /// GetUser returns the Player with posted Mail and Pass
        /// </summary>
        /// <param name="user">Required User Parameter</param>
        /// <returns>recieved t_Spieler or null</returns>
        public t_Spieler GetUser(ReqUserLogin user)
        {
            t_Spieler result = null;

            string url = URLdata.BaseURL + URLdata.User;

            url += user.GetString();

            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Spieler>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// GetAllUser for Score
        /// </summary>
        /// <returns>t_Spieler_Score als kleiner alternative zum Spieler</returns>
        public List<t_Spieler_Score> GetAllUser()
        {
            List<t_Spieler_Score> result = null;

            string url = URLdata.BaseURL + URLdata.User +"?alluser";
            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<List<t_Spieler_Score>>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// GetUserData after S_ID
        /// </summary>
        /// <param name="user">Required User Parameter</param>
        /// <returns>recieved t_Spieler or null</returns>
        public t_Spieler GetUserData(ReqUserData user)
        {
            t_Spieler result = null;

            string url = URLdata.BaseURL + URLdata.User;

            url += user.GetString();

            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Spieler>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// UpdateUserData after S_ID will update Kontostand and Bargeld
        /// </summary>
        /// <param name="user">Required User Parameter</param>
        /// <returns>recieved t_Spieler or null</returns>
        public t_Spieler UpdateUserData(ReqUserDataUpdate user)
        {
            t_Spieler result = null;

            string url = URLdata.BaseURL + URLdata.UserUpdate;

            url += user.GetString();

            string data = JsonConvert.SerializeObject(user.player);
            var response = Functions.POSTRequest(url,data);

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Spieler>(response.Result);
                }
                catch (Exception)
                {
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// InsertUser will Register a new User
        /// </summary>
        /// <param name="user">Required User Parameter</param>
        /// <returns>recieved t_Spieler or null</returns>
        public t_Spieler InsertUser(ReqUserInsert user)
        {
            t_Spieler result = null;

            string url = URLdata.BaseURL + URLdata.UserInsert;

            url += user.GetString();

            string data = JsonConvert.SerializeObject(user.player);
            var response = Functions.POSTRequest(url, data);

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Spieler>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        #endregion

        #region Auftraege

        /// <summary>
        /// GetAuftraege gibt alle verfügbaren Auftraege für den Spieler wieder
        /// </summary>
        /// <param name="req">ReqAuftraegeData mit Spieler_ID</param>
        /// <returns>List<t_Auftraege> oder null</returns>
        public List<t_Auftraege> GetAuftraege(ReqAuftraegeData req)
        {
            List<t_Auftraege> result = null;

            string url = URLdata.BaseURL + URLdata.Auftraege;

            url += req.GetString();

            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<List<t_Auftraege>>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// UpdateAuftraege Aktualisiert einen Auftrag nach der Auftrags_ID
        /// </summary>
        /// <param name="req">ReqAuftraegeUpdate mit Auftrags_ID</param>
        /// <returns>t_Auftraege oder null</returns>
        public t_Auftraege UpdateAuftraege(ReqAuftraegeUpdate req)
        {
            t_Auftraege result = null;

            string url = URLdata.BaseURL + URLdata.AuftraegeUpdate;

            url += req.GetString();

            string data = JsonConvert.SerializeObject(req.auftrag);
            var response = Functions.POSTRequest(url, data);

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Auftraege>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// InsertAuftraege legt einen Neuen Auftrag an
        /// </summary>
        /// <param name="req">ReqAuftraegeInsert mit den Auftragsdaten</param>
        /// <returns>t_Auftraege oder null</returns>
        public t_Auftraege InsertAuftraege(ReqAuftraegeInsert req)
        {
            t_Auftraege result = null;

            string url = URLdata.BaseURL + URLdata.AuftraegeInsert;

            url += req.GetString();

            string data = JsonConvert.SerializeObject(req.auftraege);
            var response = Functions.POSTRequest(url, data);

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Auftraege>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }
        #endregion

        #region Waren

        /// <summary>
        /// GetWaren holt alle verfügbaren Waren aus der Datenbank
        /// </summary>
        /// <returns>List<t_Waren> oder null</returns>
        public List<t_Waren> GetWaren()
        {
            List<t_Waren> result = null;

            string url = URLdata.BaseURL + URLdata.Waren + "?waren";
            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<List<t_Waren>>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// InsertWaren legt eine neue Waren an
        /// </summary>
        /// <param name="req">ReqWarenInsert mit den Warendaten</param>
        /// <returns>t_Waren oder null</returns>
        public t_Waren InsertWaren(ReqWarenInsert req)
        {

            t_Waren result = null;

            string url = URLdata.BaseURL + URLdata.WarenInsert;

            url += req.GetString();

            string data = JsonConvert.SerializeObject(req.ware);
            var response = Functions.POSTRequest(url, data);

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Waren>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        #endregion

        #region Orte

        /// <summary>
        /// GetOrte holt alle verfügbaren Orte aus der Datenbank
        /// </summary>
        /// <returns>List<t_Orte> oder null</returns>
        public List<t_Orte> GetOrte()
        {
            List<t_Orte> result = null;

            string url = URLdata.BaseURL + URLdata.Orte + "?orte";
            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<List<t_Orte>>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        #endregion

        #region Routen

        /// <summary>
        /// GetRouten holt alle verfügbaren Routen aus der Datenbank
        /// </summary>
        /// <returns>List<t_Routen> oder null</returns>
        public List<t_Routen> GetRouten()
        {
            List<t_Routen> result = null;

            string url = URLdata.BaseURL + URLdata.Routen + "?routen";
            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<List<t_Routen>>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        #endregion

        #region Fahrzeuge

        /// <summary>
        /// GetFuhrpark holt alle dem Spieler zu verfügung stehenden Fahrzeuge aus der Datenbank
        /// </summary>
        /// <param name="req">ReqFuhrparkData mit Spieler_ID</param>
        /// <returns>List<t_Fahrzeuge> oder null</returns>
        public List<t_Fahrzeuge> GetFuhrpark(ReqFuhrparkData req)
        {
            List<t_Fahrzeuge> result = null;

            string url = URLdata.BaseURL + URLdata.Fahrzeuge;

            url += req.GetString();

            var response = Functions.GETRequest(url, "", Options.TokenType.Bearer, "");

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<List<t_Fahrzeuge>>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;
        }

        /// <summary>
        /// UpdateFuhrpark aktualisiert ein Fahrzeug anhand der Fahrzeug_ID
        /// </summary>
        /// <param name="req">ReqFuhrparkUpdate</param>
        /// <returns>t_Fahrzeuge oder null</returns>
        public t_Fahrzeuge UpdateFuhrpark(ReqFuhrparkUpdate req)
        {

            t_Fahrzeuge result = null;

            string url = URLdata.BaseURL + URLdata.FahrzeugeInsert;

            url += req.GetString();

            string data = JsonConvert.SerializeObject(req.fahrzeug);
            var response = Functions.POSTRequest(url, data);

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Fahrzeuge>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        /// <summary>
        /// InsertFuhrpark legt ein neues Fahrzeug an
        /// </summary>
        /// <param name="req">ReqFuhrparkInsert</param>
        /// <returns>t_Fahrzeuge oder null</returns>
        public t_Fahrzeuge InsertFuhrpark(ReqFuhrparkInsert req)
        {

            t_Fahrzeuge result = null;

            string url = URLdata.BaseURL + URLdata.FahrzeugeInsert;

            url += req.GetString();

            string data = JsonConvert.SerializeObject(req.fahrzeug);
            var response = Functions.POSTRequest(url, data);

            bool waiter = false;

            try
            {
                waiter = response.Wait(new TimeSpan(0, 0, 5));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                waiter = false;
            }

            if (waiter)
            {
                try
                {
                    result = JsonConvert.DeserializeObject<t_Fahrzeuge>(response.Result);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    result = null;
                }
            }

            return result;

        }

        #endregion
    
    }
}
