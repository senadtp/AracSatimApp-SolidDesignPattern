using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatimApp
{
   public class Arac
    {
        public int aracID { get; set; }
        public string AracTuru { get; set; }
        public int uretimYili { get; set; }
        public string Marka { get; set; }
        public string Model { get; set; }
        public string yakitTuru { get; set; }
        public string Motor { get; set; }
        public string Sanziman { get; set; }
        public int AracKm { get; set; }
        public int AracFiyat { get; set; }
        public bool sisFari { get; set; }
        public bool katlanabilirAyna { get; set; }
        public bool parkSensoru { get; set; }
        public bool merkeziKilit { get; set; }
        public bool camTavan { get; set; }
    }
}
