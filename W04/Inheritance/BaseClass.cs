using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Inheritance
{
    public class BaseClass
    {
        public BaseClass()
        {
            //...
        }
        public BaseClass(int p1)
        {
            //...
        }

        public BaseClass(int p1, int p2)
        {
            //...
        }

        public BaseClass(int p1, int p2, int p3)
        {
            //...
        }


        public int P1 { get; set; }
        protected int P2 { get; set; }
        internal int P3 { get; set; }
    }
}
