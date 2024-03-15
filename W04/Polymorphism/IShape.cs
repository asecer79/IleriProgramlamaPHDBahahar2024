using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W04.Polymorphism
{
    public interface IShape
    {
        void Draw();
    }

    public class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a circle.");
        }
    }

    public class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a square.");
        }
    }


}
