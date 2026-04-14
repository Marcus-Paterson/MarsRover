using MarsRover_Console.Enums;

namespace MarsRover.Tests;


public class InputInstructionParseTests
{

    [Test]
    public void ReturnsParsedInstruction_WhenGivenLInstruction()
    {
        string input = "L";
        var expected = new List<Instruction>
        {
            Instruction.L
        };
        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ReturnsParsedInstruction_WhenGivenMInstruction()
    {
        string input = "M";
        var expected = new List<Instruction>
        {
            Instruction.M
        };
        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ReturnsParsedInstruction_WhenGivenRInstruction()
    {
        string input = "R";
        var expected = new List<Instruction>
        { 
            Instruction.R
        };

        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ReturnsParsedInstruction_WhenGivenStringInstruction()
    {
        string input = "LMRLL";
        var expected = new List<Instruction>
    {
        Instruction.L,
        Instruction.M,
        Instruction.R,
        Instruction.L,
        Instruction.L
    };

        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(expected));
    }

    [Test]
    public void ReturnsException_WhenGivenIncorrectStringInstruction()
    {
        string input = "B";

        Assert.Throws<ArgumentException>(() => MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input));
    }
}
