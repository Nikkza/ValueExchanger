﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;


namespace Valutaomvandlare
{
    class Methods
    {
        /// <summary>
        /// I have all my met´hods in here, and i also have my arguments
        /// You can type in for exeample USD EURO 200 so in thatr order you must passed the argumnts
        /// </summary>

        //This Variables is the one that holds Currency 1 and Currency 2
        public static string mainLanguageCheck;
        public static string mainLanguageCheckTwo;


        public static string PrintOutYour(string[] args, string resultcurrency, string valueuTwoCurrency)
        {

            Checkvariables checkvariables = new Checkvariables();
            Start:
            Console.WriteLine();
            Console.WriteLine("------------------------Currency Changer----------------------------");
            Console.WriteLine();


            //This is whwre you can choosed currency from
            Console.WriteLine($"We have this Curency \n1: {checkvariables.Usd}\n2: {checkvariables.Euro}\n3: {checkvariables.Sweden} ");
            Console.WriteLine();
            Console.Write("Choose Currency : ", resultcurrency);

            //this is to check the arguments it have to be 3 arguments.
            if (args.Count() == 3)
            {
                mainLanguageCheck = args[0];
            }
            else
            {
                mainLanguageCheck = Convert.ToString(Console.ReadLine());

            }
            //This if statement is when i dont want to show this code when u run arguments from command line.
            if (args.Count() != 3)
            {

                //Her i checked if the value stored in the mainLanguageCheck varaibel
                //Examel if the mainLanguageCheck == KR it's printed out Case KR.

                switch (mainLanguageCheck)
                {

                    case "KR":
                        SweVar billssweden = new SweVar();
                        billssweden.SweBills();
                        break;
                    case "USD":
                        DollarVar billsdollar = new DollarVar();
                        billsdollar.DollarBillsMethod();
                        break;
                    case "EURO":
                        NorVar euro = new NorVar();
                        euro.EuroBills();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("you type the wrong Currency type exit to exit the console, TRY AGAIN".ToUpper());
                        Console.ResetColor();
                        goto Start;


                }

            }
          
            Console.Write($"You typed in : {mainLanguageCheck}");
           

            Console.WriteLine();

            back:
            
            Console.Write("Choose currency to change to : ", valueuTwoCurrency);
          




            //This is for the argument here i passed argument 2
            if (args.Count() == 3)
            {
                mainLanguageCheckTwo = args[1];
            }
            else
            {
                mainLanguageCheckTwo = Convert.ToString(Console.ReadLine());
            }

            Console.WriteLine($"You typed in : {mainLanguageCheckTwo}");

            if (args.Count() != 3)
            { 
                switch (mainLanguageCheckTwo)
                {
                    case "KR":
                        SweVar billssweden = new SweVar();
                        billssweden.SweBills();
                        break;
                    case "USD":
                        DollarVar billsdollar = new DollarVar();
                        billsdollar.DollarBillsMethod();
                        break;
                    case "EURO":
                        NorVar euro = new NorVar();
                        euro.EuroBills();
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("you type the wrong Currency type exit to exit the console, TRY AGAIN".ToUpper());
                        Console.ResetColor();
                        goto back;
                }
             }
            


            //euro to dollar and dollar to euro

            if (mainLanguageCheck == checkvariables.Euro && mainLanguageCheckTwo == checkvariables.Usd)
            {
                Console.WriteLine();
                Console.WriteLine($"You want to change {checkvariables.Euro} to {checkvariables.Usd}");
                Console.WriteLine();

            }
            else if (mainLanguageCheck == checkvariables.Usd && mainLanguageCheckTwo == checkvariables.Euro)
            {
                Console.WriteLine();
                Console.WriteLine($"You want to change {checkvariables.Usd} to {checkvariables.Euro}");
                Console.WriteLine();

            }

            //sweden to euro  and euro to sweden
            else if (mainLanguageCheck == checkvariables.Sweden && mainLanguageCheckTwo == checkvariables.Euro)
            {
                Console.WriteLine();
                Console.WriteLine($"You want to change {checkvariables.Sweden} to {checkvariables.Euro}");
                Console.WriteLine();

            }
            else if (mainLanguageCheck == checkvariables.Euro && mainLanguageCheckTwo == checkvariables.Sweden)
            {
                Console.WriteLine();
                Console.WriteLine($"You want to change {checkvariables.Euro} to {checkvariables.Sweden}");
                Console.WriteLine();
            }

            //usd to sweden and dollar to swe
            else if (mainLanguageCheck == checkvariables.Usd && mainLanguageCheckTwo == checkvariables.Sweden)
            {
                Console.WriteLine();
                Console.WriteLine($"You want to change {checkvariables.Usd} to {checkvariables.Sweden}");
                Console.WriteLine();

            }
            else if (mainLanguageCheck == checkvariables.Sweden && mainLanguageCheckTwo == checkvariables.Usd)
            {
                Console.WriteLine();
                Console.WriteLine($"You want to change {checkvariables.Sweden} to {checkvariables.Usd}");
                Console.WriteLine();
            }
            string resultsOf = mainLanguageCheck + mainLanguageCheckTwo;
            return resultsOf;


        }

