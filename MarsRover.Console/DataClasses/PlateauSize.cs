using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_Console.DataClasses
{
    public class PlateauSize
    {
        public int X { get; }
        public int Y { get; }


        public PlateauSize(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
