using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomNumber = random.Next(1, 101); // Generates a number between 1 and 100
            Console.WriteLine("Random Number: " + randomNumber);
            Console.ReadKey();
        }
    }
}
