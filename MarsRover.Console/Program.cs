using MarsRover_Console.DataClasses;
using MarsRover_Console.ParseInput;
using MarsRover_Console.Parsers;

namespace MarsRover_Console
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


/*            Console.WriteLine("Enter the plateau size (This should be 5 5):");
            string userPlateauSizeInput = Console.ReadLine();*/
            var plateauSize = InputPlateauSizeParse.ParsePlateauSize("5 5");


/*            Console.WriteLine("Enter the rover's initial position and direction. Do this by entering two numbers under or equal to 5 and a direction(N,E,S or W) seperate everything with a space, e.g. 1 2 N):");
            string userRoverPositionInput = Console.ReadLine();*/
            var roverPosition = InputRoverParse.ParseStartingPosition("1 2 N");

            try 
            {
/*                Console.WriteLine("Enter the instructions for the rover. You must use L, R or M. Enter your instructions with no space, e.g. LMRMMRML):");
                string userInstructionInput = Console.ReadLine();*/
                InputInstructionParse.ParseInstructions("LMLMMLLMMMR");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Plateau size: " + plateauSize.X + " " + plateauSize.Y);
            Console.WriteLine($"Rover starting position is: X: {roverPosition.X}, Y: {roverPosition.Y}, DirectionFacing: {roverPosition.DirectionFacing}");
            Console.WriteLine("Instructions: ");
            foreach (var instruction in InputInstructionParse.ParseInstructions("LMLMMLLMMMR"))
            {
                Console.Write(instruction);
            }

        }
    }
}
