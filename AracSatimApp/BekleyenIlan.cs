using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracSatimApp
{
   public class BekleyenIlan : Ilan
    {
        public int bekleyenIlanId { get; set; }
        public AracSahibi aracSahibi { get; set; }
        public BekleyenIlan(AracSahibi sahip)
        {
            this.aracSahibi = sahip;

        }
    }
}
