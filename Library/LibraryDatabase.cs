//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Library
//{
//    public class LibraryDatabase
//    {
//        public int id {  get; set; }
//        public List<Book> ListOfBooks { get; set; } = new List<Book>();

//        public void Add(Book book) { ListOfBooks.Add(book);}
//        public void Delete(Book book) { ListOfBooks.Remove(book);}
//        public void Update(string isbn, Book updatedBook)
//        {
//            var book = ListOfBooks.FirstOrDefault(b => b.ISBN == isbn);
//            if (book != null)
//            {
               
//                book.Title = updatedBook.Title;
//                book.Author = updatedBook.Author;
//                book.ISBN = updatedBook.ISBN;
//                book.Publication = updatedBook.Publication;
//                book.Status = updatedBook.Status;
                
//            }
//            else
//            {
//                throw new InvalidOperationException("Book not found.");
//            }
//        }
//        public void Display()
//        {
//            foreach (var book in ListOfBooks)
//            {
//                Console.WriteLine($"Title: {book.Title}, Author: {book.Author}, ISBN: {book.ISBN}");
//            }
//        }

        
//        public Book Search(string query)
//        {
//            return ListOfBooks.FirstOrDefault(book => book.ISBN == query || book.Author == query || book.Title == query);

//        }
//    }

//}
