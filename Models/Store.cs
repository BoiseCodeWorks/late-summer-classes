using System;
using System.Collections.Generic;

namespace Library.Models
{
  public class Store
  {
    public string Name { get; set; }
    public List<Book> Books { get; set; } = new List<Book>();

    public void PrintBooks()
    {
      for (int i = 0; i < Books.Count; i++)
      {
        var book = Books[i];
        System.Console.WriteLine($"{i + 1} - {book.Title}");

      }
    }

    /*
    state: {
      bananas: []
    }
     */

  }
}