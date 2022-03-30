using System;
using StudentsArray.Models;

namespace StudentsArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Ferrux", "Eliyev", 19, 487);
            Student student2 = new Student("Samir", "Eliyev", 20, 475);
            Student student3 = new Student("xD", "Eliyev", 22, 690);
            Student student4 = new Student("Test", "Eliyev", 22, 90);
            Student student5 = new Student("Demo", "Eliyev", 22, 390);


            //student1.ShowInfo();

            Group group1 = new Group();

            group1.AddStudents(student1);
            group1.AddStudents(student2);
            group1.AddStudents(student3);
            group1.AddStudents(student4);
            group1.AddStudents(student5);


            group1.Sort(); //Group da olan Students arrayini sort edib qaytarir (azdan , cox-a)

            group1.GetAllStudents(); //Group da Students arrayinde olan studentlerin informasiyasini output edir.



            //for (int i = 0; i < group1.Students.Length; i++)
            //{
            //    Console.WriteLine
            //        (
            //        $"Group name: {group1.GroupName}\n" +
            //        $"Students Info:" +
            //        $"\nName: {group1.Students[i].Name}\n" +
            //        $"Surname: {group1.Students[i].Surname}\n" +
            //        $"Age: {group1.Students[i].Age}\n" +
            //        $"Points: {group1.Students[i].Point}\\n"
            //        );
            //}

        }
    }
}
