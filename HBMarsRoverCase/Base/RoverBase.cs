using HBMarsRoverCase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBMarsRoverCase.Base
{
    public abstract class RoverBase
    {
        private readonly RoverPosition firstRoverPosition;
        private readonly RoverPosition secondRoverPosition;
        private readonly Plateau plateau;

        public RoverBase(RoverPosition firstRoverPosition, RoverPosition secondRoverPosition,  Plateau plateau)
        {
            this.firstRoverPosition = firstRoverPosition;
            this.secondRoverPosition = secondRoverPosition;
            this.plateau = plateau;

            ConfirmConstructor();
            this.plateau.ConfirmPlateauIsValid();
        }

        /// <summary>
        /// Returns new RoverPosition object after 90 degree left spin is done. It changes heading.
        /// </summary>
        /// <returns></returns>
        public abstract RoverPosition LeftSpin();

        /// <summary>
        ///  Returns new RoverPosition object after 90 degree right spin is done. It changes heading.
        /// </summary>
        /// <returns></returns>
        public abstract RoverPosition RightSpin();

        /// <summary>
        ///  Returns new RoverPosition object after move forward one grid point. It changes x or y value.
        /// </summary>
        /// <returns></returns>
        public abstract RoverPosition MoveForward();

        /// <summary>
        /// Confirms given plateau limit is not exceeding for any x and y value.
        /// </summary>
        /// <param name="xval"></param>
        /// <param name="yval"></param>
        /// <returns></returns>
        protected bool ConfirmPlateauLimitsNotExceeded(int xval, int yval)
        {
            if (xval < plateau.XMinVal || xval > plateau.XMaxVal)
                return false;
            else if (yval < plateau.YMinVal || yval > plateau.XMaxVal)
                return false;
            else
                return true;
        }

        /// <summary>
        /// Confirms that first and second rovers are not crashing to each other.
        /// </summary>
        /// <returns></returns>
        protected bool ConfirmRoversAreNotCrashed()
        {
            if (firstRoverPosition.XVal == secondRoverPosition.XVal && firstRoverPosition.YVal == secondRoverPosition.YVal)
                return false;

            return true;
        }

        private void ConfirmConstructor()
        {
            if (firstRoverPosition == null || secondRoverPosition == null || plateau == null)
                throw new Exception("RoverPositions or Plateu cannot be null");

        }       
    }
}
