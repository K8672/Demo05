using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class CD
    {
        
        public string Song { get; set; }
        public string Time { get; set; }
        public override string ToString()
        {
            return Song + " " + Time;
        }

    }
}
