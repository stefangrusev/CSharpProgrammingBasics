using System;

namespace _01.OldBooks
{
    class Program
    {
        static void Main(string[] args)
        {
            string wantedBook = Console.ReadLine();
            string bookName = Console.ReadLine();
            int counter = 0;

            while (bookName != "No More Books" && wantedBook != bookName)
            {
                counter++;            
                bookName = Console.ReadLine();
            }

            Console.WriteLine(bookName != wantedBook ? $"The book you search is not here!\nYou checked {counter} books." 
                                                     : $"You checked {counter} books and found it.");


        }
    }
}
