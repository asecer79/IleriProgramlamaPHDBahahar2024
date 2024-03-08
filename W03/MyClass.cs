using System.Security.Cryptography;

namespace W03
{
    public partial class MyClass
    {
        //Members

        //01-Fields
        public int _field1 = 12;
        public string field2 = "Aydın";
        private Program _program;

        //02-Properties
        public int Prop1    //classical version
        {
            get
            {
                return _field1;
            }
            set
            {
                _field1 = value;
            }

        }
        public string Name { get; set; }  //short version
        public double PI { get; } = 3.14; //readonly

        //03-Methods
        public string M1()
        {
            ///... body
            return "";
        }


        //04-Constructor Methods
        public MyClass()  //default 
        {
            M3();
        }
        public MyClass(int a)  //default 
        {
            //.....
        }
        public MyClass(int a,string b)  //overloaded 1 
        {
            //.....
        }
        public MyClass(int a, string b,bool c)  //overloaded 2 
        {
            //.....
        }

        //05-Destructor Methods
        ~MyClass()
        {
            //.....
        }

        //06-Events
        public event EventHandler Changed;

        //07-Indexer
        public int this[int index]
        {
            get { return 0;}
            set{}
        }

        //08-Operator Overloading
        public static MyClass operator +(MyClass a, MyClass b)
        {
            return new MyClass() { _field1 = a._field1 + b._field1 };
        }

        //09-Type Conversion 
        public static explicit operator int(MyClass x)
        {
            return x._field1;
        }

        //10-Constant
        public const int Default = 0;

        //11-Static Members
        public static int s1 = 5;

        //12-Readonly Members
        public readonly int r1;

        public static void M2()
        {
        }

        //13-Partial methods and Classes
        public partial void MPartial();
    }

    public partial class MyClass
    {
        public partial void MPartial()
        {
            //
        }
        public void M3()
        {
            M1();
        }
    }

    public partial class MyClass
    {

        public void M4()
        {
            M1();
        }
    }
}
