using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Inheritance
{
    public class Animal
    {
        public Animal(int a)
        {
        }

        public void Eat()
        {
            Console.WriteLine("Animal is eating.");
        }
    }

    public class Shelled : Animal
    {
        public Shelled(int a) : base(a)
        {

        }

        public void Crawl()
        {
            Console.WriteLine("Shelled animals can crawl.");
        }
    }

    public class Mammal:Animal
    {
        public Mammal(int a):base(a)
        {

        }

        public void GiveBirth()
        {
            Console.WriteLine("Mammals give birth.");
        }
    }

    public class Human : Mammal
    {
        public Human(int a) : base(a)
        {

        }

        public void Speak()
        {
            Console.WriteLine("Human speaks.");
        }
    }

    public class Cat : Mammal
    {
        public Cat(int a) : base(a)
        {

        }

        public void Meow()
        {
            Console.WriteLine("Cat is meowing.");
        }
    }

    public class Dog : Mammal
    {
        public Dog(int a) : base(a)
        {

        }

        public void Bark()
        {
            Console.WriteLine("Dog is barking.");
        }
    }
}
