using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkDemo
{
    public class ProductDal
    {
        public List<Product> GetAll()
        {
            //ETradeContex contex = new ETradeContex();

            using (ETradeContext context = new ETradeContext())//boyle yazıldığında nesne ile işlem bittiğinde bellekten temizler
            {
               return context.Products.ToList();
            }
        }

        public List<Product> GetByName(string key)
        {
            using (ETradeContext context = new ETradeContext())//boyle yazıldığında nesne ile işlem bittiğinde bellekten temizler
            {
                return context.Products.Where(p=>p.Name.Contains(key)).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal price)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= price).ToList();
            }
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            using (ETradeContext context = new ETradeContext())
            {
                return context.Products.Where(p => p.UnitPrice >= min && p.UnitPrice <= max).ToList();
            }
        }

        public Product GetById(int id)//verilen id e gore product getirir
        {
            using (ETradeContext context = new ETradeContext())
            {
                var result = context.Products.FirstOrDefault(p => p.Id == id);//FirstorDefault girilen id varsa product getirir yoksa null getirir
                return result;
            }
        }

        public void Add(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                //context.Products.Add(product);
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Added;
                context.SaveChanges();//Yapılan değişiklikleri kaydeder
            }
        }

        public void Update(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }
        
        public void Delete(Product product)
        {
            using (ETradeContext context = new ETradeContext())
            {
                var entity = context.Entry(product);
                entity.State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
