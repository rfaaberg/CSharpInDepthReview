using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqToSQL
{
    public class MyNeatRepo
    {
        public List<Product> DoSomeQuerying()
        {
            using (var myCoolDb = new MyCoolDbDataContext())
            {
                var query = from product in myCoolDb.Products
                    where product.IsActive
                    select product;
                var products = query.ToList();
                return products;
            }
        }
    }
}