        /// <summary>
        /// This is you type in how much you want to Change
        /// </summary>
        /// <param name="args"></param>
        /// <param name="MGS"></param>
        /// <returns></returns>
        public static double Message(string[] args, double MGS)
        {
            string parse;
            //This is for the argument here i passed argument 3 and it's for Value when you change arg[0] arg[2]
            test:
            if (args.Count() == 3)
            {
                MGS = Convert.ToDouble(args[2]);

            }
            else
            {
               
                Console.Write("Enter how much you want to change : ", MGS);
               

                parse = Console.ReadLine();

                if (!double.TryParse(parse, out MGS))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("You have to type a nuber TRY AGAIN".ToUpper());
                    Console.ResetColor();

                    goto test;


                }
            }
            return MGS;
            
        }

        /// <summary>
        /// This is where i prints out everything. The results of the currency you choosed earlier
        /// </summary>
        /// <param name="args"></param>
        /// <param name="valuex"></param>
        public static void DisplayOutResults(string[] args, double valuex)
        {
            MainVar mainvar = new MainVar()
            {
                Results = 0
            };
            Checkvariables checkvariables = new Checkvariables();

            if (mainLanguageCheck == checkvariables.Euro && mainLanguageCheckTwo == checkvariables.Usd)
            {
                Console.Write($"You typed in : {valuex} {checkvariables.Euro} ");
                SweValueClass swevalueclass = new SweValueClass();
                mainvar.Results = valuex * swevalueclass.euroToDollar;
                Console.WriteLine();
                Console.WriteLine($"You get back this value : {mainvar.Results.ToString("#.00")} {checkvariables.Usd}");


                // I ´dont want this to show from command line m´when u passed the arguments
                if (args.Count() != 3)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"This is what yuu get back in {checkvariables.Usd.ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------");
                   



                    DollarVar dollarbills = new DollarVar();

                    int[] UsdBills = new int[]{dollarbills.OneDollar = 1,
                     dollarbills.TwoDollar = 2, dollarbills.FiveDollar = 5,
                     dollarbills.TenDollar = 10, dollarbills.TwentyDollar = 20, dollarbills.FifhtyDollar = 50,
                     dollarbills.OneHundredDollar = 100};

                    double amount = mainvar.Results;

                    int num;


                    for (int i = 6; i >= 0; i--)
                    {
                        if (UsdBills[i] <= amount)
                        {
                            num = (int)amount / UsdBills[i];

                            Console.WriteLine(num + " " + " " + UsdBills[i] + " USD");

                            amount = amount % UsdBills[i];

                        }
                    }


                    double[] UsdCoins = new double[]{dollarbills.OneCent= 0.01d,dollarbills.FiveCent = 0.05d,
                    dollarbills.TenCent = 0.10d, dollarbills.TwentyFiveCent = 0.25d,dollarbills.FifhtyCent = 0.5d};

                    for (int i = 4; i >= 0; i--)
                    {
                        if (UsdCoins[i] <= amount)
                        {
                            num = (int)(amount / UsdCoins[i]);


                            Console.WriteLine(num + " " + " " + UsdCoins[i] + " CENT");

                            amount = Math.Round(amount % UsdCoins[i], 3);

                        }

                    }
                }

            }
            else if (mainLanguageCheck == checkvariables.Usd && mainLanguageCheckTwo == checkvariables.Euro)
            {
                Console.WriteLine($"You typed in {valuex} {checkvariables.Usd} ");
                SweValueClass swevalueclass = new SweValueClass();
                mainvar.Results = valuex * swevalueclass.usdToEuro;
                Console.WriteLine();
                Console.WriteLine($"You get back this value {mainvar.Results} {checkvariables.Euro}");


                // I ´dont want this to show from command line m´when u passed the arguments
                if (args.Count() != 3)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"This is what yuu get back in {checkvariables.Euro.ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------");

