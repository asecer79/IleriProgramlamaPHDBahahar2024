namespace W03
{
    public class A
    {
        public A()
        {
            fAPrivate = 7; //within class, private: Y
            fAProtected = 7;//within class, protected: Y
            fAInternal = 7;//within class, internal: Y
            fAProtectedInternal = 7;//within class, ProtectedInternal: Y
            fAPublic = 7;//within class, public: Y
        }

        private int fAPrivate = 5;
  
        protected int fAProtected = 5;

        internal int fAInternal = 5;

        protected internal int fAProtectedInternal = 5;

        public int fAPublic = 5;

    }
}
