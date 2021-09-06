using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemiTasimaciligi
{
    public class Rota
    {

        public string rotaBaslangıc { get; set; }
        public string rotaUgranacak { get; set; }
        public string rotaVarıs { get; set; }

        public override string ToString()
        {
            return rotaBaslangıc+"  " + rotaUgranacak +"  "+ rotaVarıs;
        }
    }
}
