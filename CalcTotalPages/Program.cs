using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Practical_2_Q_4
{

    /// <summary>
    /// C# program that Calculate Total Pages of the book.
    /// Author: Faryaz
    /// </summary>

    class Book
    {
        public string Title { get; set; }
        public int NumOfPages { get; set; }
        public Book(string tle, int npg)
        {
            Title = tle;
            NumOfPages = npg;
        }
    }
    class Tester
    {
        static void Main(string[] args)
        {
            List<Book> books = new List<Book>();
            books.Add(new Book("Learning Object-Oriented Programming in C# 5.0", 673));
            books.Add(new Book("Automate the Boring Stuff with Python", 504));
            books.Add(new Book("Python Succinctly", 146));
            int totalPages = CalcTotalPages(books);
            WriteLine($"Total number of pages: {totalPages}");
        }
        static int CalcTotalPages(List<Book> bookList)
        {
            if (bookList == null || bookList.Count == 0)
            {
                return 0;
            }
            else
            {

                int bookfstPage = bookList[0].NumOfPages;
                List<Book> subList = bookList.GetRange(1, bookList.Count - 1);
                int pagesofsublist = CalcTotalPages(subList);
                int totalPages = bookfstPage + pagesofsublist;
                return totalPages;
            }
        }

    }
}