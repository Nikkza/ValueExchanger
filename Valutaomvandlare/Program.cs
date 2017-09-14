using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Valutaomvandlare
{
    public class Program
    {
      /// <summary>
      /// This is where i printout my methods
      /// </summary>
        static void Main(string[] args)
        {
            
         Methods methods = new Methods();
         string resultcurrency = Methods.PrintOutYour(args,"value","value");
         double valuex = Methods.Message(args,0);
         Methods.DisplayOutResults(args,valuex);
         Console.ReadKey();
           
        }
       

    }
}
