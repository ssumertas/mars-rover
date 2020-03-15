using HBMarsRoverCase.Base;
using System;
using System.Collections.Generic;

namespace HBMarsRoverCase.Models
{
    public class Command
    {
        public static Dictionary<char, Func<RoverPosition>> GetCommands(RoverBase roverBase)
        {
            return new Dictionary<char, Func<RoverPosition>> {
                {'L', () => roverBase.LeftSpin() },
                {'R', () => roverBase.RightSpin() },
                {'M', () => roverBase.MoveForward() }
            };
        }
    }
}
