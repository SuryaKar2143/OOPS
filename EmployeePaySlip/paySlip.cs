using System;

namespace EmployeePaySlip
{
  public enum Location{Default,Chennai,Madurai,Trichy}
    public class PaySlip
    {
      
     private static int s_employeeID=3000;
      public string EmployeeID{get;}
      public string Name {get;set;}
      public string Designation {get;set;}
      public string Gender { get; set; }
      public Location Location{get;set;}
      
      public DateTime DOJ { get; set; }
      public string MailId { get; set; }
      public long PhoneNumber { get; set; }

      public int MonthDays{get; set;}

      public int Leave{get;set;}

      //Default Constructor
      public PaySlip(string name,string designation,string gender,Location location,DateTime doj,string mailId)
      {
        s_employeeID++;
        EmployeeID="HDFC"+s_employeeID;
        Name=name;
        Designation=designation;
        Gender=gender;
        DOJ=doj;
        MailId=mailId;
        Location=location;
      }

      public int SalaryCalculation()
      {
        Console.Write("Enter Number of Days in the Month :");
        int MonthDays=int.Parse(Console.ReadLine());
        Console.Write("Enter Number of Leave Days : ");
        int Leave=int.Parse(Console.ReadLine());
        int salary;
        MonthDays =MonthDays-Leave;
        salary =500*MonthDays;
        return salary;
      }

      public void Display()
      {
            Console.WriteLine("Employee Id is {0}",EmployeeID);
            Console.WriteLine("Employee Name = {0}",Name);
            Console.WriteLine("Designation = {0}",Designation);
            Console.WriteLine("Gender = {0}",Gender);
            Console.WriteLine("Work Location = {0}", Location);
            Console.WriteLine("Date of Joining = {0}",DOJ);
            Console.WriteLine("Mail Id= {0}",MailId);
            
      }

    }
}