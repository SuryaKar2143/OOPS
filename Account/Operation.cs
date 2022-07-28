using System;
using System.Collections.Generic;
namespace Account
{
    public static class Operation
    {
        static List<CustomerDetail> customerList=new List<CustomerDetail>();
        static CustomerDetail currentUser=null;
        public static void MainMenu()
        {
            Console.WriteLine("Main Menu Called");
            String choice="";
            do
            {
            Console.WriteLine("Select option 1.Registration 2.Login 3.Exit");
            int option=int.Parse(Console.ReadLine());
            switch(option)
            {
                case 1:
                {
                    Console.WriteLine("Registration Selected");
                    Registration();
                    break;

                }
                case 2:
                {
                    Console.WriteLine("Login Selected");
                    Login();
                    break;
                }
                case 3:
                {
                    Console.WriteLine("Exit Main Menu");
                    choice="no";
                    break;
                }


            }
            }while(choice=="yes");
            static void Registration()
            {
                Console.Write("Enter Your Name =");
                String name=Console.ReadLine();
                Console.Write("Enter Gender =");
                String gender=Console.ReadLine();
                Console.Write("Enter mailId =");
                String mailId=Console.ReadLine();
                Console.Write("Enter Mobile Number =");
                long mobileNumber=long.Parse(Console.ReadLine());
                Console.Write("Enter Your Date of Birth(dd/mm/yyyy)");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);


                CustomerDetail customer=new CustomerDetail(name,gender,mailId,mobileNumber,dob);
                customerList.Add(customer);
                Console.WriteLine("Your ID = {0}", customer.CustomerId);
                Login();
            }
            static void Login()
            {
                Console.WriteLine("\nLogin Page");
                Console.WriteLine("\nEnter Your Id for Checking(SBI1000-SBI2000) = ");
                String id=Console.ReadLine().ToUpper();


                foreach(CustomerDetail customer in customerList)
                {
                    if(id==customer.CustomerId)
                    {
                            currentUser=customer;
                            SubMenu();
                    }
                }

            }
        }

        
        static void SubMenu()
        {
            Console.WriteLine("Sub Menu Called");
            String choice="";
            do{
                Console.WriteLine("\nSelect an option 1.Display Details\n2.Deposite\n3.WithDrawn\n4.Show Balance\n5.Exit");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Display Details");
                        currentUser.Display();
                        SubMenu();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Deposite Amount");
                        Console.WriteLine("Enter the Deposite Amount = Rs. ");
                        int amount1=int.Parse(Console.ReadLine());
                        currentUser.Balance=currentUser.Deposite(amount1);
                        SubMenu();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("WithDrawn Amount");
                        Console.WriteLine("Enter the Withdrawn Amount = Rs. ");
                        int amount2=int.Parse(Console.ReadLine());
                        currentUser.Balance=currentUser.WithDrawn(amount2);
                        SubMenu();
                        break;
                    } 
                    case 4:
                    {
                        Console.WriteLine("Show Balance");
                        currentUser.ShowBalance();
                        SubMenu();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("Exit sub Main Menu");
                        break;
                    }
                }

            }while(choice=="yes");

      


        }

        
    }


}
        
    
