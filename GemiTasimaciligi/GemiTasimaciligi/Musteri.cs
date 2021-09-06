using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemiTasimaciligi
{
    public class Musteri
    {
        public string MusteriAdi { get; set; }
        public string Tc { get; set; }

        public override string ToString()
        {
            return MusteriAdi ;
        }
    }
}
