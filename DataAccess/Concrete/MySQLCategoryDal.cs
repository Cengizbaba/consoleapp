using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleapp.DataAccess.Abstract;
using consoleapp.Entity;


namespace consoleapp.DataAccess.Concrete
{
    public class MySQLCategoryDal : ICategoryRepository
    {

        public Category GetById(int id)
        {
            throw new System.NotImplementedException();
        }
        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Category entity)
        {
            Console.WriteLine("MySQLProductDal Kategori oluşturuldu.");
        }

        public void Delete(int id)
        { throw new System.NotImplementedException(); }
        public Category[] GetCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}