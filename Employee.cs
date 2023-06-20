using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise_1
{
    public class Employee : AirConditionerFactory
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public Position Position { get; set; }
        public int YearsExperience { get; set; }

        public Employee() { }
        
        public Employee(string firstName, string lastName, int age, Position position, int yearsExperience)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Position = position;
            YearsExperience = yearsExperience;
        }
    }
}
