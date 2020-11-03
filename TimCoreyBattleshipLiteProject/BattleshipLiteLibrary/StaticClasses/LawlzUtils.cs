using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.StaticClasses
{
    public static class LawlzUtils
    {



        // Prints to the council one character at a time
        public static void SlowWrite(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(100);
            }
        }
    }
}
