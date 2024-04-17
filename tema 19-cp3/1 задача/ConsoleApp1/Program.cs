using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            // Создание нескольких объектов Person для сортировки
            Person person1 = new Person { Name = "Екатерина", Age = 30 };
            Person person2 = new Person { Name = "Анастасия", Age = 25 };
            Person person3 = new Person { Name = "Дарья", Age = 35 };


            // Создание массива объектов Person
            Person[] people = { person1, person2, person3 };

            // Сортировка массива объектов Person по имени
            Array.Sort(people);

            // Вывод отсортированных объектов Person
            foreach (var person in people)
            {
                Console.WriteLine($"Имя: {person.Name}, Возраст: {person.Age}");
            }

            Console.ReadKey();


        }
    }
}
