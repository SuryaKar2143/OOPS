using System;
using System.Collections.Generic;
namespace CollegeManagements
{
    public static  class Operation
    {
        static List<StudentDetail> studentList=new List<StudentDetail>();
        static StudentDetail currentUser=null;
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


        }
        static void Registration()
        {
           
        Console.Write("Enter the Student Name : ");
        String studentName=Console.ReadLine();
        Console.Write("Enter the Students Father's Name :");
        String fatherName=Console.ReadLine();
        int genderValue=0;bool temp;
        
        do{
        Console.Write("Select Your Gender 1.Male 2.Female 3.Others:");
        temp =int.TryParse(Console.ReadLine(),out genderValue);
        
        }while(!temp ||!(genderValue>0 && genderValue<4));
        Gender gender=(Gender)genderValue;

      
        Console.Write("Enter the Student's Physics Mark (out of 200) : ");
        int physicsmark=int.Parse(Console.ReadLine());
        Console.Write("Enter the Student's Chemistry Mark (out of 200)  : ");
        int chemistrymark=int.Parse(Console.ReadLine());
        Console.Write("Enter the Student's Maths Mark (out of 200)  : ");
        int mathsmark=int.Parse(Console.ReadLine());
        StudentDetail student1=new StudentDetail(studentName,fatherName,gender,physicsmark,chemistrymark,mathsmark);
        studentList.Add(student1); 
        Console.WriteLine("Your Student ID: {0}",student1.StudentID);
        Login();
        
 

        }
        static void Login()
        {
        
            Console.WriteLine("Enter ID: ");
            String ID=Console.ReadLine().ToUpper();
        

            foreach (StudentDetail student in studentList)
            {
                if(ID==student.StudentID)
                {
                    currentUser=student;
                    SubMenu();

                
                
            }

        }
       static void SubMenu()
        {
            Console.WriteLine("Sub Menu Called");
            String choice="";
            do{
                Console.WriteLine("Select an option 1.Display Details\n2.Check Eligibility\n3.Main");
                int option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                    {
                        Console.WriteLine("Display Details");
                        currentUser.Display();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Check Eligibility");
                        bool eligibility=currentUser.CheckEligibility();
                        if(eligibility)
                            {
                                Console.WriteLine("He is eligible for admission");
                            }
                        else
                            {
                            Console.WriteLine("He is  not eligible for admission");
                            }
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

}