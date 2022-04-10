using System;
namespace Task_2.Models
{
    public class Student:Person
    {
        private int _id;
        public int Id { get; }
        public string[] Lessons = new string[0];
        public Student(string name,string surname,int age):base(name,surname,age)
        {
            _id = Id;
            Id++;
            Name = name;
            SurName = surname;
            Age = age;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{Id}\nName:{Name}\nSurname:{SurName}\nAge:{Age}");
        }
    }
}
