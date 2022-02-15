using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIndividuell
{
    public class Inmatning
    {
        public decimal InmatatningAvTal()
        {
            try
            {
                decimal x = Convert.ToDecimal(Console.ReadLine());
                return x;
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
                Console.WriteLine("inget händer");
                return InmatningAvVal();
                
            }

        }
    }
}

