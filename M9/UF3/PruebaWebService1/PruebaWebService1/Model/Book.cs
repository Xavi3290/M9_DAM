using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWebService1.Model
{
    public class Book
    {
        public String name { get; set; }

        public String isbn { get; set; }

        public int numberOfPages { get; set; }

        public List<String> authors { get; set; } 

        public List<String> characters { get; set; }

        public Book()
        {
        }

        public Book(string name, string isbn, int numberOfPages, List<string> authors, List<string> characters)
        {
            this.name = name;
            this.isbn = isbn;
            this.numberOfPages = numberOfPages;
            this.authors = authors;
            this.characters = characters;
        }
    }
}
