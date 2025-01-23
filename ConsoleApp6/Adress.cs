using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    
    internal class Adress
    {
        //Задание 2. Создать класс с именем Address. В теле класса требуется создать поля: index, country, city, street, house, apartаment.
        //Создать экземпляр класса Address. В поля экземпляра записать информацию о почтовом адресе. Выведите на экран значения полей, описывающих адрес.
        public int index;
        public string country;
        public string city;
        public string street;
        public int house;
        public int apartament;
        public void Print()
        {
            Console.WriteLine($"Индекс: {index}\t Страна: {country}\t Город: {city} \t Улица: {street} \t Дом: {house} \t Квартира: {apartament}");
        }
    }
}
