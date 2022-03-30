using System;
using System.Collections.Generic;
using System.Text;

namespace StudentsArray.Models
{
    internal class Student
    {
        public static int Serial = 1;
        public int Id;

        public string Name;
        public string Surname;
        public int Age;
        public int Point;
       
        public Student(string name,string surname,int age,int point)
        {
            
            if(name == "" || name == " " || surname == "" || surname == " " || point == 0)
            {
                Console.WriteLine("Argumentler duzgun verilmeyib");
                return;
            }
            Name = name;
            Surname = surname;
            Age = age;
            Point = point;

            this.Id = Serial++;
            
            
        }

        public string ShowInfo()
        {
            return $"ID: {Id}\nName: {Name}\nSurname: {Surname}\nAge: {Age}\nPoint: {Point}\n\n";
        }


    }
}
