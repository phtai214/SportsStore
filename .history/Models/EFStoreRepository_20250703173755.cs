namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context; public EFStoreRepository(StoreDbContext ctx) { context = ctx; }
        public IQueryable<Products> Products => context.Products;
        
    }
}

