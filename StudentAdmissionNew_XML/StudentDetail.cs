using System;
using System.Collections.Generic;
namespace StudentAdmissionNew
{
    /// <summary>
    /// Used to Select User's Gender information
    /// </summary>
     public enum Gender{Default,Male,Female,Others}
      /// <summary>
     /// Class<see cref="StudentDetail"/>used to collect student's details for the admission Process
      /// </summary>

    public class StudentDetail
    {
        /// <summary>
        /// Property Registration Number used to Uniquely identify a <see cref="StudentDetail" />Class's object
       /// </summary>
        private static int s_studentId=3000;
        public string StudentId{get;}
        
      /// <summary>
      /// Property NAme used to provide name of the student in the object of <see cref="StudentDetail" />Class's object
      /// </summary>
        public string Name{get; set;}
        /// <summary>
        /// Property Father used to provide name of the father in the object of <see cref="StudentDetail" />Class's object 
        /// </summary>
        public string Father{get;set;}
        /// <summary>
      /// Property DOB used to provide Date of Birth of the Student in the object of <see cref="StudentDetail" />Class's object 
      /// </summary>
        public DateTime DOB{get;set;}
        /// <summary>
        /// Property Gender used to provide gender of the Student in the object of <see cref="StudentDetail" />Class's object 
      /// </summary>
        public Gender Gender{get; set;}
        /// <summary>
      /// Property PhysicsMark used to provide the Mark in Physics Subject in the object of <see cref="StudentDetail" />Class's object 
      /// </summary>
        public int Physics{get;set;}
        /// <summary>
      /// Property Chemistry used to provide the Mark in Chemistry Subject in the object of <see cref="StudentDetail" />Class's object 
      /// </summary>
        public int Chemistry{get;set;}
        /// <summary>
      /// Property MathsMark used to provide the Mark in Maths Subject in the object of <see cref="StudentDetail" />Class's object 
      /// </summary>
        public int Maths{get;set;}
       
        

        /// <summary>
 /// Constructor of <see cref="StudentDetaill"/> class used to initialized values to its properties
 /// </summary>
 /// <param name="name">Parameter name used to initialie a Student's Name to the Name Property</param>
 /// <param name="father">Parameter fathername used to initialize value to the  Father Name  </param>
 /// <param name="gender">Parameter gender used to initialize value to the gender of the Student</param>
 /// <param name="physicsmark">Parameter physicsmark used to initialize value to the physics Mark of the Student</param>
 /// <param name="chemistrymark">Parameter chemistrymark used to initialize value to the Chemistry Mark of the Student</param>
 /// <param name="mathsmark">Parameter mathsmark used to initialize value to the maths Mark of the Student</param>
        public StudentDetail(String name,String father,DateTime dob,Gender gender,int physics,int chemsitry,int maths)
        {
            s_studentId++;
            StudentId="SF"+s_studentId;
            Name=name;
            Father=father;
            DOB=dob;
            Gender=gender;
            Physics=physics;
            Chemistry=chemsitry;
            Maths=maths;

            }



            public StudentDetail(string data)
            {
              string[] values=data.Split(',');
              s_studentId=int.Parse(values[0].Remove(0,2));
              StudentId= values[0];
              Name=values[1];
              Father=values[2];
              DOB=DateTime.ParseExact(values[3],"dd/MM/yyyy",null);
              Gender=Enum.Parse<Gender>(values[4]);
              Physics=int.Parse(values[5]);
              Chemistry=int.Parse(values[6]);
              Maths=int.Parse(values[7]);
            }
        
        

        


        
    }
}