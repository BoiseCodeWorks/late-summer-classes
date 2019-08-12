using System;
using Library.Models;

namespace Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var jakesStore = new Store();
            System.Console.WriteLine(jakesStore.Name);
            var harryPotter = new Book("Harry Potter");
            jakesStore.Books.Add(harryPotter);

           jakesStore.PrintBooks();

        }
    }
}
