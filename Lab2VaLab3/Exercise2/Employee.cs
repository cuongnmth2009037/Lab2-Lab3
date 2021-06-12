using System;

namespace Lab2VaLab3.lab3
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public long Sin { get; set; }
        public double Salary { get; set; }

        public Employee(string firstName, string lastName, string address, long sin, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Address = address;
            Sin = sin;
            Salary = salary;
        }

        public override string ToString()
        {
            return $"FirstName :{FirstName}, LastName :{LastName}, Address :{Address}, Sin :{Sin}, Salary :{Salary}";
        }

        public double CalculBonus(int percentage)
        {
            var result = Salary * percentage;
            return result ;
        }
    }
}