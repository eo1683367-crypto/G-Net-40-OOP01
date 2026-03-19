using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Net_40_OOP01.MyStructs
{
    internal struct Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public decimal Salary { get; set; }

        public Employee(string name, int age, decimal salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }

        public override string ToString() => $"Employee Name: {Name} , Age: {Age} , Salary = {Salary}";
    }
}
