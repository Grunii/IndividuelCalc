using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIndividuell
{
    public class Uträkning
    {
       public decimal addition(decimal x, decimal y)
        {
            return x + y;
            
        }
        public decimal division(decimal x, decimal y)
        {
            try
            {
               return x / y;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Du försökte dividera med 0");
                Console.WriteLine("Ditt andra tal var"); return y;
                
            }
            

        }
        public decimal subtraktion(decimal x, decimal y)
        {
            return x - y;
        }
        public decimal multiplikation(decimal x, decimal y)
        {
            return x * y;
        }
       
    }
}
