using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemiTasimaciligi
{
    public class Gemi
    {
        public string gemiAdi { get; set; }
        public decimal gemiTonaj { get; set; }

        public override string ToString()
        {
            return gemiAdi;
        }
    }
}
