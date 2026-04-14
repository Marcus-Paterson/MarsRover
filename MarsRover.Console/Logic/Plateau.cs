using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_Console.Logic
{
    public class Plateau(int width, int height)
    {
        public int Width { get; } = width;
        public int Height { get; } = height;

        public bool IsInsidePlateau(int x, int y)
        {
            return x >= 0 && x <= Width && y >= 0 && y <= Height;
        }
    }
}
