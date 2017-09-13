using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Valutaomvandlare
{
    class NorVar
    {

        /// <summary>
        /// Euro varaibaler
        ///</summary>
        /// 



        //
        public double OneCent { get; set; }
        public double TwoCent { get; set; }
        public double FiveCent { get; set; }
        public double TenCent { get; set; }
        public double TwentyCent { get; set; }
        public double FifhtyCentEuro { get; set; }
        public int OneEuro { get; set; }
        public int TwoEuro { get; set; }
        public int FiveEuro { get; set; }
        public int TenEuro { get; set; }
      

       //bills
        public int FiveHundredEuro { get; set; }
        public int TwoHundredEuro { get; set; }
        public int OneHundredEuro { get; set; }
        public int FifhtyEuro { get; set; }
        public int TwentyEuro { get; set; }

       
       

        public NorVar(double _OneCent = 0, double _TwoCent = 0, double _FiveCent = 0,
            double _TenCent = 0, double _TwentyCent = 0, double _FifhtyCentEuro = 0,
           int _OneEuro = 0,int _TwoEuro = 0, 
           int _FiveEuro = 0, int _TenEuro = 0, int _TwentyEuro = 0, int _FifhtyEuro = 0,
           int _OneHundredEuro = 0,int _TwoHundredEuro = 0, int _FiveHundredEuro = 0)
        {

            OneCent = _OneCent;
            TwoCent = _TwoCent;
            FiveCent = _FiveCent;
            TenCent = _TenCent;
            TwentyCent = _TwentyCent;
            FifhtyCentEuro = _FifhtyCentEuro;
            OneEuro = _OneEuro;
            TwoEuro = _TwoEuro;
            FiveEuro = _FiveEuro;
            TenEuro = _TenEuro;
            TwentyEuro = _TwentyEuro;
            FifhtyEuro = _FifhtyEuro;
            OneHundredEuro = _OneHundredEuro;
            TwoHundredEuro = _TwoHundredEuro;
            FiveHundredEuro = _FiveHundredEuro;


          
            
      
        }

        public void EuroBills()
        {

            int[] Eurocents = new int[] {OneEuro = 1,TwoEuro = 2,TenEuro = 10,FifhtyEuro = 50,
                OneHundredEuro = 100,TwoHundredEuro = 200,FiveHundredEuro = 500 };

                foreach (int i in Eurocents)
                {
                    Console.WriteLine($"{i} Euro");
                Thread.Sleep(100);
            }
              

            double[] Eurocents1 = new double[] {OneCent = 0.01d,TwoCent = 0.02d,
                    FiveCent =0.05d,TenCent = 0.10d,TwentyCent = 0.20d,
                    FifhtyCentEuro = 0.50d};


                foreach (var i in Eurocents1)
                {
                    Console.WriteLine($"{i} Euro");
                Thread.Sleep(100);
            }
          
        }

    }
}
