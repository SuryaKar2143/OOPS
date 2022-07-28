using System;
using System.Collections.Generic;
namespace StudentAdmissionNew
{
    public static class Operation
    {
        public static List<StudentDetail> studentList=new List<StudentDetail>();
        public static List<DepartmentDetail> departmentList=new List<DepartmentDetail>();
        public static  List<AdmissionDetail> admissionList=new List<AdmissionDetail>();

        public static void DefaultMethod()
        {
            StudentDetail student1=new StudentDetail("Ravichandran E","Ettapparaja",new DateTime(1999,11,11),Gender.Male,95,95,95);
            studentList.Add(student1);
            StudentDetail student2=new StudentDetail("Baskaran S","Sethurajan",new DateTime(1999,11,11),Gender.Male,95,95,95);
            studentList.Add(student2);


            DepartmentDetail department1=new DepartmentDetail("EEE",29);
            departmentList.Add(department1);
            DepartmentDetail department2=new DepartmentDetail("CSE",29);
            departmentList.Add(department2);
            DepartmentDetail department3=new DepartmentDetail("MECH",30);
            departmentList.Add(department3);
            DepartmentDetail department4=new DepartmentDetail("ECE",30);
            departmentList.Add(department4);

            AdmissionDetail admission1=new AdmissionDetail("SF3001","DID101",new DateTime(2022,05,11),Status.Admitted);
            admissionList.Add(admission1);
            AdmissionDetail admission2=new AdmissionDetail("SF3002","DID101",new DateTime(2022,05,12),Status.Admitted);



        }

