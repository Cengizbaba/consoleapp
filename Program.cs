using System;
using consoleapp.DataAccess.Abstract;
using consoleapp.DataAccess.Concrete;
using consoleapp.Entity;

namespace consoleapp
{
    class ProductManager : IProductRepository
    {   
        IProductRepository _repository;
        public ProductManager( IProductRepository repository)
        {
            _repository = repository;
        }

        public void Create(Product entity)
        {
            _repository.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetPopularProducts(int id)
        {
            throw new NotImplementedException();
        }

        public Product[] GetProductsByCategory(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }

    class CategoryManager : ICategoryRepository
    {
        ICategoryRepository _crepository;
        public CategoryManager(ICategoryRepository crepository)
        {
            _crepository = crepository;
        }
        public void Create(Category entity)
        {
            _crepository.Create(entity);
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Category GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public Category[] GetCategories()
        {
            throw new NotImplementedException();
        }

        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //var productDal = new EfProductDal();
            // var productDal = new MySQLProductDal();
            // productDal.Create(new Product());

            var productDal = new ProductManager(new MySQLProductDal());
            productDal.Create(new Product());

            var categoryDal = new CategoryManager(new MySQLCategoryDal());
            categoryDal.Create(new Category());

            //injection => IproductRepository => Server MySQLProductDal
            // yada MySQLProductDal

        }
    }
}
