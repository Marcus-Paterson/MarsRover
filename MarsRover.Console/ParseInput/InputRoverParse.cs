using MarsRover_Console.DataClasses;
using MarsRover_Console.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_Console.Parsers
{
    public class InputRoverParse
    {
        public static RoverPosition ParseStartingPosition(string input)
        {
            // "5 5 N"
            string[] splitString = input.Split(' '); 
            int positionX = int.Parse(splitString[0]);
            int positionY = int.Parse(splitString[1]);
            CompassDirection positionDirection = (CompassDirection)Enum.Parse(typeof,splitString[2]); 

            RoverPosition roverPosition = new RoverPosition(positionX, positionY, positionDirection);

            return roverPosition;
        }


    }
}
