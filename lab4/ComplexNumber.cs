using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class ComplexNumber
    {
        public double Module { get; private set; } 
        public double Argument { get; private set; }
        public double RealPart { get; private set; }
        public double ImaginaryPart { get; private set; }

        public ComplexNumber()
        {
        }
        public ComplexNumber(double _module, double _argument)
        {
            Module = _module;
            Argument = _argument;
            RealPart = Module * Math.Cos(Argument);
            ImaginaryPart = Module * Math.Sin(Argument);
        }    

        public ComplexNumber Power(double power)
        {
            double newModule = Math.Pow(Module, power);
            double newArgument = Argument * power;

            return new ComplexNumber(newModule, newArgument);
        }
        public static ComplexNumber operator +(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return new ComplexNumber
            {
                RealPart = firstNumber.RealPart + secondNumber.RealPart,
                ImaginaryPart = firstNumber.ImaginaryPart + secondNumber.ImaginaryPart
            };
        }

        public static ComplexNumber operator -(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return new ComplexNumber
            {
                RealPart = firstNumber.RealPart - secondNumber.RealPart,
                ImaginaryPart = firstNumber.ImaginaryPart - secondNumber.ImaginaryPart
            };
        }

        public static ComplexNumber operator *(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            return new ComplexNumber
            {
                RealPart = firstNumber.RealPart * secondNumber.RealPart - firstNumber.ImaginaryPart * secondNumber.ImaginaryPart,
                ImaginaryPart = firstNumber.RealPart * secondNumber.ImaginaryPart + firstNumber.ImaginaryPart * secondNumber.RealPart
            };
        }

        public static ComplexNumber operator /(ComplexNumber firstNumber, ComplexNumber secondNumber)
        {
            double denominator = secondNumber.RealPart * secondNumber.RealPart + secondNumber.ImaginaryPart * secondNumber.ImaginaryPart;
            return new ComplexNumber
            {
                RealPart = (firstNumber.RealPart * secondNumber.RealPart + firstNumber.ImaginaryPart * secondNumber.ImaginaryPart) / denominator,
                ImaginaryPart = (firstNumber.ImaginaryPart * secondNumber.RealPart - firstNumber.RealPart * secondNumber.ImaginaryPart) / denominator
            };
        }
        public string PrintComplexNumber()
        {
            Module = Math.Sqrt(RealPart * RealPart + ImaginaryPart * ImaginaryPart);
            Argument = Math.Atan2(ImaginaryPart, RealPart);

            string trigonometricFormat = $"R=|{Module}|*(Cos({Argument})+Sin({Argument})i)";
            string algebraicFormat = $"R={RealPart}+{ImaginaryPart}i";

            return $"Комплексное число в тригонометрическом виде:\n{trigonometricFormat}\n\nКомплексное число в алгебраическом виде:\n{algebraicFormat}";

        }

    }
}
