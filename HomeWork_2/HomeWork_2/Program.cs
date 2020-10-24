using System;
using System.Reflection;

namespace HomeWork_2
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Assembly asm = Assembly.LoadFrom(@"C:\Users\Lenovo\source\repos\HomeWork_2\ConventerTemperature\bin\Debug\netcoreapp3.1\ConventerTemperature.dll");

                var temperature = new Temperature();

                Type t = asm.GetType("ConventerTemperature.ConventerTemperature", true, true);

                object obj = Activator.CreateInstance(t);


                Console.WriteLine("Из Фаренгейта по Цельсию\n");


                MethodInfo methodInfo = t.GetMethod("СelsiusOrFahrenheitValue");

                MethodInfo methodInfo1 = t.GetMethod("FromFahrenheitToСelsius");

                MethodInfo methodInfo2 = t.GetMethod("FromFahrenheitToСelsiusDisplay");

                temperature.CurrentFahrenheitValue = (double)methodInfo.Invoke(obj, null);

                temperature.CurrentСelsiusValue = (double)methodInfo1.Invoke(obj, new object[] { temperature.CurrentFahrenheitValue });

                methodInfo2.Invoke(obj, new object[] { temperature.CurrentСelsiusValue, temperature.CurrentFahrenheitValue });


                Console.WriteLine("\nИз Цельсия по Фаренгейту\n");


                MethodInfo methodInfo3 = t.GetMethod("СelsiusOrFahrenheitValue");

                MethodInfo methodInfo4 = t.GetMethod("FromСelsiusToFahrenheit");

                MethodInfo methodInfo5 = t.GetMethod("FromСelsiusToFahrenheitDisplay");

                temperature.CurrentСelsiusValue = (double)methodInfo3.Invoke(obj, null);

                temperature.CurrentFahrenheitValue = (double)methodInfo4.Invoke(obj, new object[] { temperature.CurrentFahrenheitValue });

                methodInfo5.Invoke(obj, new object[] { temperature.CurrentСelsiusValue, temperature.CurrentFahrenheitValue, });

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }
    }
}
