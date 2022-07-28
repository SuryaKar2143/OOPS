using System;
using System.IO;
using System.Collections.Generic;
namespace StudentAdmissionNew;
class program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFile();
        Operation.DefaultMethod();
        Operation.MainMenu();
        
    }  
}