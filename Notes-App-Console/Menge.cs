using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes_App_Console
{
    public class Menge
    {
        public Einheiten Einheit { get; set; }
        public int Wert { get; set; }
    }
    public enum Einheiten
    {
        Stück,
        Gramm,
        Kilogramm,
        Liter,
        Milliliter,
        Packung
    }
}
