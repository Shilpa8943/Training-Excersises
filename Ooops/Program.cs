using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ooops
{
    
    //inheritance....................
    class Animal     //parent class
    {

        String color = "red";   // fields

        public void behaviour() // methods
        {
            Console.WriteLine("animal have different behaviour");
        }

        class Dog : Animal   //child class 
        {
            String color = "black";   //fields
            public void behaviour()  // override method
            {
                Console.WriteLine("dogs are barking");
            }

            public void eat()
            {
                Console.WriteLine("eating.........");
            }
            static void Main(string[] args)
            {
                Dog obj = new Dog();   //create object of child and parent class
                Animal A = new Animal();
               
                
                A.behaviour();    // call method

                Console.WriteLine("dog color is:" + obj.color);  

                obj.behaviour();
                obj.eat();
            }
        }
    }
}
