using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basics2_operators
{
    class Program
    {
        static void Main(string[] args)
        {

            // operators.........

            // 1)arithmetic operator....

            int num1 = 25;
            int num2 = 5;

            Console.WriteLine("sum=" + (num1 + num2));  // addition
            Console.WriteLine("difference=" + (num1 - num2));  //substraction...
            Console.WriteLine("product=" + (num1 * num2));  // multiplication
            Console.WriteLine("division=" + (num1 / num2));  // division
            Console.WriteLine("reminder=" + (num1 % num2));  // modulus

            // 2) assignment opratotr.....

            int a = 15; //assignment operator..
            Console.WriteLine(a);
            a += 5;     // addition assignment..
            Console.WriteLine(a);
            a -= 7;     //subtraction assignment..
            Console.WriteLine(a);
            a *= 10;    // multi assign..
            Console.WriteLine(a);
            a /= 3;     //div assign..
            Console.WriteLine(a);
            a %= 6;     // mod assign..
            Console.WriteLine(a);
            a &= 3;     // bitwise and..
            Console.WriteLine(a);
            a |= 5;     //or..
            Console.WriteLine(a);


            // 3) logical operator....

            int x = 5;
            Console.WriteLine(x > 0 && x < 10); // AND: both condition true ? returns true.

            int y = 8;
            Console.WriteLine(x > 0 && x < 10); // OR:  return true one of the statement true


            int z = 5;
            Console.WriteLine(!(x < 10)); // NOT : reverse the result..


            // 4)comparison operator.....


            int p = 30;
            int q = 10;
            Console.WriteLine(x == y);  //equqlto..
            Console.WriteLine(x != y);  // not equal.
            Console.WriteLine(x > y);   // gt..
            Console.WriteLine(x < y);   // lt..
            Console.WriteLine(x >= y);  // gt or equal to..
            Console.WriteLine(x <= y);  // lt or equalto..

            //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            // Strings...........

            String name = "shilpa";  //create simple string
            Console.WriteLine(name);

            Console.WriteLine("length of the string is: " + name.Length);  //find length of the string

            String str1 = "hello";

            Console.WriteLine(str1 + name);  // concat two strings

            string str2 = "Hello World";

            Console.WriteLine(str2.ToUpper());  //convert to upper
            Console.WriteLine(str2.ToLower());  // convert to lower

            string firstName = "peter";
            string lastName = "mathan";
            string fullName = $"my name is: {firstName} {lastName}";  //interpolation
            Console.WriteLine(fullName);

            Console.WriteLine(firstName[3]);  //accessing values using indexing method..

            //------------------------------------------------------------------------------------------------------------------------------------------------------------------------------//

            // arrays ......................................

            String[] fruits = {"apple", "orange", "banana", "grapes"};  //create array

            Console.WriteLine(fruits.Length); //length of the array
     
            Console.WriteLine(fruits[3]); // access array values

            fruits[0] = "pineapple";

            for (int i = 0; i <fruits.Length; i++)
            {
                Console.WriteLine(fruits[i]);   // change array elements
            }


            String[] cars;
            cars = new string[] { "Volvo", "BMW", "Ford" };


            for(int i=0;i<cars.Length;i++)
            {
                Console.WriteLine(cars[i]);
            }

            int[] numbers = { 2, 5, 3, 1, 7 };

            Array.Sort(numbers);  // sorting in an array
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]+"\t");
            }

            Console.WriteLine(numbers.Max());  // returns the largest value
            Console.WriteLine(numbers.Min());  // returns the smallest value
            Console.WriteLine(numbers.Sum());  // returns the sum of e

            
















            Console.ReadKey();
        }
    }
}
