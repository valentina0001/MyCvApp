using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsiranjeTeksta
{
     class Person
    {
            private string name;
            private string lastName;
            private string birthPlace;
        

        public string GetName()
        {
            return name;
        }
        public void SetIme(string name)
        {
            this.name = name;
        }
        public string GetLastName()
        {
             return lastName;
            }
            public void SetPrezime(string lastName)
            {
                this.lastName = lastName;
            }
            public string GetBirthPlace()
            {
                return birthPlace;
            }
            public void SetGrad(string birthPlace)
            {
                this.birthPlace = birthPlace;
            }
        public Person(string name, string lastName, string birthPlace)
        {
            this.name = name;
            this.lastName = lastName;
            this.birthPlace = birthPlace;
        }
        public override string ToString()
        {
            return $"Person = {name}, Last Name = {lastName}, Birth Place = {birthPlace}.";
        }

    }
}

