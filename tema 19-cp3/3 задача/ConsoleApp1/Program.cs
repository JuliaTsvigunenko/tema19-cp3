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

            // Создание списка автомобилей
            List<Car> cars = new List<Car>
            {
            new Car(1, "Mercedes", 360, 58500, 10),
            new Car(2, "Audi", 300, 70000, 7),
            new Car(3, "BMW", 400, 670000, 9),
            new Car(4, "Toyota", 290, 49000, 3),
            new Car(5, "Nissan", 360, 31000, 6)
            };

            // Сортировка списка автомобилей по стоимости
            cars.Sort();

            // Вывод отсортированного списка автомобилей на экран
            Console.WriteLine("Список автомобилей после сортировки по стоимости:");
            foreach (var car in cars)
            {
                car.DisplayInfo();
            }


            Console.ReadKey();


        }
    }
}
