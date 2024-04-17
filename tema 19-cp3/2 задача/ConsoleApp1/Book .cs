using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Book : IComparable<Book>
    {

        /// <summary>
        /// Название книги
        /// </summary>
        public string Title { get; set; }
        /// <summary>
        /// Цена книги
        /// </summary>
        public decimal Price { get; set; }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="title">Название книги</param>
        /// <param name="price">Цена книги</param>
        public Book(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        /// <summary>
        /// Реализация метода сравнения для сортировки по названию книги
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public int CompareTo(Book other)
        {
            return string.Compare(this.Title, other.Title, StringComparison.OrdinalIgnoreCase);
        }





    }
}
