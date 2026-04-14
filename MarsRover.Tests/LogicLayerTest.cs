using MarsRover_Console.Enums;
using MarsRover_Console.Logic;

namespace MarsRover.Tests;


public class LogicLayerTest
{
    [Test]
    public void ShouldRotateLeft_WhenGivenLInstruction_FromNorthToWest()
    {
        var rover = new Rover(0, 0, CompassDirection.N);
        
        rover.RotateLeft();

        Assert.That(rover.DirectionFacing, Is.EqualTo(CompassDirection.W));
    }

    [Test]
    public void ShouldRotateRight_WhenGivenLInstruction_FromNorthToEast()
    {
        var rover = new Rover(0, 0, CompassDirection.N);

        rover.RotateRight();

        Assert.That(rover.DirectionFacing, Is.EqualTo(CompassDirection.E));
    }

}
