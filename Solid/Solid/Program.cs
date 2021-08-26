
using Solid.Services;
using System;

namespace Solid
{
    class Program
    {

        static void Main(string[] args)
        {
            BookService bookService = new BookService();

            bookService.EnterBookDetails("Productivity hacks", "Seema", true, DateTime.Today, 23.7);





        }
    }
}
