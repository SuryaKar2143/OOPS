using System;
using System.Collections.Generic;
namespace CollegeManagements;
class program
{
    public static void Main(string[] args)
    { 
        //Creating File (List) for admission process to document application (object)
        List<StudentDetail> studentList=new List<StudentDetail>();
        String option="";
        do{


        //Object of first Student
        //StudentDetail student1=new StudentDetail();
        Console.Write("Enter the Student Name : ");
        String studentName=Console.ReadLine();
        Console.Write("Enter the Students Father's Name :");
        String fatherName=Console.ReadLine();
        Console.Write("Select your  Gender :");
        string gender=Console.ReadLine();
        //Console.Write("Enter Date of Birth:");
       // DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
       // Console.Write("Enter the Student's Mail ID : ");
        //String mailid=Console.ReadLine();
        //Console.Write("Enter the Student's Phone Number : ");
        //long PhoneNumber=long.Parse(Console.ReadLine());
        Console.Write("Enter the Student's Physics Mark (out of 200) : ");
        int physicsmark=int.Parse(Console.ReadLine());
        Console.Write("Enter the Student's Chemistry Mark (out of 200)  : ");
        int chemistrymark=int.Parse(Console.ReadLine());
        Console.Write("Enter the Student's Maths Mark (out of 200)  : ");
        int mathsmark=int.Parse(Console.ReadLine());
        StudentDetail student1=new StudentDetail(studentName,fatherName,gender,physicsmark,chemistrymark,mathsmark);
        studentList.Add(student1);  //Adding student 1 details to List after user give the details
       
        
        Console.Write("Do you Want to enter your detail :");
        option=Console.ReadLine().ToLower();

        }while(option=="yes");

        Console.WriteLine("Enter ID: ");
        String ID=Console.ReadLine().ToUpper();
        

        foreach (StudentDetail student in studentList)
        {
            if(ID==student.StudentID)
            {

            student.Display();
            bool eligibility=student.CheckEligibility();
            if(eligibility)
            {
                Console.WriteLine("He is eligible for admission");
            }
            else
            {
                Console.WriteLine("He is  not eligible for admission");
            }
            }
        }

    }
}
