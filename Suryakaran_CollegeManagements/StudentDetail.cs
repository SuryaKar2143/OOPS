using System;

namespace CollegeManagements
{
  public enum Gender{Default,Male,Female,Other}
    public class StudentDetail
    {
      private static int s_studentID=3000;
      public string StudentID{get;}

      //StudentDetails student1=new String
      
      //Auto Property
      public string StudentName {get;set;}
      public String FatherName {get;set;}
      public Gender Gender { get; set; }

      public DateTime DOB { get; set; }
      public string MailId { get; set; }
      public long PhoneNumber { get; set; }
      public int PhysicsMark { get; set; }
      public int ChemistryMark { get; set; }
      public int MathsMark { get; set; }


      //Default Constructor
      public StudentDetail()
      {
        StudentName="your Name";
        FatherName="Your Father Name";
        Gender=Gender.Default;
        PhysicsMark=0;
        ChemistryMark=0;
        MathsMark=0;
      }


      //parameterized Constructor
      public StudentDetail(string name,string fathername,Gender gender,int physicsmark,int chemistrymark,int mathsmark)
      {
        s_studentID++;
        StudentID="SF"+s_studentID;
        StudentName=name;
        FatherName=fathername;
        Gender=gender;
        PhysicsMark=physicsmark;
        ChemistryMark=chemistrymark;
        MathsMark=mathsmark;
      }

      //Destructor
      ~StudentDetail()
      {
        Console.WriteLine("Destructor Called");

      }

//methods
      public bool CheckEligibility()
      {
        int total;double average;
        Calculate();
        if (average>=75.0)
        {
          return true;
        }
        else{
          return false;
        }

        void Calculate()
        {
          total=PhysicsMark+ChemistryMark+MathsMark;
          average=(double)total/6.0;
        }

      }


      public void Display()
      {
            Console.WriteLine("Student ID = {0}",StudentID);
            Console.WriteLine("Student Name = {0}",StudentName);
            Console.WriteLine("Father's Name = {0}",FatherName);
            Console.WriteLine("Gender = {0}",Gender);
           // Console.WriteLine("Date of Birth = {0}",DOB);
            //Console.WriteLine("Mail ID= {0}",MailId);
            //Console.WriteLine("Phone Number = {0}",student.PhoneNumber);
            Console.WriteLine("Physics Mark = {0}",PhysicsMark);
            Console.WriteLine("Chemistry Mark = {0}",ChemistryMark);
            Console.WriteLine("Maths Mark = {0}",MathsMark);
            
      }

    }
}