using DiscountUz.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiscountUz.DataAccess.Repository.IRepository
{
    public interface IFavItemRepository : IRepository<FavItem>
    {
        void Update(FavItem obj);
        void Save();
    }
}
