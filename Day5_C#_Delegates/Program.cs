using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    class Program
    {
        public delegate int MathOperation(int a, int b);
        static int Add(int number1, int number2)
        {
            return number1 + number2;
        }

        static int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        static int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        static int Division(int number1, int number2)
        {
            return number1 / number2;

        }
        static void Main(string[] args)
        {
            MathOperation resultSum = new MathOperation(Add);
            Console.WriteLine("sum=" + resultSum(10, 15));

            MathOperation resultSubtract = Subtract;
            Console.WriteLine("Difference=" + resultSubtract(30, 15));

            MathOperation resultMultiply = Multiply;
            Console.WriteLine("Multiplication =" + resultMultiply(10, 15));

            MathOperation resultDiv = Division;
            Console.WriteLine("Division=" + resultDiv(34, 12));


        }
    }
}
