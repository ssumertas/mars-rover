using HBMarsRoverCase.Base;
using HBMarsRoverCase.Models;
using System;

namespace HBMarsRoverCase.Impl
{
    public class Rover : RoverBase
    {
        private readonly RoverPosition operatorRoverPosition;
        private readonly RoverPosition secondaryRoverPosition;

        public Rover(RoverPosition operatorRoverPosition, RoverPosition secondaryRoverPosition, Plateau plateau) : base(operatorRoverPosition, secondaryRoverPosition, plateau)
        {
            this.operatorRoverPosition = operatorRoverPosition;
            this.secondaryRoverPosition = secondaryRoverPosition;
        }
       
        public override RoverPosition LeftSpin()
        {
            operatorRoverPosition.Heading = operatorRoverPosition.Heading - 1 < Heading.N ? Heading.W : operatorRoverPosition.Heading - 1;

            return operatorRoverPosition;
        }
        public override RoverPosition RightSpin()
        {
            operatorRoverPosition.Heading = operatorRoverPosition.Heading + 1 > Heading.W ? Heading.N : operatorRoverPosition.Heading + 1;

            return operatorRoverPosition;
        }
        public override RoverPosition MoveForward()
        {
            int xVal = operatorRoverPosition.XVal;
            int yVal = operatorRoverPosition.YVal;

            Move(ref xVal, ref yVal);

            return ConfirmMoveAndReturnResult(xVal, yVal);
        }

        private void Move(ref int xVal, ref int yVal)
        {
            switch (operatorRoverPosition.Heading)
            {
                case Heading.N:
                    yVal++;
                    break;
                case Heading.S:
                    yVal--;
                    break;
                case Heading.E:
                    xVal++;
                    break;
                case Heading.W:
                    xVal--;
                    break;
                default:
                    throw new Exception("Heading is not appropriate");
            }
        }

        private RoverPosition ConfirmMoveAndReturnResult(int xVal, int yVal)
        {
            if (!ConfirmRoversAreNotCrashed())
            {
                throw new Exception("Rovers are crashed.");
            }

            else if (!ConfirmPlateauLimitsNotExceeded(xVal, yVal))
            {
                throw new Exception("Plateau limits has been exceeded.");
            }
            else
            {
                operatorRoverPosition.XVal = xVal;
                operatorRoverPosition.YVal = yVal;

                return operatorRoverPosition;
            }
        }

        

    }
}
