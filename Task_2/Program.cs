using System;
using Task_2.Models;
namespace Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int a = 5;
            //    ChangeValue(ref a);
            //    Console.WriteLine(a);
            //}
            //static int ChangeValue(ref int a)
            //{
            //    return a = 7;
            //}
            int age;
            int experience;
            int age1;

            do
            {
                Console.WriteLine("Enter the age");
                age = Convert.ToInt32(Console.ReadLine());

            } while (age < 0);

            do
            {
                Console.WriteLine("Enter the experience");
                experience = Convert.ToInt32(Console.ReadLine());

            } while (experience < 0 || experience>80);
            Console.WriteLine("---------------------");


            Teacher teacher = new Teacher("Ilkin", "Ibrahimov", age,experience);
            teacher.ShowInfo();
            Console.WriteLine("-----------------------");

            
            do
            {
                Console.WriteLine("Enter the age");
                age1 = Convert.ToInt32(Console.ReadLine());

            } while (age1 < 0);

            Student student = new Student("Yusif", "Nazerbeyov", age1);
            student.ShowInfo();
            Console.ReadLine();
        }
    }
}
