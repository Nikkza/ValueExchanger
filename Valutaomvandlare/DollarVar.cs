using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Valutaomvandlare
{
    
    class DollarVar
    {

        SweValueClass swevalueclass = new SweValueClass();

        /// <summary>
        /// Dollar variables
        /// </summary>

        public int OneHundredDollar { get; set; }
        public int FifhtyDollar { get; set; }
        public int TwentyDollar { get; set; }
        public int TenDollar { get; set; }

        public int FiveDollar { get; set; }
        public int TwoDollar { get; set; }
        public int OneDollar { get; set; }

        public double FifhtyCent { get; set; }
        public double TwentyFiveCent { get; set; }
        public double TenCent { get; set; }
        public double FiveCent { get; set; }
        public double OneCent { get; set; }

        public DollarVar(int _OneHundredDollar = 0, int _FifhtyDollar = 0, int _TwentyDollar = 0,
           int _TenDollar = 0, int _FiveDollar = 0, int _TwoDollar = 0,
           int _OneDollar = 0, double _FifhtyCent = 0, double _TwentyFiveCent = 0,
           double _TenCent = 0, double _FiveCent = 0, double _OneCent = 0)
        {

            OneHundredDollar = _OneHundredDollar;
            FifhtyDollar = _FifhtyDollar;
            TwentyDollar = _TwentyDollar;
            TenDollar = _TenDollar;
            FiveDollar = _FiveDollar;
            TwoDollar = _TwoDollar;
            OneDollar = _OneDollar;
            FifhtyCent = _FifhtyCent;
            TwentyFiveCent = _TwentyDollar;
            TenCent = _TenCent;
            FiveCent = _FiveCent;
            OneCent = _OneCent;


        }

        public void DollarBillsMethod()
        {
           
            int[] UsdBills = new int[]{OneDollar = 1,
                 TwoDollar = 2, FiveDollar = 5,
                 TenDollar = 10, TwentyDollar = 20, FifhtyDollar = 50, OneHundredDollar = 100};
            foreach (var i in UsdBills)
            {

                Console.WriteLine($" {i} USD");

                Thread.Sleep(100);
            }
            double[] UsdCoins = new double[]{OneCent= 0.01d,FiveCent = 0.05d,
                TenCent = 0.10d, TwentyFiveCent = 0.25d, FifhtyCent = 0.50d};
            foreach (var i in UsdCoins)
            {

                Console.WriteLine($" {i} CENT");

                Thread.Sleep(100);
            }
        }
       
    }
}

