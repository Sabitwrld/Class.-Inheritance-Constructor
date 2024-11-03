using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Teacher : Human
    {
        public double Salary;
        public string GroupNo;

        public Teacher(string name, string surname, byte age, double salary, string groupNo): base(name, surname, age) 
        {
            Salary = salary;
            GroupNo = groupNo;
        }
    }

}
