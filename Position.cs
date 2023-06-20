using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class Position : Employee
    {

        public string PositionName { get; set; }
        public double StartingSalary { get; set; }
        public double Salary => StartingSalary + (((YearsExperience * 3)/ 100) * StartingSalary);

        
    }
}
