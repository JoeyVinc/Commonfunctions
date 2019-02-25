using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonfunctions.Logging
{
    public static class Output
    {
        public static void Print(string value, bool linebreak = false, bool logEnabled = false)
        {
#if DEBUG
            logEnabled = true;
#endif
            if (logEnabled)
            {
                if (linebreak)
                    Console.WriteLine(value);
                else
                    Console.Write(value);
            }
        }

        public static void PrintLn(string value, bool logEnabled = false)
        {
            Print(value, true, logEnabled);
        }
    }
}
