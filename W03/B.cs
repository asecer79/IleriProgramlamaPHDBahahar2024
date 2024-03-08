namespace W03
{
    public class B : A
    {
        public B()
        {
            //fAPrivate = 7; //same assembly any other derived, private: N
            fAProtected = 7; //same assembly any other derived, protected: Y
            fAInternal = 7; //same assembly any other derived, internal: Y
            fAProtectedInternal = 7; //same assembly any other derived, ProtectedInternal: Y
            fAPublic = 7; //same assembly any other derived, Public: Y
        }
    }
}
