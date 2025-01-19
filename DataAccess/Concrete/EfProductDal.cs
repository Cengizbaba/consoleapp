using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleapp.Entity;
using consoleapp.DataAccess.Abstract;

namespace consoleapp.DataAccess.Concrete
{
    public class EfProductDal : IProductRepository
    {

        public Product GetById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void Update(Product entity)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Product entity)
        {
            Console.WriteLine("EFProductDal Ürün oluşturuldu.");
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new System.NotImplementedException();
        }
        public Product[] GetPopularProducts(int id)
        {
            throw new System.NotImplementedException();
        }

    }
}