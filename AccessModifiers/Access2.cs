using System;
using System.Collections.Generic;
namespace AccessModifiers
{
    public class Access2:Access1
    {
        public int ProtectedAccess2()
        {
            Access1 access=new Access1();
            Console.WriteLine(access.publicField);
            Console.WriteLine(publicField);
            Console.WriteLine(internalField);
            return protectField;
        }

    }
}