using OnlineShop.Data.Infrastructure;
using ShopOnline.Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer>
    {
    }
    class FooterRepository : RepositoryBase<Footer>,IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}
