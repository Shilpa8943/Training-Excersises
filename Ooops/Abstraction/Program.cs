using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{

    abstract class Animal          //abstract class....
    {
        
        public abstract void animalSound();  //abstract method....
       
        public void eat()   // normal method.....
        {
            Console.WriteLine("eating .......");
        }
    }

    
    class Dog : Animal
    {
        public override void animalSound()
        {
            
            Console.WriteLine("The dog is barking");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dog obj = new Dog(); // Create a dog object...
            obj.animalSound();  // Call the abstract method...
            obj.eat();  // Call the regular method...

            Console.ReadKey();
        }
    }
}
