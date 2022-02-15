using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CalcIndividuell;

namespace CalcIndividuell
{
    public class Valmöjligheter
    {
        public void val()
        {
            Console.WriteLine("Välkomen till Console Calc!");
            Console.WriteLine("Tryck 1 och enter för att omvandla Temperatur");
            Console.WriteLine("Tryck 2 och enter för att använda calculatorn");
            Console.WriteLine("Tryck enter för att komma tillbaka till starten");
            switch (Console.ReadLine())
            {
                case "1":
                    TempVal();
                    break;

                case "2":
                    Calcval();
                    break;
                    default:
                    val();
                    return;
            }
        }
        
        public void TempVal()
        {
            Temperatur temp = new();
            Inmatning inmatning = new();
            Console.WriteLine("Skriv ett tal");
            decimal Numb = inmatning.InmatatningAvTal();
            Console.WriteLine("Skriv 1 och tryck enter för att omvandla celsius till farenheit");
            Console.WriteLine("Skriv 2 och tryck enter för att omvandla farenheit till celsius");
           
                
            switch (inmatning.InmatningAvVal())
            {
                case "1":
                    Console.WriteLine(temp.CelsiusToFarenheit(Numb));
                    Console.WriteLine("farenheit");
                    break;
                case "2":

                    Console.WriteLine(temp.FarenheitToCelsius(Numb));
                    Console.WriteLine("Celsius");
                    break;
                default:
                    val();
                    return;
                  


            }


        }
           public void Calcval()
            {

            }
    }
}
