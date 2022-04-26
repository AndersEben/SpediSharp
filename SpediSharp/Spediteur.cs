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
                result = JsonConvert.DeserializeObject<t_Spieler>(response.Result);

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
                result = JsonConvert.DeserializeObject<t_Spieler>(response.Result);

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
                result = JsonConvert.DeserializeObject<List<t_Routen>>(response.Result);

            return result;
        }

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
                result = JsonConvert.DeserializeObject<List<t_Fahrzeuge>>(response.Result);

            return result;
        }

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
    }
}
