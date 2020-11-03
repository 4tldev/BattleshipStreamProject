using System;
using System.Collections.Generic;
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
        public int GridXLength { get; set; }
        public int GridYLength { get; set; }
        public List<GameGridModel> AvailableGridPositions { get; set; } = new List<GameGridModel>();
        public Dictionary<int, GameGridModel> PositionDict { get; set; } = new Dictionary<int, GameGridModel>();
        private int CurrentX { get; set; }
        private int CurrentY { get; set; }

        private GameGridModel()
        {

        }

        public GameGridModel(int xLength, int yLength)
        {
            PopulateGrid(xLength, yLength);
        }

        public void PopulateGrid(int xLength, int yLength) 
        {
            int dictIndexer = 0; // using this for key for our PositionDict
            int x = 0;
            
            for (; x < xLength; x++)
            {
                this.CurrentX = x;
                for (int y = 0; y < yLength; y++)
                {
                    GameGridModel gameGrid = new GameGridModel();
                    gameGrid.CurrentX = x;
                    gameGrid.CurrentY = y;
                    this.CurrentY = y;
                    
                    this.AvailableGridPositions.Add(gameGrid);
                    this.PositionDict.Add(dictIndexer, gameGrid);

                    dictIndexer++;
                }
            }

            //Method for testing values in PositionDict

            foreach (KeyValuePair<int, GameGridModel> g in this.PositionDict)
            {
                Console.WriteLine($"Key: {g.Key}");
                Console.WriteLine($"X: {g.Value.CurrentX}");
                Console.WriteLine($"Y: {g.Value.CurrentY}");
            }

        }

        public void DisplayGrid() 
        {
            //Find out how many items are in our List/Dict
            //Find out number of rows YLength
            //Find out number of Columns XLength
            /* Display Format
             * A1, A2, A3, A4, A5,
             * B1, B2, B3, B4, B5,
             * C1, C2, C3, C4, C5,
             * D1, D2, D3, D4, D5,
             * E1, E2, E3, E4, E5, */







        }
    }
}
