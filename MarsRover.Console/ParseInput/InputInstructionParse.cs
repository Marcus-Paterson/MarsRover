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
            List<Instruction> listOfInstructions = new List<Instruction>();

            foreach (char i in input)
            {
                if(i is 'L' || i is 'R' || i is 'M')
                {
                    Instruction instruction = (Instruction)Enum.Parse(typeof(Instruction), i.ToString());
                    listOfInstructions.Add(instruction);
                }
                
            }

            if(listOfInstructions.Count != 0)
            {
                return listOfInstructions;
            }
            else
            {
                throw new ArgumentException("Invalid instruction. Please enter a valid instruction (L, R, M).");
            }
        }

    }

}


