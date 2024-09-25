using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer.Entities;
using DataAccessLayer.EF;

namespace DataAccessLayer.Repository
{
    public class ProductRepository
    {
        private Context DB;
        public ProductRepository(Context context)
        {
            DB = context;
        }
        public IEnumerable<Product> ReadAll()
        {
            return DB.Products;
        }
        public Product Read(int id)
        {
            return DB.Products.Find(id);
        }
        public void Create(Product product)
        {
            DB.Products.Add(product);
        }
        public void Delete(int id)
        {
            Product product = DB.Products.Find(id);
            if(product!=null)
            DB.Products.Remove(product);
        }
    }
}
