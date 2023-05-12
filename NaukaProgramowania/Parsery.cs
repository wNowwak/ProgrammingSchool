using System;
using System.Globalization;

namespace NaukaProgramowania
{
    internal static class Parsery
    {
        public static int ParsujDoInta(this string x)
        {
            int.TryParse(x, out int result);
            return result;
        }

        public static decimal ParsujDoDecimala(string x)
        {
            decimal.TryParse(x.Replace(",","."), NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture,
                out decimal result);
            return result;
        }

        public static DateTime ParsujDate(string x)
        {
            DateTime.TryParseExact(x, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None,  out DateTime result);
            return result;
        }


    }
}
