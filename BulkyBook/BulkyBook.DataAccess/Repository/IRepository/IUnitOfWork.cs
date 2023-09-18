using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkyBook.DataAccess.Repository.IRepository
{
    public interface IUnitOfWork
    {
        ICategoryRepository CategoryUnit { get; }
        ICoverTypeRepository CoverTypeUnit { get; }
        IProductRepository ProductUnit { get; }

        void Save();
    }
}
