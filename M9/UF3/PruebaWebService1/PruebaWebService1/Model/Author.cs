using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaWebService1.Model
{
    public class Author
    {
        public List<String> authors { get; set; }

        public Author()
        {
        }

        public Author(List<string> authors)
        {
            this.authors = authors;
        }

        //public Author(string authors)
        //{
        //    this.authors = authors;
        //}



    }
}
