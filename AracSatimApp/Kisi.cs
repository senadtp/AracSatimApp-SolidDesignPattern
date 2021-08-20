using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatimApp
{
   public abstract class Kisi
    {
        
        public string isim { get; set; }
        public string soyisim { get; set; }
        public string eposta { get; set; }
        protected string sifre { get; set; }

        public string adres { get; set; }

    }
}
