using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Inheritance
{
    public class DerivedClass:BaseClass
    {
        public DerivedClass()
        {
            //...
        }

        public DerivedClass(int p1):base(p1)
        {
            //...
        }

        public DerivedClass(int p1, int p2) : base(p1,p2)
        {
            //...
        }
        public DerivedClass(int p1, int p2, int p3) : base(p1, p2, p3)
        {
            //...
        }


        public void DisplayValues()
        {
            Console.WriteLine($"{P1}, {P2}, {P3}");
        }
    }
}
