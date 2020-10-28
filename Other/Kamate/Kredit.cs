using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kamate
{
    class Kredit
    {
        public double Glavnica { get; set; }

        public double Kamatna_Stopa { get; set; }
        public double Trajanje { get; set; }
        public double Otp_Plan { get; set; }

        public void izracun()
        {
            Otp_Plan = Glavnica * Kamatna_Stopa / 100 * Trajanje;
        }

       
    }
}
