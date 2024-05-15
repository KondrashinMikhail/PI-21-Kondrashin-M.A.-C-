using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsExcavator
{
    class ParkingOccupiedPlaceException : Exception
    {
        public ParkingOccupiedPlaceException() : base("Место занято")
        { }
    }
}
