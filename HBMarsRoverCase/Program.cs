using HBMarsRoverCase.Models;
using System;

namespace HBMarsRoverCase
{
    class Program
    {
        static void Main(string[] args)
        {
            var plateau = new Plateau
            {
                XMinVal = 0,
                YMinVal = 0,

                XMaxVal = 5,
                YMaxVal = 5
            };

            var firstRoverInitialPosition = new RoverPosition
            {
                XVal = 1,
                YVal = 2,
                Heading = Heading.N
            };

            var secondRoverInitialPosition = new RoverPosition
            {
                XVal = 3,
                YVal = 3,
                Heading = Heading.E
            };


            var firstRoverOperator = new RoverOperator
            {
                OperatorRoverPosition = firstRoverInitialPosition,
                SecondaryRoverPosition = secondRoverInitialPosition,
                Plateau = plateau
            };

            var firstRoverPositionResult = firstRoverOperator.ApplyCommand("LMLMLMLMM");

            var secondRoverOperator = new RoverOperator
            {
                OperatorRoverPosition = secondRoverInitialPosition,
                SecondaryRoverPosition = firstRoverPositionResult,
                Plateau = plateau
            };

            var secondRoverPositionResult = secondRoverOperator.ApplyCommand("MMRMMRMRRM");

            Console.WriteLine(firstRoverPositionResult.RoverPostionAsString());
            Console.WriteLine(secondRoverPositionResult.RoverPostionAsString());

            Console.ReadKey();
        }
    }
}
