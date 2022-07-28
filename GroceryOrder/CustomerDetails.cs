using System;
using System.Collections.Generic;
namespace GroceryOrder
{
    public  class CustomerDetails:PersonalInfo
    {
        public static int s_customerId=1000;
        public  string CustomerId{get;}
        public double WalletBalance{get;set;}

        

        public CustomerDetails(string name,string fatherName,long mobile,string gender,DateTime dob,string mail):base(name,fatherName,mobile,gender,dob,mail)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            //WalletBalance=WalletBalance;

        }
       

        public void Recharge()
        {
            double WalletBalance=0;
            Console.Write("Enter Amount for Recharge Rs.        :");
            double amount=double.Parse(Console.ReadLine());
            WalletBalance=WalletBalance+amount;

            Console.WriteLine("Your Updated Wallet balance is       :   {0}",WalletBalance);
        }


        
    }
}