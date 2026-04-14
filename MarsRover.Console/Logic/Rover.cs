using MarsRover_Console.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover_Console.Logic
{
    public class Rover(int x, int y, CompassDirection directionFacing)
    {
        public int X { get; private set; } = x;
        public int Y { get; private set; } = y;
        public CompassDirection DirectionFacing { get; private set; } = directionFacing;

        public void RotateLeft()
        {
            DirectionFacing = DirectionFacing switch
            {
                CompassDirection.N => CompassDirection.W,
                CompassDirection.W => CompassDirection.S,
                CompassDirection.S => CompassDirection.E,
                CompassDirection.E => CompassDirection.N
            };
        }

        public void RotateRight()
        {
            DirectionFacing = DirectionFacing switch
            {
                CompassDirection.N => CompassDirection.E,
                CompassDirection.E => CompassDirection.S,
                CompassDirection.S => CompassDirection.W,
                CompassDirection.W => CompassDirection.N,
            };
        }
        public void MoveForward(Plateau plateau)
        {
            int newX = X;
            int newY = Y;

            switch (DirectionFacing)
            {
                case CompassDirection.N:
                    newY++;
                    break;

                case CompassDirection.E:
                    newX++;
                    break;

                case CompassDirection.S:
                    newY--;
                    break;

                case CompassDirection.W:
                    newX--;
                    break;
            }

            if (plateau.IsInsidePlateau(newX, newY))
            {
                X = newX;
                Y = newY;
            }
        }
    }

      
 }


