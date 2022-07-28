using System;
namespace GroceryOrder
{
    
    public class PersonalInfo
    {
        public string Name{get;set;}
        public string FatherName{get;set;}
        public long Mobile{get;set;}
        public string Gender{get;set;}
        
        public DateTime DOB{get;set;}
        public string Mail{get;set;}

        public PersonalInfo(string name,string fatherName,long mobile,string gender,DateTime dob,string mail)
        {
            Name=name;
            FatherName=FatherName;
            Mobile=mobile;
            Gender=gender;
            DOB=dob;
            Mail=mail;

        }
        
    }
}