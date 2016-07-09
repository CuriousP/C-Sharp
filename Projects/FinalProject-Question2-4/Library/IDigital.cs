using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    interface IDigital
    {
        uint LengthInSeconds { get; set; }

        DigitalDisc.DiscType MediaType { get; set; }

        //following methods will return Hours, Minutes, Sec
        //for the duration of digital media(lengthSeconds)
        //e.g., 1:30:25

        string getHMS();
    }
}
