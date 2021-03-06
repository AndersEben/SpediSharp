using SpediSharp.Data.Klassen;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data.Requirements
{
    /// <summary>
    /// Requirements Class Temp
    /// </summary>
    /// <typeparam name="T">Classname it Transform to</typeparam>
    public class Req<T>
    {
        public string GetString()
        {
            string result = "?";

            bool start = true;

            foreach (var field in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {

                if(field.PropertyType.FullName != typeof(t_Spieler).ToString() && 
                    field.PropertyType.FullName != typeof(t_Fahrzeuge).ToString() &&
                    field.PropertyType.FullName != typeof(t_Auftraege).ToString() &&
                    field.PropertyType.FullName != typeof(t_Orte).ToString() &&
                    field.PropertyType.FullName != typeof(t_Routen).ToString() &&
                    field.PropertyType.FullName != typeof(t_Spieler_Score).ToString() &&
                    field.PropertyType.FullName != typeof(t_Waren).ToString())
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
            }

            return result;
        }

        public bool CheckProp()
        {
            foreach (var prop in typeof(T).GetProperties(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic | System.Reflection.BindingFlags.Instance))
            {
                if (prop.GetValue(this) == null || prop.GetValue(this).ToString() == "")
                    return false;
            }

            return true;
        }
    }
}
