using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcIndividuell
{
    public class Temperatur
    {

      
        public decimal CelsiusToFarenheit(decimal CelsToFar)
        {
            return (CelsToFar * 9) / 5 + 32;
        }
        public decimal FarenheitToCelsius(decimal FarToCels)
        {
            return (FarToCels - 32) * 5 / 9;
        }
    }
}
