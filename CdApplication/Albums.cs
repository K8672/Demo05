using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CdApplication
{
    class Albums
    {

        public string Album { get; set; }
        public string Artist { get; set; }

        public override string ToString()
        {
            return "-" + Album + "\n" + "-" + Artist;
        }
    }
}
