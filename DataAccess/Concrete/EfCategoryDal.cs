using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleapp.Entity;
using consoleapp.DataAccess.Abstract;

namespace consoleapp.DataAccess.Concrete
{
    public class EfCategoryDal : ICategoryRepository
    {
        public Category GetById(int Id)
        {
            throw new System.NotImplementedException();
        }
        public void Update(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Create(Category entity)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new System.NotImplementedException();
        }
        public Category[] GetCategories()
        {
            throw new System.NotImplementedException();
        }
    }
}