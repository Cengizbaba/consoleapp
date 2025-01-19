using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using consoleapp.Entity;
using consoleapp.DataAccess.Abstract;

namespace consoleapp.DataAccess.Abstract
{
    public interface ICategoryRepository : IRepository<Category>
    {
        Category[] GetCategories();
    }
}