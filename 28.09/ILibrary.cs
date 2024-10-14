using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation.HomeWork
{
    internal interface ILibrary
    {
        void Addbook(Book book);
        bool RemoveBookByName(string name);
        Book FindBookByName(string name);
        int FindBookIndex(string name);
        void ShowAll();
        void SearchedBookByLetter(string str);
    }
}
