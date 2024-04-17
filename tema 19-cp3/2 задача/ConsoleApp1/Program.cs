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


            // Создание списка книг
            List<Book> library = new List<Book>
            {
            new Book("Евгений Онегин", 600),
            new Book("Маленький принц", 700),
            new Book("Гроздья гнева", 550),
            new Book("Ребекка", 300),
            new Book("Три товарища", 950)
            };

            // Сортировка списка книг по названию
            library.Sort();

            // Вывод отсортированного списка книг на экран
            Console.WriteLine("Библиотека:");

            foreach (var book in library)
            {
                Console.WriteLine($"Название: {book.Title}, Цена: {book.Price}");
            }


            Console.ReadKey();



        }
    }
}
