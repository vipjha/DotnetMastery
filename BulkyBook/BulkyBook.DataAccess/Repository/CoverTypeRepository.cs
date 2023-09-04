using BulkyBook.DataAccess.Repository.IRepository;
using BulkyBook.Models.Models;
using BulkyBookWeb.Data;
using BulkyBookWeb.Models;

namespace BulkyBook.DataAccess.Repository
{
    public class CoverTypeRepository : Repository<CoverType>, ICoverTypeRepository
    {
        private ApplicationDbContext _db;

        public CoverTypeRepository(ApplicationDbContext db) : base(db) 
        {
            _db = db;
        }
        

        public void Update(CoverType obj)
        {
            _db.CoverTypes.Update(obj);

            //throw new NotImplementedException();
        }
    }
}
