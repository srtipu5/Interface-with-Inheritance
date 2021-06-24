using System;

namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your Student Id : ");
            string stdId = Console.ReadLine();
            Console.Write("Enter Name : ");
            string stdName = Console.ReadLine();
            Console.Write("Enter Gender : ");
            string stdGender = Console.ReadLine();
            Console.Write("Enter Age : ");
            string stdAge = Console.ReadLine();

            Student student = new Student(stdId,stdName,stdGender,stdAge);
            student.Details();

            Console.Write("Enter Your Teacher Id : ");
            string id = Console.ReadLine();
            Console.Write("Enter Name : ");
            string name = Console.ReadLine();
            Console.Write("Enter Gender : ");
            string gender = Console.ReadLine();
            Console.Write("Enter Age : ");
            string age = Console.ReadLine();

            Teacher teacher = new Teacher(id, name, gender, age);
            teacher.Details();
        }
    }
}
