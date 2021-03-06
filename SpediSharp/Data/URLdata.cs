using System;
using System.Collections.Generic;
using System.Text;

namespace SpediSharp.Data
{
    /// <summary>
    /// URL Strings for Requests
    /// </summary>
    class URLdata
    {
        public static string BaseURL { get; } = "https://www.gaming.anderseben.de/";
        public static string User { get; } = "api/user";
        public static string UserUpdate { get; } = "api/user/index.php";
        public static string UserInsert { get; } = "api/user/userinsert/index.php";
        public static string Fahrzeuge { get; } = "api/fahrzeuge";
        public static string FahrzeugeInsert { get; } = "api/fahrzeuge/fahrzeuginsert/index.php";
        public static string Routen { get; } = "api/routen";
        public static string Waren { get; } = "api/waren";
        public static string WarenInsert { get; } = "api/waren/wareninsert/index.php";
        public static string Orte { get; } = "api/orte";
        public static string Auftraege { get; } = "api/auftraege";
        public static string AuftraegeUpdate { get; } = "api/auftraege/index.php";
        public static string AuftraegeInsert { get; } = "api/auftraege/auftraegeinsert/index.php";
    }
}
