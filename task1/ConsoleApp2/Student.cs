using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Student : Human
    {
        public double Grant;
        public string GroupNo;
        

        public Student(string name, string surname, byte age, double grant, string groupNo): base(name, surname, age)
        {
            Grant = grant;
            GroupNo = groupNo;
        }
    }
}
