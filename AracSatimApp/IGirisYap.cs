using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatimApp
{
    public interface IGirisYap
    {
        bool musteriGiris(string eposta, string sifre); 
    }
}
