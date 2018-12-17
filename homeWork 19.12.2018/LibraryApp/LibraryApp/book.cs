using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryApp
{
    class Book
    {
        public Book(string title, string genre , decimal price)
        {
            Title = title;
            Genre =genre;
            Price = price;
            Authors = new List<Author>();

        }
        public string Title { get; set; }

        public string Genre { get; set; }        

        public decimal Price { get; set; }

        public List<Author> Authors { get; set; }

        public void AddAuthors(Author author)
        {
            Authors.Add(author);
        }

        public decimal GetPrice()
        {
            if (Genre.ToLower() == "drama")
            {
                return Price - Price* (decimal)0.10;
            }
            else 
                if (Genre.ToLower() == "sf")
                {
                    return Price - Price * (decimal)0.15;
                }
            else
            {
                return Price;
            }
        }

        public void Print()
        {
            Console.WriteLine($"Book: {Title} , Genre: {Genre}, Price: {GetPrice()}");
            foreach (var author in Authors)
            {
                author.Print();
            }
        }
    }
}
