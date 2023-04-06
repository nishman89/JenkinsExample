using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person : IMoveable
    {
        private int _age;
        public int Age
        {
            get { return _age; }
            set 
            {
                if (value < 0)
                {
                    throw new ArgumentException("Cannot have age less than 0");
                }
                else
                {
                    _age = value;
                }
            }
        }

        protected string _firstName;
        protected string _lastName;

        public Person() { }

        public Person(string firstName, string lastName, int age = 0)
        {
            _firstName = firstName;
            _lastName = lastName;
            Age = age;
        }
        public Person(int age)
        {
            Age = age;
        }

 
        public string FullName => $"{_firstName} {_lastName}";

        public override string ToString()
        {
            return $"{base.ToString()} Name: {FullName} Age: {Age}";

        }

        public string Move()
        {
           return "Walking along";
        }

        public string Move(int times)
        {
            return $"Walking along {times} times";
        }

        //public string FullName2 { get { return $"{_firstName} {_lastName}"; } }
        //public string FullName3
        //{
        //    get { return $"{_firstName} {_lastName}"; }
        //    set { _firstName = value; }
        //}

    }
}
