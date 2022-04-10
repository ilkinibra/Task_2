using System;
namespace Task_2.Models
{
    public class Teacher:Person
    {
     
        private int _experience;
        public int Experience
        {
            get { return _experience; }
            set
            {
                if (value > 0 && value<=80)
                {
                    _experience = value;
                }
            }
        }
        private int _id;
        public int Id { get; }
        public Teacher(string name,string surname,int age,int experience):base( name,surname, age)
        {
            _id = Id;
            Id++;
            Name = name;
            SurName = surname;
            Age = age;
            Experience = experience;
        }
       
        public void ShowInfo()
        {
            Console.WriteLine($"ID:{Id}\nName:{Name}\nSurname:{SurName}\nAge:{Age}\nExperience{Experience}");
        }

    }
}
