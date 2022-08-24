using System;
using System.Collections.Generic;
using System.Text;

namespace Casting.Models
{
    class Teacher : Person
    {
        private double _salary;
        public double Salary { get { return _salary; } 
            set 
            { 
                if (value>0)
                _salary = value; 
            } 
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Name: "+ Name+ "Surname: " +"Age: " +Age);
        }
        public Teacher(string name, string surname, int age) : base(name, surname, age)
        {

        }
    }
}
