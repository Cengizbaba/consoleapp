using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace consoleapp.DataAccess.Abstract
{
    public interface IRepository<TEntity>
    {

        TEntity GetById(int Id);
        void Update(TEntity entity);
        void Create(TEntity entity);
        void Delete(int id);

    }
}