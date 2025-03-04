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
            int guess = 0;

            Console.WriteLine(" choose a number between 1 and 100.");

            while (guess != randomNumber)
            {
                Console.Write("Enter new guess: ");
                string newguess = Console.ReadLine();
                guess = int.Parse(newguess);
                
                    if (guess < randomNumber)
                    {
                        Console.WriteLine("Too low! \n");
                    }
                    else if (guess > randomNumber)
                    {
                        Console.WriteLine("Too high! \n");
                    }
                    else
                    {
                        Console.WriteLine(" You guessed the number correctly.");
                    }
                Console.WriteLine("random number" + randomNumber);
            }
           
        }
        }

    }

