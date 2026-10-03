using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_App_Console
{
    public class Artikel
    {
        public Text TextInformationen { get; set; }
        public Menge MengenInformationen { get; set; }
        public double Preis { get; set; }
        public bool IstDurchgestrichen { get; set; }
    }
}
