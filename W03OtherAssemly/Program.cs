using W03;

namespace W03OtherAssembly
{

    class Program
    {
        static void Main(string[] args)
        {
           A a = new A();
            //a.fAPrivate = 7; //outside assembly any in other class, private: N
            // a.fAProtected = 7; //outside assembly any in other class, protected: N
            //a.fAInternal = 7; //outside assembly any in other class, internal: N
            //a.fAProtectedInternal = 7; //outside assembly any in other class, ProtectedInternal: N
            a.fAPublic = 7; //outside assembly any in other class, Public: Y
        }
    }

}