        static StudentDetail currentUser=null;
        public static void MainMenu()
        { 
            
            string option="yes";
            do{
                Console.WriteLine("Main Menu");
                Console.WriteLine("Choose your Option/n1.Registration/n2.Login/n3.Exit");
                int choice=int.Parse(Console.ReadLine());
               
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Registration");
                        Registration();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Login");
                        Login();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Exit Main Menu");
                        option="no";
                        break;
                    }
                }

              }while(option=="yes");
    
        }
                public static void  Registration()
              {
                
                Console.Write("Enter the Student Name : ");
                String studentName=Console.ReadLine();
                Console.Write("Enter the Students Father's Name :");
                String fatherName=Console.ReadLine();
                Console.WriteLine("Enter Your Birthday: ");
                DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
                int genderValue=0;bool temp;
        
                do{
                    Console.Write("Select Your Gender 1.Male 2.Female 3.Others:");
                    temp =int.TryParse(Console.ReadLine(),out genderValue);
        
                    }while(!temp ||!(genderValue>0 && genderValue<4));
                Gender gender=(Gender)genderValue;

      
                Console.Write("Enter the Student's Physics Mark (out of 200) : ");
                int physics=int.Parse(Console.ReadLine());
                Console.Write("Enter the Student's Chemistry Mark (out of 200)  : ");
                int chemistry=int.Parse(Console.ReadLine());
                Console.Write("Enter the Student's Maths Mark (out of 200)  : ");
                int maths=int.Parse(Console.ReadLine());
                StudentDetail student1=new StudentDetail("name","father",dob,gender,physics,chemistry,maths);
                studentList.Add(student1); 
                Console.WriteLine("Your Student ID: {0}",student1.StudentId);

              }

        public static void Login()
        {
                Console.WriteLine("Enter StudentId: ");
                String ID=Console.ReadLine();
                foreach(StudentDetail student in studentList)
                {
                    if(ID==student.StudentId)
                    {
                        currentUser=student;
                        Console.WriteLine("Login Successfull");
                        subMainMenu();

                    }
                }
        }

        public static void subMainMenu()
        {
            
            string option="yes";
            do{
                Console.WriteLine("Sub Main Menu");
                Console.WriteLine("Choose your Option\n1.Show  Details\n2.Check Eligibility \n3.Take Admission\n4.Cancel Admission/n5.My Admission Detail/n6.Exit");
                int choice=int.Parse(Console.ReadLine());
               
                switch(choice)
                {
                    case 1:
                    {
                        Console.WriteLine("Show Detail");
                        ShowDetails();
                        break;
                    }
                    case 2:
                    {
                        Console.WriteLine("Check Eligibility");
                        CheckEligibility();
                        break;
                    }
                    case 3:
                    {
                        Console.WriteLine("Take Admission");
                        TakeAdmission();
                        break;
                    }
                    case 4:
                    {
                        Console.WriteLine("Cancel Admission");
                        CancelAdmission();
                        break;
                    }
                    case 5:
                    {
                        Console.WriteLine("My Admission Detail");
                        MyAdmissionDetails();
                        break;
                    }
                    case 6:
                    {
                        Console.WriteLine("Exit");
                        option="no";
                        break;
                    }
                }

              }while(option=="yes");

            static void ShowDetails()
            {
            
                Console.WriteLine("/n-------student Details-------/n");
                foreach(StudentDetail student in studentList)
                {
                    if(student.StudentId==currentUser.StudentId)
                    {
                Console.WriteLine("student ID       :       {0}",student.StudentId);
                Console.WriteLine("student Name     :       {0}",student.Name);
                Console.WriteLine("Date of Birth    :       {0}",student.DOB);
                Console.WriteLine("Gender           :       {0}",student.Gender);
                Console.WriteLine("Physics Mark     :       {0}",student.Physics);
                Console.WriteLine("Chemistry Mark   :       {0}",student.Chemistry);
                Console.WriteLine("Maths MArk       :       {0}",student.Maths);
                
                    }

                }
            }

            static  bool CheckEligibility()
            {
                foreach(StudentDetail student in studentList)
                {
                    if(student.StudentId==currentUser.StudentId)
                    {
                        
                        {
                        double average=(student.Physics+student.Chemistry+student.Maths)/6.0;
                        if(average>75.0)
                        {
                            return true;
                        }
                        else
                        {
                            return false;
                        }



                    }
                    }
            }return true;
                
            
            
            }


            static void TakeAdmission()
            {
              Console.WriteLine("Take Admission Called");

                Console.WriteLine("/n-----Take Admission Details-------/n");
                foreach(DepartmentDetail department in departmentList)
                {
                
                    Console.WriteLine("Department ID is {0}:",department.DepartmentId);
                    Console.WriteLine("Department Name : {0}",department.DepartmentName);
                    Console.WriteLine("Number of seats : {0}",department.NumOfSeats);
                    
                }
                Console.WriteLine("Enter the Department Id : ");
                string Id=Console.ReadLine();
                foreach(DepartmentDetail department in departmentList)
                {
                    if(Id==department.DepartmentId)
                    {
                        if(department.NumOfSeats>0)
                        {
                            bool eligibility=CheckEligibility();
                            if(eligibility)
                            {
                                Console.WriteLine("You are Eligible");
                            }
                             if(eligibility==true)
                             {
                                Console.WriteLine("You got Admission");
                                department.NumOfSeats--;
                                AdmissionDetail admission1=new AdmissionDetail(currentUser.StudentId,department.DepartmentId,DateTime.Now,Status.Admitted);

                             }   

                            
                        }

                    }
                }




            } 


            static void CancelAdmission()
            {

                foreach(AdmissionDetail admission in admissionList)
                {
                    if(currentUser.StudentId==admission.AdmissionId)
                    {
                        Console.WriteLine("Admission Id : {0}",admission.AdmissionId);
                        Console.WriteLine("Department  Id : {0}",admission.DepartmentId);
                        Console.WriteLine("Student Id : ",admission.StudentId);
                        Console.WriteLine("Admission Date : {0}",admission.AdmissionDate);
                        Console.WriteLine("Admission Status : {0}",admission.Status);

                    }
                    Console.WriteLine("Enter your Admission Id : ");
                    String id=Console.ReadLine();
                    foreach(AdmissionDetail list in admissionList)
                    {
                        if(id==list.AdmissionId)
                        {
                            Console.WriteLine("Admission Cancelled");
                            foreach(DepartmentDetail department in departmentList)
                            {
                                department.NumOfSeats++;
                                list.Status=Status.Cancelled;
                            }
                        }

                    }

                }

            }


            static void MyAdmissionDetails()
            {

                Console.WriteLine("--------------My Admission Details---------------");
                
                foreach(AdmissionDetail admission in admissionList)
                {
                    if(currentUser.StudentId==admission.StudentId)
                    { 
                        Console.WriteLine("Admission ID : {0}",admission.AdmissionId);
                        Console.WriteLine("student ID : {0}",admission.StudentId);
                        Console.WriteLine("Department ID : {0}",admission.DepartmentId);
                        Console.WriteLine("Admission Date  : {0}",admission.AdmissionDate);
                        Console.WriteLine("Admission Status: {0}",admission.Status);

                        

                    }
               
            }

            }

        

        
    }
}
}