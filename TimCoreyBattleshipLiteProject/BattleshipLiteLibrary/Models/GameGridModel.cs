using BattleshipLiteLibrary.StaticClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Dynamic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class GameGridModel
    {
        public enum GridPositionState 
        {
            hit,
            miss,
            hidden
        }

        public GridPositionState PositionState { get; set; }
        public int GridXLength { get; set; }
        public int GridYLength { get; set; }
        // public List<GameGridModel> AvailableGridPositions { get; set; } = new List<GameGridModel>();
        public Dictionary<int, GameGridModel> PositionDict { get; set; } = new Dictionary<int, GameGridModel>();
        private int CurrentX { get; set; }
        private int CurrentY { get; set; }
        public string GridValue { get; set; }

        private GameGridModel()
        {

        }

        public GameGridModel(int xLength, int yLength)
        {
            GridXLength = xLength;
            GridYLength = yLength;

            PopulateGrid(GridXLength, GridYLength);
        }

        public void PopulateGrid(int xLength, int yLength) 
        {
            int posDictKey = 0; // using this for key for our PositionDict

            // ASSIGNS X&Y COORDS TO EACH OBJECT IN DICT
            for (int y = 0; y < yLength; y++)
            {
                char yLetter = LawlzUtils.Alphabet[y];

                for (int x = 0; x < xLength; x++)
                {
                    GameGridModel gameGrid = new GameGridModel();
                    gameGrid.CurrentX = x;
                    gameGrid.CurrentY = y;
                    gameGrid.PositionState = GridPositionState.hidden;

                    gameGrid.GridValue = $"{yLetter}{x + 1}";

                    PositionDict.Add(posDictKey, gameGrid);

                    posDictKey++;
                }
            }


            //foreach (var g in this.PositionDict)
            //{
            //    Console.WriteLine($"Pos: {g.Value.GridValue}");
            //    Console.WriteLine($"X: {g.Value.CurrentX}");
            //    Console.WriteLine($"Y: {g.Value.CurrentY}");
            //    Console.WriteLine($"{g.Value.PositionState}");
            //}

        }

        public void DisplayGrid()
        {
            /* Display Format
             * A1, A2, A3, A4, A5,
             * B1, B2, B3, B4, B5,
             * C1, C2, C3, C4, C5,
             * D1, D2, D3, D4, D5,
             * E1, E2, E3, E4, E5, */
            
            int xLength = 0;

            foreach (var dictKey in PositionDict)
            {
                if (xLength < GridXLength)
                {
                    Console.Write($"{dictKey.Value.GridValue}, ");
                }
                else
                {
                    xLength = 0;
                    Console.WriteLine();
                    Console.Write($"{dictKey.Value.GridValue}, ");
                }

                xLength++;
            }


        }



    }
}
