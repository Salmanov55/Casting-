using System;
using System.Collections.Generic;
using System.Text;

namespace Casting.Models
{
    abstract class Person
    {
        private int _id;
        private string _name;
        private string _surname;
        private int _age;

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
            set 
            { 
                if(value.Length>0)
                _name = value; 
            }
        }
        public string Surname
        {
            get { return _surname; }
            set
            {
                if(value.Length>0)
                _surname = value;
            }
        }
        public int Age
        {
            get { return _age; }
            set
            {
                if(value > 0)
                    _age = value;
            }
        }
        public abstract void ShowInfo();
        
        public Person( string name, string surname, int age)
        {
            
            Name = name;
            Surname = surname;
            Age = age;
        }
    }
}
