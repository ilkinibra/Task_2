using System;
namespace Task_2.Models
{
    public class Person
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        private int _age;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }
            }
        }
        public Person(string name,string surname,int age)
        {
            Name = name;
            SurName = surname;
            Age = age;
        }

    }
}
