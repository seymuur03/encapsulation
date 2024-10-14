using System.Globalization;

namespace Encapsulation.HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Library libr = new Library();
            libr.Books = new Book[] {
                new Book() { Name = "Book1" },
                new Book() { Name = "Book2" },
                new Book() { Name = "kitab" },
            };

            string num;
            do
            {
                ShowMenu();
                Console.WriteLine("----------------------------------------");
                Console.WriteLine("Enter a number : ");
                num = Console.ReadLine();

                switch (num)
                {
                    case "1":
                        Console.WriteLine($"Add a book.");
                        string NewBook = Console.ReadLine();
                        if (libr.FindBookByName(NewBook) == null)
                        {
                            libr.Addbook(new Book { Name = NewBook });
                            Console.WriteLine("The Book added succesfully ...");
                        }
                        else
                            Console.WriteLine("There is a book which is of the same name ...");
                        break;

                    case "2":
                        Console.WriteLine("Enter a BookName that you want to delete :");
                        string deletedbook = Console.ReadLine();
                        if (libr.RemoveBookByName(deletedbook))
                            Console.WriteLine("Deleted...");
                        else
                            Console.WriteLine("There is no book named like that");
                        break;

                    case "3":
                        Console.WriteLine("The Names of Books : ");
                        libr.ShowAll();
                        break;

                    case "4":
                        Console.WriteLine("Enter bookname you want to find : ");
                        string searchedBook = Console.ReadLine();
                        if (libr.FindBookByName(searchedBook) == null)
                            Console.WriteLine("Didn't find");
                        else
                            Console.WriteLine($"{searchedBook} is find");
                        break;

                    case "5":
                        Console.WriteLine("Seach : ");
                        string value = Console.ReadLine();
                        libr.SearchedBookByLetter(value);
                        break;


                    default:
                        Console.WriteLine("Choose correct !!!");
                        break;
                }

            } while (num != "0");


            static void ShowMenu()
            {
                Console.WriteLine("Menu : ");
                Console.WriteLine("1.Add Book : ");
                Console.WriteLine("2. Delete Book : ");
                Console.WriteLine("3. Look All Books : ");
                Console.WriteLine("4. Look choosen Book (by name) : ");
                Console.WriteLine("5. Look Book by letter : ");
            }


        }
    }
}
