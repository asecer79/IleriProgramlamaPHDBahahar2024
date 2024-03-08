using W03;

namespace W03OtherAssembly
{
    public class C:A
    {
        public C()
        {
            //fAPrivate = 7; //other assembly any other derived, private: N
            fAProtected = 7; //other assembly any other derived, protected: Y
            //fAInternal = 7; //other assembly any other derived, internal: N
            fAProtectedInternal = 7; //other assembly any other derived, ProtectedInternal: Y
            fAPublic = 7; //other assembly any other derived, Public: Y
        }
    }
}
