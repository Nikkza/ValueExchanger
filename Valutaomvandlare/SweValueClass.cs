using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valutaomvandlare

{

    class SweValueClass
    {
        /// <summary>
        /// This whre i hold my varaiables for all the currency
        /// </summary>
        public double dollartoSweden = 8.08d;
        public double Euro = 9.48d;
        public double usdToEuro = 0.85d;
        public double euroToDollar = 1.18d;

        public SweValueClass(double _dollarToSWeeden = 8.08d,double _Euro = 9.48d,double _usdToEuro = 0.85d,double _eurotodollar = 1.18d)
        {
            dollartoSweden = _dollarToSWeeden;
            Euro = _Euro;
            usdToEuro = _usdToEuro;
            euroToDollar = _eurotodollar;
        }
    }
}
