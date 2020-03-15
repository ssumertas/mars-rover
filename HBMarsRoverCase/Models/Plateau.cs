using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBMarsRoverCase.Models
{
    public class Plateau
    {
        public int XMinVal{ get; set; }
        public int YMinVal { get; set; }
        public int XMaxVal { get; set; }
        public int YMaxVal { get; set; }


        /// <summary>
        /// Confirms whether moving is possible on the given plateau or not. 
        /// </summary>
        public void ConfirmPlateauIsValid()
        {
            if (XMinVal >= XMaxVal)
                throw new Exception("X dimensions of Plateau is not valid.");

            else if (YMinVal >= YMaxVal)
                throw new Exception("Y dimensions of Plateau is not valid.");

            else
                return;
        }
    }
}
