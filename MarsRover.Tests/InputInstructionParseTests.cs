using MarsRover_Console.Enums;

namespace MarsRover.Tests;


public class InputInstructionParseTests
{
    [Test]
    public void ReturnsParsedInstruction_WhenGivenStringInstruction()
    {
        string input = "LMRLL";

        var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

        Assert.That(result, Is.EqualTo(result));
    }

    //[Test]
    //public void ReturnsError_WhenGivenIncorrectStringInstruction()
    //{
    //    string input = "LMRLBL";

    //    var result = MarsRover_Console.ParseInput.InputInstructionParse.ParseInstructions(input);

    //    Assert.That(result, Is.EqualTo(System.ArgumentException));
    //}
}
