
using LibraryProblem;
using System;
using System.Collections.Generic;

namespace LibraryProblem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Library");
            AddBookByAuthor();
            


        }
        public static void AddBookByAuthor()
        {
            BookInfo bookList = new BookInfo();
            bool isMore = true;
            string addedBook = "";
            string bookAuthor = "";
            do
            {
                Console.Write("Add book Name or Enter END for Exit : ");
                addedBook = Console.ReadLine();
                if (addedBook.ToLower() == "end")
                {
                    isMore = false;
                    break;
                }

                Console.Write("Enter Author Name : ");
                bookAuthor = Console.ReadLine();
                bookList.BookLists.Add(new BookInfo { BookTitle = addedBook, BookAuthor = bookAuthor });
                Console.WriteLine("Books In stocks :- ");
                foreach (var book in bookList.BookLists)
                {
                    Console.WriteLine($"{book.BookTitle} by {book.BookAuthor}");
                }
            } while (isMore == true);

            BookInfo borrowedBook = new BookInfo();
            BookInfo shelvedList = new BookInfo();
            bool isEnd = false;
            string choice = "";
            string selectedBook = "";
            do
            {
                Console.Write("Want to : ( Borrow / Return / End) : ");
                choice = Console.ReadLine();
                if (choice.ToLower() == "borrow")
                {
                    Console.Write("Name of the book from Stock : ");
                    selectedBook = Console.ReadLine();

                    borrowedBook.BorrowedBookList.Add(new BookInfo { BookTitle = selectedBook });
                    bookList.BookLists.Remove(bookList);   

                    
                }
                else if (choice.ToLower() == "return")
                {
                    Console.Write("Name of the book : ");
                    selectedBook = Console.ReadLine();

                    shelvedList.Shelved.Add(new BookInfo { BookTitle = selectedBook });
                    //borrowedBook.BorrowedBookList.Remove(new BookInfo { BookTitle = selectedBook });

                }
                else if (choice.ToLower() == "end")
                {
                    isEnd = true;
                    Console.WriteLine("Shelved Books");
                    foreach (var shelve in shelvedList.Shelved)
                    {
                        Console.WriteLine($"{shelve.BookTitle}");
                    }
                    Console.WriteLine("Borrowed Books");
                    foreach (var borrowed in borrowedBook.BorrowedBookList)
                    {
                        Console.WriteLine($"{borrowed.BookTitle}");
                    }

                }
                else
                {
                    Console.WriteLine("enter valid input");
                }
            } while (isEnd == false);

        }
    }
}
public class BookInfo
{
    public string BookTitle { get; set; }
    public string BookAuthor { get; set; }
    public List<BookInfo> BookLists { get; set; } = new List<BookInfo>();
    public List<BookInfo> BorrowedBookList { get; set; } = new List<BookInfo>();
    public List<BookInfo> Shelved { get; set; } = new List<BookInfo>();
}


