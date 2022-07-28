using System;
namespace EBbillCalculation
{
    public class BillSilp
    {
        public static int s_meterId=3000;
        public string MeterId{get;}
        public string UserName{get;set;}

        public long MobileNumber{get;set;}
        public string MailId{get; set;}
        public int  UnitUsed{get; set;}
        



        public BillSilp(string userName,long mobileNumber,string mailId)
        {
            s_meterId++;
            MeterId="EB"+s_meterId;
            UserName=userName;
            MobileNumber=mobileNumber;
            MailId=mailId;

        }

        public void Display()
        {
            Console.WriteLine("Meter Id is {0}",MeterId);
            Console.WriteLine("User Name = {0}",UserName);
            Console.WriteLine("Mobile = {0}",MobileNumber);
            Console.WriteLine("Mail Id= {0}",MailId);
        }

        public int CalculateAmount()
        {
        int amount=0;
            
        Console.WriteLine("Enter the Number of Unit Used");
        int UnitUsed=int.Parse(Console.ReadLine());
            if(UnitUsed<100)
            {
                Console.WriteLine(amount);
            }
            else if((UnitUsed>100)&&(UnitUsed<200))
            {
                amount=(UnitUsed-100)*2;

            }
            else if((UnitUsed<400)&&(UnitUsed>=200))
            {
                amount=200+(UnitUsed-200)*4;
            }
            else if(UnitUsed>=400)
            {
                amount=6*UnitUsed;
            }
        return amount;   
        }




    }
}