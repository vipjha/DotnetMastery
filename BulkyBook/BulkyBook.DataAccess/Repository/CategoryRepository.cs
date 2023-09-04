﻿using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBookWeb.Data;
using BulkyBookWeb.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CategoryRepository : Repository<Category>, ICategoryRepository
    {
        private ApplicationDbContext _db;

        public CategoryRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        

        public void Update(Category obj)
        {
            _db.Categories.Update(obj);

            //throw new NotImplementedException();
        }
    }
}
