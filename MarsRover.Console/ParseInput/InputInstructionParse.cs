using MarsRover_Console.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_Console.ParseInput
{
    public class InputInstructionParse
    {
        public static List<Instruction> ParseInstructions(string input)
        {
            List<Instruction> instructions = new List<Instruction>();

            foreach (char i in input)
            {
                Instruction instruction = (Instruction)Enum.Parse(typeof(Instruction), i.ToString());
                instructions.Add(instruction);
            }

            if(input.Contains("L") || input.Contains("R") || input.Contains("M"))
            {
                return instructions;
            }
            else
            {
                throw new Exception("Invalid instruction. Please enter a valid instruction (L, R, M).");
            }
        }

    }

}


