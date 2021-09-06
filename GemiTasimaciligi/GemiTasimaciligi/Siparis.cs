using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GemiTasimaciligi
{
    public class Siparis
    {
        public Musteri musteriAdi { get; set; }
        public GemiRotasi gemiRota { get; set; }
        public decimal SiparisTonaj { get; set; }

        public override string ToString()
        {
            return musteriAdi + "  " + gemiRota.gidilecekRota + " " + gemiRota.gidecekGemi.gemiAdi + " Tonaj:" + SiparisTonaj;
        }


    }
}
