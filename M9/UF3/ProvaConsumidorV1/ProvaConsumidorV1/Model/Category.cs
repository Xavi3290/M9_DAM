using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvaConsumidorV1.Model
{
    public class Category
    {
        public int CategoryId { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public Category()
        {
        }

        public Category(int categoryId, string categoryName, string description)
        {
            CategoryId = categoryId;
            CategoryName = categoryName;
            Description = description;
        }

        public Category(string categoryName)
        {
            CategoryName = categoryName;
        }
    }
}
