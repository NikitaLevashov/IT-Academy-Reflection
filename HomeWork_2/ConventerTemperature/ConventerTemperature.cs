using System;

namespace ConventerTemperature
{
    public class ConventerTemperature
    {
        static double value;
        static public double СelsiusOrFahrenheitValue()
        {
            Console.WriteLine("Введите значение температуры: ");

            bool item = double.TryParse(Console.ReadLine(), out value);

            if(item == true)
            {
                return value;
            }
            else
            {
                throw new Exception("Вы ввели некорректное значение!!");
            }
            
        }

        public static double FromСelsiusToFahrenheit (double value)
        {
            double _fahrenheit = (value * 9 / 5) + 32;

            return _fahrenheit;
        }

        public static double FromFahrenheitToСelsius(double value)
        {
            double _celsius = (value - 32) * 5 / 9;

            return _celsius;
        }
        
        public static void FromFahrenheitToСelsiusDisplay(double celsius, double fahrenheit)
        {
            Console.WriteLine($"Конвентирование: {fahrenheit}°F or {String.Format("{0:C2}",celsius)}°C") ;
        }

        public static void FromСelsiusToFahrenheitDisplay(double celsius, double fahrenheit)
        {
           Console.WriteLine($"Конвентирование: {celsius}°C or {String.Format("{0:C2}", fahrenheit)}°F");
        }

    }
}
