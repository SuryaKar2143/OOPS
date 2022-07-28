using System;
namespace AccessModifiers
{
    public class Access1
    {
        //Public
        public int publicField=10;
        //Private
        private int privateField=20;
        //Internal
        internal int internalField=300;
        public int PrivateFieldOut()
        {
            return privateField;
        }
        /*
        public int ProtectedAccess1()
        {
            return ProtectedField;

        }    
        */
        public int ProtectedInternalOut()
        {
            return ProtectedInternal;
        }


        
    }
}