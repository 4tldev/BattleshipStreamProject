using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.StaticClasses
{
    public static class IntroToGame
    {
        public static string AppName { get; set; }

        public static void PrintIntro(string name) 
        {
            IntroToGame.AppName = name;
            LawlzUtils.SlowWrite($"Welcome to my game, {AppName.ToUpper()}!");
            Console.WriteLine();

        }

        





    }
}
