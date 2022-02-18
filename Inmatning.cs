using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIndividuell
{   /// <summary>
/// Klass med metoder för inmatning av tal till kalkylatorn och temperatursomvandlaren.
   /// </summary>
    public class Inmatning
    {
        // Metod som tar försöker ta en decimal, om det användaren skirver inte är en decimal
        //
        public decimal InmatatningAvTal()
        {
            try
            {
                decimal Inmating = Convert.ToDecimal(Console.ReadLine());
                return Inmating;
            }
            catch
            {
                Console.WriteLine("Test igen");
                return InmatatningAvTal();

            }

        }
        public string InmatningAvVal()
        {
            try
            {
                return Console.ReadLine();
            }
            catch 
            {
                Console.WriteLine("Nothin happens");
                return InmatningAvVal();
                
            }

        }
    }
}

