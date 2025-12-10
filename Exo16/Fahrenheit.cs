using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exo16
{
    public struct Fahrenheit
    {
        public double temperature;

        public Celsius Convert()
        {
            Celsius celsius;
            celsius.temperature = (this.temperature - 32) * (5D/9);
            return celsius;
        }
    }
}
