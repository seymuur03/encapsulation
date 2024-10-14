using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.HomeWork
{
    internal class Library : ILibrary
    {

        public Book[] Books;

        public Library()
        {
            Books = new Book[0];
        }
        public void Addbook(Book book)
        {
            Array.Resize(ref Books, Books.Length + 1);
            Books[Books.Length - 1] = book;
        }

        public bool RemoveBookByName(string name)
        {
            int index = FindBookIndex(name);
            if (index != -1)
            {
                var temp = Books[index];
                Books[index] = Books[Books.Length - 1];
                Books[Books.Length - 1] = temp;
                Array.Resize(ref Books, Books.Length - 1);
                return true;
            }
            return false;
        }

        public Book FindBookByName(string name)
        {
            foreach (var book in Books)
                if (book.Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return book;
            return null;
        }
        public int FindBookIndex(string name)
        {
            for (int i = 0; i < Books.Length; i++)
                if (Books[i].Name.Equals(name, StringComparison.OrdinalIgnoreCase)) return i;
            return -1;
        }

        public void ShowAll()
        {
            foreach (var book in Books)
                Console.WriteLine(book.Name);
        }

        public void SearchedBookByLetter(string search)
        {
            foreach (var book in Books)
            {
                if (book.Name.ToLower().Contains(search.ToLower()))
                    Console.WriteLine(book.Name);

            }
        }
    }
}
