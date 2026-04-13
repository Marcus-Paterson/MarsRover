using MarsRover_Console.DataClasses;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_Console.ParseInput
{
    internal class InputPlateauSizeParse
    {
        public static PlateauSize ParsePlateauSize(string input)
        {
            string[] splitString = input.Split(' ');
            int positionX = int.Parse(splitString[0]);
            int positionY = int.Parse(splitString[1]);
            PlateauSize plateauSize = new PlateauSize(positionX, positionY);    
            return plateauSize;
        }
    }
}
