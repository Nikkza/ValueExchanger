using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Valutaomvandlare
{

    class SweVar
    {
        /// <summary>
        /// Sweden varaiables
        /// </summary>
        /// 
        SweValueClass swevalueclass = new SweValueClass();



        public double SweOneKr { get; set; }
        public double SweTenkr { get; set; }

        public double SweTwentyBills { get; set; }
        public double SweFifthyBils { get; set; }
        public double SweHundredBills { get; set; }

        public double SweFivehundredBills { get; set; }


        public SweVar(double _onekr = 0, double _tenkr = 0,
            double _twenrtybills = 0, double _fifhtybils = 0, double _hundredbills = 0,
            double _fivehundredbills = 0)
        {
            SweOneKr = _onekr;
            SweTenkr = _tenkr;
            SweTwentyBills = _twenrtybills;
            SweFifthyBils = _fifhtybils;
            SweFivehundredBills = _fivehundredbills;

        }


        public void SweBills()
        {

            double[] Norwaybills = new double[] { SweOneKr = 1,SweTenkr = 10,
                        SweTwentyBills = 20,SweFifthyBils = 50,SweHundredBills = 100,SweFivehundredBills = 500};
            foreach (var i in Norwaybills)
            {

                Console.WriteLine($" {i} Kr ");
                Thread.Sleep(100);



            }


        }




    }
}

