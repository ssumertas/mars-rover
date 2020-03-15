using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HBMarsRoverCase.Models
{
    public class RoverPosition
    {
        public int XVal { get; set; }
        public int YVal { get; set; }
        public Heading Heading { get; set; }

        public string RoverPostionAsString()
        {
            return string.Format("{0} {1} {2}", XVal, YVal, Heading);
        }
    }
    
}
