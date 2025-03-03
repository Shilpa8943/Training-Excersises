using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basics
{
    class Program
    {
        static void Main(string[] args)
        {



            {
            // Output Method......

                Console.WriteLine("hello world");


            // Variables (declaration) .......

                int num1 = 5;
                double num2 = 5.99;
                char letter = 'D';
                string word = "Hello";

            // display variables.......

                Console.WriteLine("integer value:" + num1);
                Console.WriteLine("double value :" + num2);
                Console.WriteLine("char value :" + letter);
                Console.WriteLine("word value :" + word);


            // Constants.......

                const int myNum = 20; // can't reassign values.....

            // identifiers.........

                // int n = 5;   // hard to understand ....
                // int number = 5;  // easy to understand (unique name to identify variables easly)....

            // datatypes.........

                int a = 50;           //type : int
                Console.WriteLine(a);

                long b = 1234;        // type : long
                Console.WriteLine(b);

                float c = 3.14f;      // type: float
                Console.WriteLine(c);

                double d = 8.275d;     // type: double
                Console.WriteLine(d);

                char ch = 'A';         //type: char
                Console.WriteLine(ch);

                string str = "Hii..."; // type:string
                Console.WriteLine(str);

                bool isInt = true;
                bool isDouble = false;      // type : bool
                Console.WriteLine(isInt);   // Outputs True
                Console.WriteLine(isDouble);


            // typecasting......

                int myInt = 9;
                double myDouble = myInt;       // implicit casting(automatic)..

                Console.WriteLine(myInt);      // 
                Console.WriteLine(myDouble);

                double myDouble2 = 5.25;
                int myInt2 = (int)myDouble2;    // explicit casting(manual)..

                Console.WriteLine(myDouble2);
                Console.WriteLine(myInt2);

            // input method..

                
                Console.WriteLine("Enter name:"); 
                
                string name = Console.ReadLine();
                
                Console.WriteLine("name is: " + name);


                Console.ReadKey();



            }
        }


    }
}

