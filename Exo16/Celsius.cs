using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo16
{
    public struct Celsius
    {
        public double temperature;

        public Fahrenheit Convert()
        {
            Fahrenheit fahrenheit;
            fahrenheit.temperature = (temperature * (9 / 5D)) + 32;
            return fahrenheit;
        }
    }
}
