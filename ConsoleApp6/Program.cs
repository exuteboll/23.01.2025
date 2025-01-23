using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        //Задание 2. Создать класс с именем Address. В теле класса требуется создать поля: index, country, city, street, house, apartаment.
        //Создать экземпляр класса Address. В поля экземпляра записать информацию о почтовом адресе. Выведите на экран значения полей, описывающих адрес.
        static void Main(string[] args)
        {
            Adress adress = new Adress();
            int Index = adress.index;
            string Country = adress.country;    
            string City = adress.city;
            string Street = adress.street;
            int House = adress.house;
            int Apartament = adress.apartament;
            adress.index= 3300;
            adress.country = "Приднестровье";
            adress.city = "Тирасполь";
            adress.street = "Мира";
            adress.house = 2;
            adress.apartament = 3;
            adress.Print();
            Console.ReadKey();
        }
    }
}
