
namespace W03
{
    class Program
    {
        static void Main(string[] args)
        {

            A a = new A();

            //a.fAPrivate = 7; //same assembly any other, private: N
            //a.fAProtected = 7; //same assembly any other, protected: N
            a.fAInternal = 7; //same assembly any other, internal: Y
            a.fAProtectedInternal = 7; //same assembly any other, ProtectedInternal: Y
            a.fAPublic = 7; //same assembly any other, Public: Y








            //var myClass1 = new MyClass(); //getting instance, create an object
            //Console.WriteLine(myClass1.Name);

            //var myClass2 = new MyClass(5);
            //var myClass3 = new MyClass(6,"Ayşe");
            //var myClass4 = new MyClass(6, "Mehmet",true);

            //Console.WriteLine(myClass1[1]);

            //var sum = myClass1 + myClass2;
            //Console.WriteLine(sum._field1);

            //var myClass5 = new MyClass();

            //var res = 1 + (int)myClass5;


            ////object direct initializer
            //MyClass myClass6=new MyClass();
        }
    }
}
