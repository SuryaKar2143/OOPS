using System;
namespace AccessModifiers;
class program
{
    public static void Main(string[] arg)
    {
        Access1 access=new Access1();
        System.Console.WriteLine(access.publicField);
        System.Console.WriteLine(access.PrivateFieldOut());
        System.Console.WriteLine(access.internalField);
        
        
        Access2 access2=new Access2();
        Console.WriteLine(access2.ProtectedAcess2());
        Console.WriteLine(access1.ProtectedInternalOut());

        

    }
}