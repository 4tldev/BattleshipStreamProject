using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BattleshipLiteLibrary.Models
{
    public class ShipModel
    {

        public int XCoordinate { get; set; }
        public int YCoordinate { get; set; }

        private List<ShipModel> ships = new List<ShipModel>();

        private int NumberOfShips { get; set; }

        public ShipModel(int howManyShips)
        {
            NumberOfShips = howManyShips;
        }

        public void AddShips(int x, int y) 
        {
            XCoordinate = x;
            YCoordinate = y;

            Console.WriteLine();
            ships.Add(this);
        }

        public void ShipPlacementValidator() 
        {
            
        }
    }
}
