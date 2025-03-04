using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 0;

            try
            {
                int result = a / b;
                Console.WriteLine("result" + result);
            }

            catch (DivideByZeroException e)
            {
                Console.WriteLine("error : " + e.Message);
            }
            Console.ReadKey();




            //    try
            //    {
            //        ValidateNumber(-10);
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Error: " + e.Message);
            //    }
            //}

            //static void ValidateNumber(int number)
            //{
            //    if (number < 0)
            //    {
            //        throw new InvalidOperationException("Number cannot be negative!");
            //    }
            //    Console.WriteLine("Valid number: " + number);
        }
        }

    }


