using RecapDemo1.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecapDemo1
{
    public class NorthwindContext:DbContext
    {
        public DbSet<Product> Products { get; set; }// yazılan product class ı tablodaki products table ına karşılık gelir
        public DbSet<Category> Categories { get; set; }
    }
}
