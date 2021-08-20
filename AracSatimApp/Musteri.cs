using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatimApp
{
    public class Musteri : Kisi, IMusteriIslemleri, IGirisYap
    {
        public int musteriID { get; set; }

        public void AracIncele()
        {
            throw new NotImplementedException();
        }

        public void AracListele()
        {
            throw new NotImplementedException();
        }

        public void AracSatinAl()
        {
            throw new NotImplementedException();
        }

        public void ilanKarsilastir()
        {
            throw new NotImplementedException();
        }

        bool musteriGiris(string eposta, string sifre)
        {
            throw new NotImplementedException();
        }

        bool IGirisYap.musteriGiris(string eposta, string sifre)
        {
            throw new NotImplementedException(); 
            //Giriş yapma işlemi başarılı olursa true dönecek, başarısız olursa false dönecek.
        }
    }
}
