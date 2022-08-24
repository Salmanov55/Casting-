using System;
using System.Collections.Generic;
using System.Text;

namespace Casting.Models
{
    class Student:Person
    {

        public float Point
        {
            get { return Point; }
            set
            {
                if (value > 0 && value <= 10 )
                    Point = value;
            }
        }
        public string GetName(string _name)
        { 
            return _name;
        }
        public string GetSurname(string _surname)
        {
            return _surname;
        }
        public int GetAge(int _age)
        {
            return (int)_age;
        }
        public int GetId(int Id)
        {
            return Id;
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Name: "+ Name + "Surname: "+ Surname + "Age" +Age);
        }
        public Student(string name,string surname,int age):base(name,surname,age)
        {
           
        }
    }
}
