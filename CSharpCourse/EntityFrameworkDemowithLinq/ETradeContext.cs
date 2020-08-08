using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ETradeContext: DbContext //EntityFramework e database tanıtıldı
    {
        public DbSet<Product> Products { get; set; } //Database de "Products" table ni arar 
    }
}
