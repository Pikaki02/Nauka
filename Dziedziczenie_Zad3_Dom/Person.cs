using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie_Zad3_Dom
{
    internal class Person
    {
        public string Name { get; set; }
        public string Surname {  get; set; }
        public DateTime DateOfBirth { get; set; }
        public Address Address { get; set; }

        public Person(string name, string surname, DateTime dateOfBirth) 
        {
            Name = name;
            Surname = surname;
            DateOfBirth = dateOfBirth;
        }
        public Person(string name, string surname, DateTime dateOfBirth, Address address): this(name, surname,dateOfBirth)  
        {
            Address = address;
        }
        public string GetFullName(string name, string surname, DateTime dateOfBirth)
        {
            return $"Imie: {name}, Nazwisko: {surname}, Wiek:{Age.ToString()}";
        }
        public int Age
        {
            get
            {
                TimeSpan diference = DateTime.Now - DateOfBirth;
                return (int) (diference.Days/356.25);
            }
        }
    }
}
