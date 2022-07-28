using System;
using System.Collections.Generic;
namespace Ecommerce
{
    public  class CustomerDetail
    {
        private  static int s_customerId=1000;
        public string CustomerId{get;}
        public string Name{get;set;}
        public string City{get;set;}
        public long Mobile{get;set;}
        public double WalletBalance{get;set;}
        public string EmailId{get;set;}

        public CustomerDetail(string name,string city,long mobile,string mailId)
        {
            s_customerId++;
            CustomerId="CID"+s_customerId;
            Name=name;
            City=city;
            Mobile=mobile;
            EmailId=mailId;

        }
        public void WalletRecharge()
        {
            Console.WriteLine("Enter the amount do you want to Recharge the Wallet :");
            int amount=int.Parse(Console.ReadLine());
            
            WalletBalance=amount+WalletBalance;

        }

    }
}