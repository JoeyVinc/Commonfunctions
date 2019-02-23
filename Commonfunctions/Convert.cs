using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonfunctions.Convert
{
    public static class DateNTime
    {
        /// <summary>
        /// convert a DateTime value into ISO8016
        /// </summary>
        /// <param name="value">Datetime value to convert</param>
        /// <returns>Return an ISO8016 formated value as string</returns>
        /// 
        public static string ConvertDateTimeToISO8016(System.DateTime value)
        {
            return value.ToString("yyyy-MM-ddTHH:mm:ss") + ".0000000";
        }
    }
}
