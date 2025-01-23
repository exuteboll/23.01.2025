using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        // Задание 1. Создать класс Person с полями: имя, фамилия, возраст и методом вывода всех данных на консоль.
        
       
        static void Main(string[] args)
        {
            Person person = new Person();
            string FirstName = person.FirstName;
            string SecondName = person.SecondName;
            int Age = person.age;
            Console.WriteLine($"Имя: {FirstName}\t Фамилия: {SecondName}\t Возраст: {Age}");
            person.FirstName = "Егор";
            person.SecondName = "Присич";
            person.age = 17;
            person.Print();

            Console.ReadKey();
        }
    }
}
