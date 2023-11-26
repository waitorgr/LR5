using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB6
{
public class OrdinaryCalc
    {
        private double num1;
        private double num2;

        public OrdinaryCalc()
        {
            
        }

        public double GetNum1()
        {
            return num1;
        }

        public void SetNum1(double value)
        {
            num1 = value;
        }

        public double GetNum2()
        {
            return num2;
        }

        public void SetNum2(double value)
        {
            num2 = value;
        }

        public double Add()
        {
            return num1 + num2;
        }

        public double Div()
        {
            if (num2 != 0)
            {
                return num1 / num2;
            }
            else
            {
                throw new ArgumentException("Ошибка: деление на ноль.");
            }
        }

        public double Mul()
        {
            return num1 * num2;
        }

        public double Sub()
        {
            return num1 - num2;
        }
    }
}
