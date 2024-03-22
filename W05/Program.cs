using System.Collections;
using A;
using B;
using W05.ExtensionMethods;
using W05.OperatorOverloading;

namespace W05
{

    class Program
    {
        static void Main(string[] args)
        {
            //var c1 = new ComplexNumber(1, 1); // c1 = 1+i
            //var c2 = new ComplexNumber(3, -5); // c2 = 3+5i
            //var c3 = c1.Sum(c2);  // 1 + 3  + (1 + 5)i = 4 + 6i
            //var c4 = c1.Subtract(c2);
            //var c5 = c1.Multiply(c2);
            //var c6 = c1.Divide(c2);
            //var mod = c1.Sum(c2).Multiply(c3).Divide(c6).Modulus();
            //var c7 = c6.Power(200);
            //Console.WriteLine(c1);
            //Console.WriteLine(c2);
            //Console.WriteLine($"({c1})x({c2}) = {c1.Multiply(c2)}");


            //var c1 = new Complex(1, 1);
            //var c2 = new Complex(2, -3);
            //var res = c1 + c2;
            //Console.WriteLine(res);
            //res = c1 - c2;
            //Console.WriteLine(res);
            //res = c1 * c2;
            //Console.WriteLine(res);
            //res = c1 / c2;
            //Console.WriteLine(res);
            //Console.WriteLine(c1.Modulus());
            //Console.WriteLine(c1.Power(15));


            //Anonymous data types
            //var person = new
            //{
            //    Name = "Aydın",
            //    Age =45,
            //    Salary = 1000,
            //    Number1 = new ComplexNumber(1,1),
            //};
            //Console.WriteLine(person.Number1.Real);

            ////tuple
            //var data = (1, 5);
            //Console.WriteLine(data.Item1);
            //var data2 = (b:1, d:5);
            //Console.WriteLine(data2);
            //var res = GetValue();
            //Console.WriteLine(res.a);


            //box ve unbox // primitive, reference types and reference types

            ////boxing
            //int a = 15;
            //object o =a.ToString();

            ////unboxing
            //var b = (int)o;

            //Console.WriteLine(b+1);



            //int num = 100;
            //object obj=0;

            //// Boxing
            //var watch = System.Diagnostics.Stopwatch.StartNew();
            //for (int i = 0; i < 1000000; i++)
            //{
            //    obj = num; // Her döngüde boxing yapılıyor
            //}
            //watch.Stop();
            //Console.WriteLine($"Boxing süresi: {watch.ElapsedMilliseconds} ms");

            //// Unboxing
            //watch.Restart();
            //for (int i = 0; i < 1000000; i++)
            //{
            //    num = (int)obj; // Her döngüde unboxing yapılıyor
            //}
            //watch.Stop();
            //Console.WriteLine($"Unboxing süresi: {watch.ElapsedMilliseconds} ms");


            //ArrayList list = new ArrayList();
            //list.Add(10); // Boxing
            //list.Add(20.5f); // Boxing

            //// Unboxing
            //int firstItem = (int)list[0];
            //float secondItem = (float)list[1];


            ////cast  primitive tiplerdeki ver i dönüşümüdür.
            //decimal aa = 1.3M;

            //int bb = (int)aa;



           // PersonFromA person = new PersonFromA();

           Console.WriteLine(1);


        }

        public static (string a, int b, double c) GetValue()
        {
            A.Person person1 = new A.Person();
            B.Person person2 = new B.Person();

            return ("A", 1, 2);
        }
    }


}


