using OnlineShop.Data.Infrastructure;
using ShopOnline.Model.Models;

namespace OnlineShop.Data.Repositories
{
    public interface IFooterRepository : IRepository<Footer> 
    {
    }

    internal class FooterRepository : RepositoryBase<Footer>, IFooterRepository
    {
        public FooterRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }
}