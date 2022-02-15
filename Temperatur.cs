using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIndividuell
{
    public class Temperatur
    {

      
        public decimal CelsiusToFarenheit(decimal x)
        {
            return (x * 9) / 5 + 32;
        }
        public decimal FarenheitToCelsius(decimal x)
        {
            return (x - 32) * 5 / 9;
        }
    }
}
