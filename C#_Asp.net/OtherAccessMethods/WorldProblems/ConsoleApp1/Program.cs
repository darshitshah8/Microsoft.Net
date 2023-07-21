//Console.Write("Welcome to the library Management");


//Console.WriteLine("Add Books In lists");












//public class BookList
//{
//    public int BookId { get; set; }
//    public string BookTitle { get; set; }
//    public string BookAuthor { get; set; }

//}

//public static void AddBook()
//{

//}












////Dictionary<string , string> addList = new Dictionary<string , string>();
////bool add = true;
////string bookName = "";
////string authorName = "";
////do
////{
////    Console.Write("Enter book name (Or END) : ");
////    bookName = Console.ReadLine();
////    if (bookName.ToLower() == "end")
////    {
////        add = false;
////        break;
////    }        
////        Console.Write("Enter Author Name : ");
////        authorName = Console.ReadLine();
////    addList.Add(bookName, authorName);
////} while (add == true);

////Console.WriteLine("Added Books ");

////foreach (KeyValuePair<string, string> book in addList)
////{
////    Console.WriteLine($"{book.Key} by {book.Value}");
////}


////Borrow Book
//        //List<string> borrowed = new List<string>();
//        //List<string> returned = new List<string>();
//        //bool close = false;
//        //string choice = "";
//        //string borrowName = "";     
//        //string returnedBook = "";
//        //do
//        //{
//        //    Console.WriteLine("Enter Your choice (Borrow / Return / End)");
//        //    choice = Console.ReadLine();
//        //        if (choice.ToLower() == "borrow")
//        //        {
//        //            do
//        //            {
//        //                Console.WriteLine("Enter Book Name");
//        //                borrowName = Console.ReadLine();
//        //                if (bookName != borrowName)
//        //                {
//        //                    Console.WriteLine("enter valid name");
//        //                }
//        //                else
//        //                {
//        //                    borrowed.Add(borrowName);
//        //                } 
//        //            } while (true);
//        //        }
//        //        else if (choice.ToLower() == "return")
//        //        {
//        //            do
//        //            {
//        //                Console.WriteLine("Enter Book Name");
//        //                returnedBook = Console.ReadLine();
//        //                if (borrowName != returnedBook)
//        //                {
//        //                    Console.WriteLine("enter valid name");
//        //                }
//        //                else
//        //                {
//        //                    returned.Add(returnedBook);
//        //                    borrowed.Remove(returnedBook);
//        //                }
//        //            } while (borrowName == returnedBook);
//        //        }
//        //        else
//        //        {
//        //            do
//        //            {
//        //                if (choice.ToLower() == "end")
//        //                {
//        //                    close = true;
                           
//        //                 }
//        //                else 
//        //                {
//        //                    Console.WriteLine("enter valid");
//        //                } 
//        //            } while (true);
//        //        }

//        //    } while (close == false);

//        //Console.WriteLine("Returned Books");
//        //foreach (var borrowedBook in borrowed)
//        //{
//        //    Console.WriteLine($"{returnedBook}");
//        //}