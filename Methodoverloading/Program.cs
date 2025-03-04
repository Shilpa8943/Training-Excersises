using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methodoverloading
{
    class Program
    {

        static int add(int x,int y)
        {
            return x + y;
        }

        static int add(int x, int y, int z)
        {
            return x + y + z;
        }

        static double add(double x, double y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {

            Console.WriteLine("sum of two integer numbers = " + add(3, 5));
            Console.WriteLine("sum of three integer numbers = " + add(3, 5,8));
            Console.WriteLine("sum of two floating point numbers = " + add(3.2, 5.4));


        }
    }
}
