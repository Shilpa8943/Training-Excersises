using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enums
{


    enum level
    { 
       low,
        medium,
        high
     

    }
    class Program
    {
        static void Main(string[] args)
        {
            level obj = level.high;
            Console.WriteLine(obj);

            Console.ReadKey();
        }
    }
}
