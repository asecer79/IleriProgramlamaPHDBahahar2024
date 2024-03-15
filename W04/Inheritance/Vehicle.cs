using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Inheritance
{
    public class Vehicle
    {
        public string? Make { get; set; }
        public string? Model { get; set; }

        public virtual  void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}");
        }
    }
}
