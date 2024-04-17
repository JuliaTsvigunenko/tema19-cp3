using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car : IComparable<Car>
    {

        /// <summary>
        /// Идентификатор
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// Марка
        /// </summary>
        public string Brand { get; set; }
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { get; set; }
        /// <summary>
        /// Цена
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// Скидка 
        /// </summary>
        public double Discount { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="id">Идентификатор</param>
        /// <param name="brand">Марка</param>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="price">Цена</param>
        /// <param name="discount">Скидка</param>
        public Car(int id, string brand, int maxSpeed, decimal price, double discount)
        {
            Id = id;
            Brand = brand;
            MaxSpeed = maxSpeed;
            Price = price;
            Discount = discount;
        }

        /// <summary>
        /// Метод для вычисления цены со скидкой
        /// </summary>
        /// <returns></returns>
        public decimal DiscountedPrice()
        {
            return Price - (Price * (decimal)(Discount / 100));
        }

        /// <summary>
        /// Реализация метода сравнения для сортировки по стоимости
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Car other)
        {
            // Сравниваем автомобили по цене со скидкой
            return DiscountedPrice().CompareTo(other.DiscountedPrice());
        }

        /// <summary>
        ///  Метод для вывода информации о автомобиле на экран
        /// </summary>
        public void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Марка: {Brand}, Максимальная скорость: {MaxSpeed} км/ч");
            Console.WriteLine($"Цена без скидки: {Price:C}, Цена со скидкой: {DiscountedPrice():C}");
            Console.WriteLine($"Скидка: {Discount}%\n");
        }




    }
}
