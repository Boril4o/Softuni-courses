using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._School_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> books = Console.ReadLine()
                .Split('&')
                .ToList();

            while (true)
            {
                string input = Console.ReadLine();
                if (input == "Done") break;

                string[] command = input
                    .Split('|')
                    .ToArray();

                if (command[0] == "Add Book ")
                {
                    string book = command[1].TrimStart(' ');
                    if (books.Contains(book)) continue;
                    books.Insert(0, book);
                }
                else if (command[0] == "Take Book ")
                {
                    string book = command[1].TrimStart(' '); ;
                    if (!books.Contains(book)) continue;
                    int index = books.IndexOf(book);
                    books.RemoveAt(index);
                }
                else if (command[0] == "Swap Books ")
                {
                    string book1 = command[1].TrimStart(' ').TrimEnd(' ');
                    string book2 = command[2].TrimStart(' ').TrimEnd(' ');
                    if (!books.Contains(book1) || !books.Contains(book2)) continue;
                    swap(books, book1, book2);
                }
                else if (command[0] == "Check Book ")
                {
                    int bookIndex = int.Parse(command[1]);
                    if (bookIndex < 0 || bookIndex >= books.Count) continue;
                    Console.WriteLine(books[bookIndex]);
                }
                else
                {
                    string book = command[1].TrimStart(' ');
                    if (books.Contains(book)) continue;
                    books.Add(book);
                }

            }

            Console.WriteLine(string.Join(", ", books));
        }

        static void swap(List<string> books, string bookName1, string bookName2)
        {
            int indexOfBook1 = books.IndexOf(bookName1); 
            int indexOfBook2 = books.IndexOf(bookName2);
            books.Insert(indexOfBook1, bookName2);
            books.RemoveAt(indexOfBook1 + 1);
            books.Insert(indexOfBook2, bookName1);
            books.RemoveAt(indexOfBook2 + 1);
        }
    }
}