                    NorVar euro = new NorVar();

                    int[] Eurocents = new int[] {euro.OneEuro = 1,euro.TwoEuro = 2,euro.TenEuro = 10,euro.FifhtyEuro = 50,
                     euro.OneHundredEuro = 100, euro.TwoHundredEuro = 200,euro.FiveHundredEuro = 500 };


                    double amount = mainvar.Results;

                    int num;

                    for (int i = 6; i > 0; i--)
                    {
                        if (Eurocents[i] <= amount)
                        {
                            num = (int)amount / Eurocents[i];


                            Console.WriteLine(num + " " + " " + Eurocents[i] + " EURO");

                            amount = amount % Eurocents[i];

                        }
                    }

                    double[] Eurocents1 = new double[] {euro.OneCent = 0.01d,euro.TwoCent = 0.02d,euro.
                    FiveCent =0.05d,euro.TenCent = 0.10d,euro.TwentyCent = 0.20d,
                    euro.FifhtyCentEuro = 0.50d};


                    for (int i = 5; i > 0; i--)
                    {
                        if (Eurocents1[i] <= amount)
                        {
                            num = (int)(amount / Eurocents1[i]);

                         Console.WriteLine(num + " " + " " + Eurocents1[i] + " CENT");

                            amount = Math.Round(amount % Eurocents1[i], 2);

                        }

                    }
                }
            }
            else if (mainLanguageCheck == checkvariables.Sweden && mainLanguageCheckTwo == checkvariables.Euro)
            {
                Console.WriteLine($"You typed in {valuex} {checkvariables.Sweden} ");
                SweValueClass swevalueclass = new SweValueClass();
                mainvar.Results = valuex * 0.11;
                Console.WriteLine();
                Console.WriteLine($"You get back this value {mainvar.Results} {checkvariables.Euro} ");

                // I ´dont want this to show from command line m´when u passed the arguments

                if (args.Count() != 3)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"This is what yuu get back in {checkvariables.Euro.ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------");

                    NorVar euro = new NorVar();

                    int[] Eurocents = new int[] {euro.OneEuro = 1,euro.TwoEuro = 2,euro.TenEuro = 10,euro.FifhtyEuro = 50,
                    euro.OneHundredEuro = 100, euro.TwoHundredEuro = 200,euro.FiveHundredEuro = 500 };


                    double amount = mainvar.Results;

                    int num;

                    for (int i = 6; i > 0; i--)
                    {
                        if (Eurocents[i] <= amount)
                        {
                            num = (int)amount / Eurocents[i];


                            Console.WriteLine(num + " " + " " + Eurocents[i] + " EURO");

                            amount = amount % Eurocents[i];

                        }
                    }

                    double[] Eurocents1 = new double[] {euro.OneCent = 0.01d,euro.TwoCent = 0.02d,euro.
                    FiveCent = 0.05d,euro.TenCent = 0.10d,euro.TwentyCent = 0.20d,
                    euro.FifhtyCentEuro = 0.50d};


                    for (int i = 5; i >= 0; i--)
                    {
                        if (Eurocents1[i] <= amount)
                        {
                            num = (int)(amount / Eurocents1[i]);


                            Console.WriteLine(num + " " + " " + Eurocents1[i] + " CENT");

                            amount = Math.Round(amount % Eurocents1[i], 3);

                        }

                    }
                }

            }

            else if (mainLanguageCheck == checkvariables.Euro && mainLanguageCheckTwo == checkvariables.Sweden)
            {
                Console.WriteLine($"You typed in {valuex} {checkvariables.Euro} ");
                SweValueClass swevalueclass = new SweValueClass();
                mainvar.Results = valuex * swevalueclass.Euro;
                Console.WriteLine();
                Console.WriteLine($"You get back this value {Math.Round(mainvar.Results, 0)} {checkvariables.Sweden}");

                // I ´dont want this to show from command line m´when u passed the arguments

                if (args.Count() != 3)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"This is what yuu get back in {checkvariables.Sweden.ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------");

                    SweVar billssweden = new SweVar();

                    double[] swedenbillsprint = new double[] { billssweden.SweOneKr = 1,billssweden.SweTenkr = 10,
                    billssweden.SweTwentyBills = 20,billssweden.SweFifthyBils = 50,billssweden.SweHundredBills = 100,billssweden.SweFivehundredBills = 500};

                    double amount = Math.Round(mainvar.Results, 0);

                    int num;

                    for (int i = 5; i >= 0; i--)
                    {
                        if (swedenbillsprint[i] <= amount)
                        {
                            num = (int)(amount / swedenbillsprint[i]);


                            Console.WriteLine(num + " " + " " + swedenbillsprint[i] + " KR");

                            amount = Math.Round(amount % swedenbillsprint[i], 1);

                        }
                    }
                }
            }

            else if (mainLanguageCheck == checkvariables.Usd && mainLanguageCheckTwo == checkvariables.Sweden)
            {
                Console.WriteLine($"You typed in {valuex} {checkvariables.Usd} ");
                SweValueClass swevalueclass = new SweValueClass();
                mainvar.Results = valuex * swevalueclass.dollartoSweden;
                Console.WriteLine();
                Console.WriteLine($"You get back this value {Math.Round(mainvar.Results, 0)} {checkvariables.Sweden}");


                // I ´dont want this to show from command line m´when u passed the arguments

                if (args.Count() != 3)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"This is what yuu get back in {checkvariables.Sweden.ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------");

                    SweVar billssweden = new SweVar();

                    double[] swedenbillsprint = new double[] { billssweden.SweOneKr = 1,billssweden.SweTenkr = 10,
                billssweden.SweTwentyBills = 20,billssweden.SweFifthyBils = 50,billssweden.SweHundredBills = 100,billssweden.SweFivehundredBills = 500};

                    double amount = Math.Round(mainvar.Results, 0);

                    int num;

                    for (int i = 5; i >= 0; i--)
                    {
                        if (swedenbillsprint[i] <= amount)
                        {
                            num = (int)(amount / swedenbillsprint[i]);


                            Console.WriteLine(num + " " + " " + swedenbillsprint[i] +  " KR");

                            amount = amount % swedenbillsprint[i];

                        }
                    }
                }
            }
            else if (mainLanguageCheck == checkvariables.Sweden && mainLanguageCheckTwo == checkvariables.Usd)
            {
                Console.WriteLine($"You typed in {valuex} {checkvariables.Sweden} ");
                SweValueClass swevalueclass = new SweValueClass();
                mainvar.Results = valuex * 0.124;
                Console.WriteLine($"You get back this value {mainvar.Results.ToString("#.00")} {checkvariables.Usd}");

                // I ´dont want this to show from command line m´when u passed the arguments

                if (args.Count() != 3)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"This is what yuu get back in {checkvariables.Usd.ToUpper()}");
                    Console.ResetColor();
                    Console.WriteLine("---------------------------");
                    DollarVar dollarbills = new DollarVar();

                    int[] UsdBills = new int[]{dollarbills.OneDollar = 1,
                 dollarbills.TwoDollar = 2, dollarbills.FiveDollar = 5,
                 dollarbills.TenDollar = 10, dollarbills.TwentyDollar = 20, dollarbills.FifhtyDollar = 50,
                 dollarbills.OneHundredDollar = 100};

                    double amount = mainvar.Results;

                    int num;

                    for (int i = 6; i > 0; i--)
                    {
                        if (UsdBills[i] < amount)
                        {
                            num = (int)amount / UsdBills[i];

                             Console.WriteLine(num + " " + " " + UsdBills[i] + " USD");

                            amount = amount % UsdBills[i];

                        }
                    }


                    double[] UsdCoins = new double[]{dollarbills.OneCent= 0.01d,dollarbills.FiveCent = 0.05d,
                dollarbills.TenCent = 0.10d, dollarbills.TwentyFiveCent = 0.25d,dollarbills.FifhtyCent = 0.50d};

                    for (int i = 4; i >= 0; i--)
                    {
                        if (UsdCoins[i] <= amount)
                        {
                            num = (int)(amount / UsdCoins[i]);


                            Console.WriteLine(num + " " + " " + UsdCoins[i] + " CENT");

                            amount = Math.Round(amount % UsdCoins[i], 2);

                        }

                    }
                }
            }
        }
    }
}

 