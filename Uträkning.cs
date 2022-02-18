using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIndividuell
{
    public class Uträkning
    {
       public decimal addition(decimal FörstaTalet, decimal AndraTalet)
        {
            return FörstaTalet + AndraTalet;
            
        }
        public decimal division(decimal FörstaTalet, decimal AndraTalet)
        {

            try
            {
               return FörstaTalet / AndraTalet;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Du försökte dividera med 0");
                Console.WriteLine("Ditt andra tal var"); return AndraTalet;
                
            }
            

        }
        public decimal subtraktion(decimal FörstaTalet, decimal AndraTalet)
        {
            return FörstaTalet - AndraTalet;
        }
        public decimal multiplikation(decimal FörstaTalet, decimal AndraTalet)
        {
            return FörstaTalet * AndraTalet;
        }
       
    }
}
