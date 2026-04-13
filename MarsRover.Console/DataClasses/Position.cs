using MarsRover_Console.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_Console.DataClasses
{
    public class Position
    {
        public int X { get; }
        public int Y { get; }
        public CompassDirection DirectionFacing { get; }

        public Position(int x, int y, CompassDirection directionFacing)
        {
            X = x;
            Y = y;
            DirectionFacing = directionFacing;
        }
    }
}