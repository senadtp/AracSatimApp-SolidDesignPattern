using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatimApp
{
    public class VitrinIlani : Ilan
    {
        public int vitrinIlanId { get; set; }
        public SistemYoneticisi sistemYoneticisi { get; set; }
        
        public AracSahibi aracSahibi { get; set; }
        public Arac arac { get; set; }
        public VitrinIlani(AracSahibi sahip, SistemYoneticisi yonetici, Arac _arac)
        {
            this.aracSahibi = sahip;
            this.sistemYoneticisi = yonetici;
            this.arac = _arac;
        }
    }
}
