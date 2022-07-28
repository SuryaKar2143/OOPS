using System;
using System.Collections.Generic;
namespace EBbillCalculation
{
    public class Operation
    {
        static List<BillSilp> billList=new List<BillSilp>();
        static BillSilp currentUser=null;
        public static void Mainmenu()
        {
            
            Console.WriteLine("Main Menu Called");
            Console.WriteLine("Choice Your Option:\n 1.Registration\n2.Login\n3.Exit Main Menu");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine("\nRegistration");
                    Registration();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("\nLogin");
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exit Main Menu");
                    break;
                }


            }
            
            static void Registration()
            {
                Console.Write("Enter UserName : ");
                String UserName=Console.ReadLine();
                Console.Write("Enter Mobile Number :");
                long MobileNumber=long.Parse(Console.ReadLine());
                Console.Write("Enter MailId : ");
                String MailId=Console.ReadLine();



                BillSilp bill=new BillSilp(UserName,MobileNumber,MailId);
                billList.Add(bill);
                Console.WriteLine("your Meter Id is {0}",bill.MeterId);
                Login();
            }

            static void Login()
            {
                Console.Write("Enter MeterId (EB3000-EB3100)= ");
                String Id=Console.ReadLine();
                foreach(BillSilp bill in billList)
                {
                    if(Id==bill.MeterId)
                    {
                        Console.WriteLine("Successfully Login");
                        currentUser=bill;
                        SubMain();
                    }
                }


            }

        }
        static void SubMain()
        {
            Console.WriteLine("Choose your Choice 1.Display Details \n2.Calculate Electricity Bill \n3.Exit Sub Menu ");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine(" Display the Customer Details");
                    currentUser.Display();
                    SubMain();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Calculate the Electricity Bill");
                    currentUser.CalculateAmount();
                    int amount1=currentUser.CalculateAmount();
                    Console.WriteLine("Total Bill Amount  is Rs.{0}",amount1);
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exit SubMain");
                    break;
                }
            }

        }

    }
}
