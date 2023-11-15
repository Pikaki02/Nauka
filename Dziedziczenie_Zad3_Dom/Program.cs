namespace Dziedziczenie_Zad3_Dom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student("Adam", "Nowak", new DateTime(2002,01,01),34);
            Console.WriteLine($"{student.Name} {student.Surname}, {student.StudentNumber}, {student.Age}");
            Person person = new Person("Adam", "Nowak", new DateTime(2002, 01, 01), new Address("Gromadno","Polna","23","89-310"));
            Console.WriteLine($"{person.Name} {person.Surname},{person.Age}, {person.Address.City}, {person.Address.Street}, {person.Address.HouseNumber}, {person.Address.PostalCode}");
        }
    }
}