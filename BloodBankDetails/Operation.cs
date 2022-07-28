using System;
using System.Collections.Generic;
namespace BloodBankDetails
{
    public class Operation
    {
        static List<Donor> donorList=new List<Donor>();
        static Donor currentUser=null;
        public static void MainMenu()
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

            static void Registration()
            {
                Console.WriteLine("Registration for New User");
                String option="";
                do{
                Console.Write("Enter Donor Name : ");
                String Name=Console.ReadLine();
                Console.Write("Enter Donor's Gender : ");
                String Gender=Console.ReadLine();
                Console.Write("Enter Donor's  Age : ");
                int Age=int.Parse(Console.ReadLine());
                Console.Write("Enter Donor's Blood Group : ");
                String Group=Console.ReadLine();
                Console.Write("Enter Donor's Mobile Number : ");
                long Mobile=long.Parse(Console.ReadLine());
                Console.Write("Enter Donor's MailId : ");
                String MailId=Console.ReadLine();
        
        
                Donor donor=new Donor(Name,Gender,Age,Group,Mobile,MailId);
                donorList.Add(donor);
        
                Console.WriteLine("\nYour ID {0}",donor.DonorId);
                }while(option=="yes");
                Console.WriteLine("Do you want to Enter Another Detail(yes/no) :");
                option=Console.ReadLine().ToLower();

                Login();

            }
            static void Login()
            {
                Console.WriteLine("Enter Your Donor Id (BB3000-BB3100):");
                String Id=Console.ReadLine().ToUpper();
                foreach(Donor donor in donorList)
                {
                    if(Id==donor.DonorId)
                    {
                        currentUser=donor;
                        SubMainMenu();
                    }
                }


            }



        }
        static void SubMainMenu()
        {
            Console.WriteLine("Choose your Choice 1.Display Details \n2.Eligiblility Check \n3.Next Donation Date\n4.Display ");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine(" Display the Customer Details");
                    currentUser.Display();
                    SubMainMenu();
                    break;
                }
                case 2:
                {
                    Console.WriteLine("Eligiblility Check ");
                    currentUser.Eligibility();
                    SubMainMenu();
                    break;

                }
                case 3:
                {
                    Console.WriteLine("Next Donation date");
                    currentUser.Next();
                    SubMainMenu();
                    break;
                }
                case 4:
                {
                    Console.WriteLine("Exit Sub Main Menu");
                    break;
                }
            }

        }

    }
    }
}
