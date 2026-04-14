using MarsRover_Console.ParseInput;
using MarsRover_Console.Parsers;

namespace MarsRover_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Console.WriteLine("Enter the plateau size (This should be 5 5):");
            string userPlateauSizeInput = Console.ReadLine();
            InputPlateauSizeParse.ParsePlateauSize(userPlateauSizeInput);


            Console.WriteLine("Enter the rover's initial position and direction. Do this by entering two numbers under or equal to 5 and a direction(N,E,S or W) seperate everything with a space, e.g. 1 2 N):");
            string userRoverPositionInput = Console.ReadLine();
            InputRoverParse.ParseStartingPosition(userRoverPositionInput);

            Console.WriteLine("Enter the instructions for the rover. You must use L, R or M. Enter your instructions with no space, e.g. LMRMMRML):");
            string userInstructionInput = Console.ReadLine();
            InputInstructionParse.ParseInstructions(userInstructionInput);


            try 
            {
                InputInstructionParse.ParseInstructions(" ");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
