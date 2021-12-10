using System;

namespace StaticExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var celsius = TempConverter.FahrenheitToCelsius(68);
            Console.WriteLine($"Celcius {celsius}");
            Console.WriteLine("------------");
            var fahrenheit = TempConverter.CelsiusToFahrenheit(20);
            Console.WriteLine($"Fahrenheit {fahrenheit}");





        }
    }
}
