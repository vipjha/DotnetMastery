using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBookWeb.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationDbContext _db;

        public UnitOfWork(ApplicationDbContext db) 
        {
            _db = db;
            CategoryUnit = new CategoryRepository(_db);
            CoverTypeUnit = new CoverTypeRepository(_db);
            ProductUnit = new ProductRepository(_db);
        } 
        public ICategoryRepository CategoryUnit { get; private set; }
        public ICoverTypeRepository CoverTypeUnit { get; private set; }
        public IProductRepository ProductUnit { get; private set; }

        public void Save()
        {
            _db.SaveChanges();
        }
    }
}
