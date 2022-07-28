using System;
namespace StudentAdmissionNew
{
    /// <summary>
    /// Used to store the status of the admission 
    /// </summary>
    public enum Status{Default,Admitted,Cancelled}
    public class AdmissionDetail
    {
        /// <summary>
        /// used to store the admission id 
        /// </summary>
        private static int s_admissionId=1000;
        /// <summary>
        /// Property Admission Id used to Uniquely identify a <see cref="AdmissionDetail" />Class's object
        /// </summary>
        /// <value></value>
        public string AdmissionId{get;}
        /// <summary>
        /// Property StudentId used to store the user id <see cref="AdmissionDetail"/>Class's object
        /// </summary>
        /// <value></value>
        
        public string StudentId{get;}
        /// <summary>
        /// Property DepartmentId used to identify the department Number<see cref="AdmissionDetail"/>Class's object
        /// </summary>
        /// <value></value>
        
        public string DepartmentId{get;}
        /// <summary>
        /// Property AdmissionDate used to identify the date of admission <see cref="AdmissionDetail"/>Class's object
        /// </summary>
        /// <value></value>
        public DateTime AdmissionDate{get;set;}
        /// <summary>
        /// Property Status shows the status of admission <see cref="AdmissionDetail"/>Class's object
        /// </summary>
        /// <value></value>
        public Status Status{get;set;}

    /// <summary>
    /// 
    /// </summary>
    /// <param name="studentId">Identification Number of Student</param>
    /// <param name="departmentsId">Identification Number of Department</param>
    /// <param name="admissionDate">Date of Admission</param>
    /// <param name="status">status of the Admission</param>
        public  AdmissionDetail(string studentId,string departmentsId,DateTime admissionDate,Status status)
        {
            s_admissionId++;
            AdmissionId="AID"+s_admissionId;
            StudentId=studentId;
            DepartmentId=departmentsId;
            AdmissionDate=admissionDate;
            Status=status;



        }
        public AdmissionDetail(string data)
        {
            string[] values=data.Split(',');
            s_admissionId=int.Parse(values[0].Remove(0,2));
            AdmissionId= values[0];
            DepartmentId=values[1];
            AdmissionDate=DateTime.ParseExact(values[2],"dd/MM/yyyy",null);
            Status=Enum.Parse<Status>(values[3]);
        }




        
    }
}