using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Inheritance
{
    //single inheritance
    public class Car : Vehicle //=>   Car:Vehicle =>  Derived:Base, SubClass:SuperClass, Child:Parent
    {
        public Car()
        {
            
        }
        public int NumberOfDoors { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}");
        }

        public void Drive()
        {
            //...


        }
    }
}
