using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ComplexNumber a = new ComplexNumber(1, 2);
            ComplexNumber b = new ComplexNumber(1, 1);
            ComplexNumber c = new ComplexNumber(3, 4);
            ComplexNumber d = new ComplexNumber(5, 1);
            ComplexNumber R = new ComplexNumber();       
            R = b.Power(3) + ((a+b) / (c-a)) *d;
            Console.WriteLine(R.PrintComplexNumber());
        }
    }
}
