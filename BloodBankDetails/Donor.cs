using System;
using System.Linq;
using System.Collections.Generic;
namespace BloodBankDetails
{
    public class Donor
    {



        //Auto Property
        private static int s_donorId=3000;
        public string DonorId{get;}
        public string Name{get;set;}
        public string Gender{get;set;}
        public int Age{get;set;}
        public string Group{get;set;}
        public long Mobile{get;set;}
        public string MailId{get;set;}
        public DateTime LastDate{get;set;}
        public int Count{get;set;}
        public DateTime NextDate{get;set;}


        //Constructor
        public Donor(string name,string gender,int age,string group,long mobile,string mailId)
        {
            s_donorId++;
            DonorId="BB"+s_donorId;
            Name=name;
            Gender=gender;
            Age=age;
            Group=group;
            Mobile=mobile;
            MailId=mailId;


        }

        ///Method1
        public void Display()
        {
            Console.WriteLine("Donor Id : {0}",DonorId);
            Console.WriteLine("Donor Name : {0}",Name);
            Console.WriteLine("Donor Gender : {0}",Gender);
            Console.WriteLine("Donor Age : {0}",Age);
            Console.WriteLine("Donor Blood Group : {0}",Group);
            Console.WriteLine("Donor Mobile Number : {0}",Mobile);
            Console.WriteLine("Donor Mail Id  : {0}",MailId);


        }


        //Method 2
        public void Eligibility()
        {
            Console.Write("Enter the Donor's RBC Count : ");
            int rcb=int.Parse(Console.ReadLine());
            Console.Write("Enter the Donor's Body Weight : ");
            int Weight=int.Parse(Console.ReadLine());
            Console.Write("Enter the Donor's Blood Pressure : ");
            int bp=int.Parse(Console.ReadLine());

            if((rcb>13)&&(Weight>55)&&(bp>30)&&(bp<100))
            {
                Console.WriteLine("Donor is Eligible for Blood Donate");
                DateTime LastDate=DateTime.Now;
                Count++;
                Console.WriteLine("Donor's Last Blood Donation Date : {0}",LastDate);
            }
            else
            {
                
                Console.WriteLine("Donor is Not Eligible for Blood Donate");
            }
            
        }
        public void Next()
        {
            NextDate=DateTime.Now.AddDays(90);
            Console.WriteLine("Next Eligible Date for Donate Blood is : {0}", NextDate);

        }

    }
}