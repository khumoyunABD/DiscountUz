using DiscountUz.DataAccess.Repository.IRepository;
using DiscountUz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountUz.DataAccess.Repository
{
    public class FavItemRepository : Repository<FavItem>, IFavItemRepository
    {
        private readonly ApplicationDbContext _db;

        public FavItemRepository(ApplicationDbContext db) : base(db)
        {
            _db = db;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(FavItem obj)
        {
            _db.FavItems.Update(obj);
        }
    }
}
