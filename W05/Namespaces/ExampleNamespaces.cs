using System;


namespace A
{
    class Person
    {

        public void Method1()
        {
            Console.WriteLine("s");
        }
    }
  
}

namespace B
{
    class Person
    {
        void Method1()
        {
            System.Console.WriteLine("sss");

            global::System.Console.WriteLine("sad");
        }
    }

    namespace System
    {
        public static class Console
        {
            public static void WriteLine(object o)
            {

            }
        }
    }
}




