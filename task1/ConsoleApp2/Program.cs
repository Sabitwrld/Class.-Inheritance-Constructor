namespace ConsoleApp2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Sabit", "Jafarov", 18, 100, "PB503");
            Teacher teacher = new Teacher("Yusif", "Guluzada", 27, 3000, "PB503");

            Console.WriteLine($"Student: {student.Name} {student.Surname}, Age: {student.Age}, Grant: {student.Grant}, Group No: {student.GroupNo}");
            Console.WriteLine($"Teacher: {teacher.Name} {teacher.Surname}, Age: {teacher.Age}, Salary: {teacher.Salary}, Group No: {teacher.GroupNo}");
        }
    }    
}
