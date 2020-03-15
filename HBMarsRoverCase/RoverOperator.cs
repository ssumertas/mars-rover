using HBMarsRoverCase.Impl;
using HBMarsRoverCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBMarsRoverCase
{
    public class RoverOperator
    {
        public RoverPosition OperatorRoverPosition { get; set; }
        public RoverPosition SecondaryRoverPosition { get; set; }
        public Plateau Plateau { get; set; }

        public RoverPosition ApplyCommand(string commandAsString)
        {
            var rover = new Rover(OperatorRoverPosition, SecondaryRoverPosition, Plateau);

            var commandDict = Command.GetCommands(rover);

            foreach (var commandAsChar in commandAsString)
            {
                commandDict[commandAsChar].Invoke();
            }

            return OperatorRoverPosition;
        }        
    }
}
