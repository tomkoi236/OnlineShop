using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Data.Infrastructure
{
    public class DBFactory : Disposable, IDisposable
    {
        private OnlineShopDbContext dbContext;
        public OnlineShopDbContext Init()
        {
            return dbContext ?? (dbContext = new OnlineShopDbContext());
        }
        protected override void DisposeCore()
        {
            if (dbContext != null)
            {
                base.DisposeCore();
            }
        }

    }
}
