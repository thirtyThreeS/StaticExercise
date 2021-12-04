using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticExercise
{
    public class TempConverter
    {
        public static double FahrenheitToCelsius(double f) => (5.0 / 9.0) * (f - 32);
        public static double CelsiusToFahrenheit(double c) => ((9.0 / 5.0) * c) + 32;
        

        
    }
}
