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
        
        public void Val()
        {
            EasterEgg easterEgg = new EasterEgg();
            Console.WriteLine("Välkomen till Console Calc!");
            Console.WriteLine("Tryck 1 och enter för att omvandla Temperatur");
            Console.WriteLine("Tryck 2 och enter för att använda calculatorn");
            
            switch (Console.ReadLine())
            {
                case "1":
                    TempVal();
                    break;

                case "2":
                    Calcval();
                    break;
                case "xyzzy":
                    Console.WriteLine("Nothing happens");
                    break;
                case "MusicBox":
                    easterEgg.MyEasterEgg();
                    break;
                    

                    
                    default:
                    Val();
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
                case "xyzzy":
                    Console.WriteLine("Nothing happens");
                    break;

                default:
                    Val();
                    return;
                  


            }


        }
        
           public void Calcval()
            {
            Inmatning inmatning = new();
            Uträkning calc = new();
            
            Console.WriteLine("skriv ett tal");
            decimal NumbFörsta = inmatning.InmatatningAvTal();
            Console.WriteLine("Skriv ett till");
            decimal NumbAndra = inmatning.InmatatningAvTal();
            Console.WriteLine("Skriv 1 och tryck enter för att addera");
            Console.WriteLine("Skriv 2 och tryck enter för att subtrahera");
            Console.WriteLine("Skriv 3 och tryck enter för att dividera");
            Console.WriteLine("Skriv 4 och tryck enter för att multiplicera");

            switch (inmatning.InmatningAvVal())
            {
                case "1":
                    Console.WriteLine(calc.addition(NumbFörsta,NumbAndra));
                    break;
                    case"2":
                    Console.WriteLine(calc.subtraktion(NumbFörsta,NumbAndra));
                    break;
                    case"3":
                    Console.WriteLine(calc.division(NumbFörsta,NumbAndra));
                    break;
                    case"4":
                    Console.WriteLine(calc.multiplikation(NumbFörsta,NumbAndra));
                    break;
                case "xyzzy":
                    Console.WriteLine("Nothing happens");
                    break;
                default:
                    Val();
                    return;
            }

        }
    }
}
