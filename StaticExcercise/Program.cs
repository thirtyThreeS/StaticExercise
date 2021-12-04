//Exercise 1: Create a new console app called StaticExercise.Now create a static class called TempConverter.
//The class should have at least 2 methods, one called FahrenheitToCelsius that will require a double as a parameter 
//and return a double, the other CelsiusToFahrenheit which will also require a double as a parameter and return a double. 
//Fill out these methods and call them in your Program.cs file. Make sure they’re accurate! 

namespace StaticExercise
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("84 degrees C = " + TempConverter.CelsiusToFahrenheit(84) + " F");
            Console.WriteLine("180 degrees F = " + TempConverter.FahrenheitToCelsius(180) + " C");

            Console.ReadLine();
            Console.WriteLine("Al.. most.. cri.. ti.. cal.. GP... U... temps. Boo.. sting... fans... to ...//// 100 .... %");
        }
    }
}