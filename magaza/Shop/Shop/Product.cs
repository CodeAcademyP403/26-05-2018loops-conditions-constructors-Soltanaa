using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop
{
    class Product
    {
        public string Name;
        public string Weight;
        public int ID;
        public string Price;
        public string Date;
        Category category = new Category();
    }
}
