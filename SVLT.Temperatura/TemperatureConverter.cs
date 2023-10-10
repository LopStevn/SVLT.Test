using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SVLT.Temperatura
{
    public class TemperatureConverter
    {
        public double CelsiusToFarenheit(double celsius)
        {
            return (celsius * 9 / 5) + 32;
        }

        public double FarenheitToCelsius(double farenheit)
        {
            return (farenheit - 32) * 5 / 9;
        }
    }
}
