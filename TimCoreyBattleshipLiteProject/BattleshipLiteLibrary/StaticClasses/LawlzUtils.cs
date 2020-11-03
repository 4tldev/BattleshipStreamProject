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

        public static int WindowWidth = 75;
        public static int WindowHeight = 250;

        public static string Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

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
