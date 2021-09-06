using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemiTasimaciligi
{
    public class GemiRotasi
    {
        public Gemi gidecekGemi { get; set; }
        public Rota gidilecekRota { get; set; }
        public DateTime GidisTarihi { get; set; }
        public DateTime DonusTarihi { get; set; }
        public override string ToString()
        {
            return gidecekGemi.gemiAdi+" "+gidilecekRota.rotaBaslangıc+gidilecekRota.rotaUgranacak+gidilecekRota.rotaVarıs+" "+GidisTarihi+""+DonusTarihi;
        }
    }
}
