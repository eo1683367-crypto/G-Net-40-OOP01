using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP01.MyStructs
{
    internal struct SeatLocation
    {
        public char Row { get; set; }
        public int Number { get; set; }
        public SeatLocation(char row, int number)
        {
            Row = row;
            Number = number;
        }

     
    }
}
