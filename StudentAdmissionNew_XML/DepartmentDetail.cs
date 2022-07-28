using System;
namespace StudentAdmissionNew
{
    public class DepartmentDetail
    {
        /// <summary>
        /// property Departmentid is used to Identify the Identification of the Department in class of <see cref="DepartmentDetail" />Class's object
        /// </summary>
        private static int s_departmentId=100;
        public string DepartmentId{get;}
        
    /// <summary>
    /// Property DepartmentName is used to identify the Name of the Department <see cref="DepartmentDetail" />Class's object
    /// </summary>
    /// <value></value>
        public string DepartmentName{get; set;}
        /// <summary>
        /// Property NumOfSeats is used to identify the Number of Seats available <see cref="DepartmentDetail" />Class's object
        /// </summary>
        /// <value></value>
        public int NumOfSeats{get;set;}
/// <summary>
/// 
/// </summary>
/// <param name="departmentName">Name of the Department</param>
/// <param name="numOfSeats">Number of Seats Available </param>
        public DepartmentDetail(string departmentName,int numOfSeats)
        {
            s_departmentId++;
            DepartmentId="DID"+s_departmentId;
            DepartmentName=departmentName;
            NumOfSeats=numOfSeats;
        }

        public DepartmentDetail(string data)
        {
            string[] values1=data.Split(',');
            {
              s_departmentId=int.Parse(values1[0].Remove(0,2));
              DepartmentId= values1[0];
              DepartmentName=values1[1];
              NumOfSeats=int.Parse(values1[2]);


            }

        }
        
    }
}