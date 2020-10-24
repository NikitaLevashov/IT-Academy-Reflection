using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork_2
{
    class Temperature
    {
        double _fahrenheit;
        public double CurrentСelsiusValue { get; set; }

        public double CurrentFahrenheitValue
        {

            get
            {
                if (_fahrenheit < 0)
                {
                    throw new Exception("Темпуратурa по фаренгeйту не может быть отрицательной!");
                }
                else
                {
                    return _fahrenheit;
                }
              
            }
            set
            {
                _fahrenheit = value;
            }

        }
    }
}
