using MarsRover_Console.Enums;

namespace MarsRover.Tests;


public class InputInstructionParseTests
{

    [Test]
    public void ReturnsParsedInstruction_WhenGivenLInstruction()
    {
        string input = "L";

        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(result));
    }

    [Test]
    public void ReturnsParsedInstruction_WhenGivenMInstruction()
    {
        string input = "M";

        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(result));
    }

    [Test]
    public void ReturnsParsedInstruction_WhenGivenRInstruction()
    {
        string input = "R";

        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(result));
    }

    [Test]
    public void ReturnsParsedInstruction_WhenGivenStringInstruction()
    {
        string input = "LMRLL";

        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(result));
    }

    [Test]
    public void ReturnsException_WhenGivenIncorrectStringInstruction()
    {
        string input = "B";

        Assert.Throws<ArgumentException>(() => MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input));
    }
}
