using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp3
{
    // Задание 1. Создать класс Person с полями: имя, фамилия, возраст и методом вывода всех данных на консоль.
   
    internal class Person
    {
         // Задание 1. Создать класс Person с полями: имя, фамилия, возраст и методом вывода всех данных на консоль.
        public string FirstName = "Daniil"; //Поле имя

        public string SecondName = "Demodov"; //Поле фамилия

        public int age = 17; // поле возраста 
        public void Print()
        {
            Console.WriteLine($"Имя: {FirstName}; фамилия: {SecondName}; Возраст: {age}");
        }

    }
}
