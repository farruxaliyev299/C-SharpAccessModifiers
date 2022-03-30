using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsArray.Models
{
    internal class Group
    {
        public static int Serial = 201;
        private int _No;

        public string GroupName;

        public Student[] Students = new Student[] {};

        public static int pos = 1;

        public Group()
        {
            _No = Serial++;
            GroupName = $"BP{_No}";
        }

        public void AddStudents(Student student)
        {
            
            Array.Resize(ref Students, pos);
            Students[pos-1] = student;
            pos++;                                            
        }

        public void GetAllStudents()
        {

            for (int j = 0; j < Students.Length; j++)
            {
                Console.WriteLine($"Student Info:\nGroup: {GroupName}\nName: {Students[j].Name}\nSurname: {Students[j].Surname}\nAge: {Students[j].Age}\nPoint: {Students[j].Point}\n\n"); 
            }
        }

        public Student[] Sort()
        {
            Student temp;
            for (int i = 0; i < Students.Length; i++)
            {
                for (int j = 0; j < Students.Length; j++)
                {
                    if(Students[j].Point > Students[i].Point)
                    {
                        temp = Students[j];
                        Students[j] = Students[i];
                        Students[i] = temp;
                    }                    
                }
            }
            return Students;           
        }


    }
}
