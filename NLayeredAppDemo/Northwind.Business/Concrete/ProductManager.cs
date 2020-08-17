using Northwind.Data.Access.Concrete;
using Northwind.Data.Access.Concrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Northwind.Business.Concrete
{
    public class ProductManager
    {
        EfProductDal _productDal = new EfProductDal();
        public List<Product> GetAll()
        {
            return _productDal.GetAll();
        }
    }
}
