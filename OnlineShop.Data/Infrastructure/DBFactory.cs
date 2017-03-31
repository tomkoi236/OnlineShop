namespace OnlineShop.Data.Infrastructure
{
    public class DBFactory : Disposable, IDbFactory
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