using System;
namespace Account
{
    public class CustomerDetail
    {
        private int s_customerId=1000;
        public String CustomerId{get;}
        public String Name{get;set;}
        public String Gender{get;set;}
        public String MailId{get;set;}
        public long MobileNumber{get;set;}
        public DateTime DOB{get;set;}
        public int Balance{get;set;}


        public CustomerDetail(String name,String gender,String mailId,long mobileNumber,DateTime dob)
        {
            s_customerId++;
            CustomerId="SBI"+s_customerId;
            Name=name;
            Gender=gender;
            MailId=mailId;
            MobileNumber=mobileNumber;
            DOB=dob;

        }



        public void Display()
        {
            Console.WriteLine("\nCustomer ID = "+CustomerId);
            Console.WriteLine("\nName = "+Name);
            Console.WriteLine("\nGender = "+Gender);
            Console.WriteLine("\nMail Id = "+MailId);
            Console.WriteLine("\nMobile Number = "+MobileNumber);
            Console.WriteLine("\nDate of Birth = "+DOB);

        }

        public int Deposite(int depositeAmount)
        {
            int Balance=0;
            Balance=Balance+depositeAmount; 
            return Balance;

        }
        public int WithDrawn(int withdrawnAmount)
        {
            
            Balance=Balance-withdrawnAmount; 
            return Balance;

        }


        public void ShowBalance()
        {
            Console.WriteLine("Your Savings Balance Amount is : {0}",Balance);

        }


    }
}