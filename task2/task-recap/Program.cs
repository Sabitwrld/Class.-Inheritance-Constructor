using System;

namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human = new Human { Name = "Sabit", Surname = "Jafarov", Age = 18 };

            Teacher teacher = new Teacher { Name = "Yusif", Surname = "Guluzada", Age = 27, Salary = 3500, GroupNo = 503 };
            teacher.ShowFullData();

            Student student = new Student { Name = "Sabit", Surname = "Jafarov", Age = 18, Grant = 98, GroupNo = 503 };
            student.ShowFullData();
        }
    }

    public class Human
    {
        public string Name;
        public string Surname;
        public byte Age;
    }

    public class Teacher : Human
    {
        public double Salary;
        public int GroupNo;

        public void ShowFullData()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Salary: {Salary}, GroupNo: {GroupNo}");
        }
    }

    public class Student : Human
    {
        public double Grant;
        public int GroupNo;

        public void ShowFullData()
        {
            Console.WriteLine($"Name: {Name}, Surname: {Surname}, Age: {Age}, Grant: {Grant}, GroupNo: {GroupNo}");
        }
    }
}
