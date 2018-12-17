using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Program
    {
        static void Main(string[] args)
        {
                      
            Author author1 = new Author("Creanga", "creanga@ro.net");
            Author author2 = new Author("Pietroi", "pietroiu@o.rus");

            Book book2 = new Book("Ultima noapte", "Drama",  (decimal)1.5);
            book2.AddAuthors(author1);
            book2.AddAuthors(author2);

            
            Book book3 = new Book("La Scaldat", "Action",  (decimal)90.00);
            book3.AddAuthors(author1);

            Library library1 = new Library("Biblioteca");
            library1.AddBook(book3);
            library1.AddBook(book2);
            library1.AddBook(book3);
            
            library1.Print();
        }
    }
}
