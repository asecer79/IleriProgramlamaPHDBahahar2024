using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Polymorphism
{
    public class Animal
    {
        public virtual void MakeSound()
        {
            Console.WriteLine("This animal makes a sound.");
        }
    }

    public class Dog : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Dog barks.");
        }
    }

    public class Cat : Animal
    {
        public override void MakeSound()
        {
            Console.WriteLine("Cat meows.");
        }
    }

 

}
