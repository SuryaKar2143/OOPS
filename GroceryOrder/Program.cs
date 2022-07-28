using System;
namespace GroceryOrder;
class program
{
    public static void Main(string[] args)
    {
        Files.Create();
        Files.ReadFiles();
        Operations.MainMenu();
        Files.WriteToFile();
        
    }
}