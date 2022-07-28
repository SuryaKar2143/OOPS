using System;
using System.Collections.Generic;
using System.IO;
namespace StudentAdmissionNew;
    public static class Files
    {
        public static void Create()
        {
            if(!Directory.Exists("College"))
            {
                Console.WriteLine("Creating Folder");
                Directory.CreateDirectory("College");
            }
            if(!File.Exists("College/StudentDetails.csv"))
            {
                Console.WriteLine("Create File");
                File.Create("College/StudentDetails.csv");
            }
            if(!File.Exists("College/DepartmentDetails.csv"))
            {
                Console.WriteLine("Create File");
                File.Create("College/DepartmentDetails.csv");
            }
            if(!File.Exists("College/AdmissionDetails.csv"))
            {
                Console.WriteLine("Create File");
                File.Create("College/AdmissionDetails.csv");
            }
            
        }
         public static void ReadFile()
        {
            string[] students= File.ReadAllLines("College/StudentDetails.csv");
            string[] departments= File.ReadAllLines("College/departmentDetails.csv");
            string[] admission= File.ReadAllLines("College/admissionDetails.csv");

            Operation.studentList= CreateStudentObjects(students);
            Operation.departmentList=CreateDepartmentObjects(departments);
            Operation.admissionList=CreateAdmissionObjects(admission);

        }

        public static List<StudentDetail> CreateStudentObjects(string[] students)
        {
            List<StudentDetail> studentList=new List<StudentDetail>();
            foreach(string data in students)
            {
                StudentDetail student=new StudentDetail(data);
                studentList.Add(student);
            }
            return studentList;
        }

        public static List<DepartmentDetail> CreateDepartmentObjects(string[] departments)
        {
            List<DepartmentDetail> departmentList=new List<DepartmentDetail>();
            foreach(string data in departments)
            {
                DepartmentDetail department=new DepartmentDetail(data);
                departmentList.Add(department);
            }
            return departmentList;
        }

        public static List<AdmissionDetail> CreateAdmissionObjects(string[] admissions)
        {
            List<AdmissionDetail> admissionList=new List<AdmissionDetail>();
            foreach(string data in admissions)
            {
                AdmissionDetail admission=new AdmissionDetail(data);
                admissionList.Add(admission);

            }
            
            
            return admissionList;


        }
        
    }

   
