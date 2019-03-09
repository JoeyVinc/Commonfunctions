﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Commonfunctions.Debugging
{
    public static class Output
    {
        public static void Print(string value, bool logEnabled = true, string logFile = null)
        {
#if DEBUG
            logEnabled = true;
#endif
            if (logEnabled)
            {
                if (logFile == null)
                    Console.Write(value);
                else
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(logFile, true);
                    file.AutoFlush = true;
                    file.Write(value);
                    file.Close();
                }
            }
        }

        public static void PrintLn(string value, bool logEnabled = true, string logFile = null)
        {
            Print(value + "\n", logEnabled, logFile);
        }
    }
}
