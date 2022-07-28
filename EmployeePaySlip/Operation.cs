using System;
using System.Collections.Generic;
namespace EmployeePaySlip
{
    public class Operation
    {
        static List<PaySlip> employeeList=new List<PaySlip>();
        static PaySlip currentUser=null;
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
            Console.Write("Enter the Employee Name : ");
        String Name=Console.ReadLine();
        Console.Write("Enter the Employee Designation :");
        String Designation=Console.ReadLine();
        Console.Write("Enter the Employee Gender : ");
        String Gender=Console.ReadLine();
        int locationValue=0;
        bool temp;
       
       
       do{
        Console.Write("Work Location 1.Chennai 2.Madurai 3.Trichy");
        temp=int.TryParse(Console.ReadLine(),out locationValue);

        }while(!temp||!(locationValue>0 && locationValue<4));
        Location location=(Location) locationValue;




        Console.Write("Enter Date of Joining:");
        DateTime DOJ=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
        Console.Write("Enter the Employee's Mail ID : ");
        String MailId=Console.ReadLine();
        
       
   
        PaySlip employee=new PaySlip(Name,Designation,Gender,location,DOJ,MailId);
        employeeList.Add(employee); 
        Console.WriteLine("Your Employee ID= {0}",employee.EmployeeID);
        Login();

        }
        static void Login()
        {
            Console.WriteLine("\nEnter ID for Login:(HDFC3000-HDFC3100) ");
            String ID=Console.ReadLine().ToUpper();
             foreach (PaySlip employee in employeeList)
            {

                if(ID==employee.EmployeeID)
                {
                    currentUser=employee;
                    SubMenu();
                    }
            }
        }

        }
        public static  void SubMenu()
        {
            Console.WriteLine("Sub Menu Called");
            String choice="";
            do
            {
                Console.WriteLine("Select an option 1.Display Details\n2.Salary Calculation\n3.Exit");
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
                        Console.WriteLine("Salary Calculation");
                        currentUser.SalaryCalculation();
                        int salary1=currentUser.SalaryCalculation();;
                        Console.WriteLine("Salary is: {0}",salary1);
                        SubMenu();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Exit Sub Menu");
                        break;
                    } 
                }


            }while(choice=="yes");
        }
    }
}