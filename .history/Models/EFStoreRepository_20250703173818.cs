namespace SportsStore.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context; public EFStoreRepository(StoreDbContext ctx) { context = ctx; }
        public IQueryable<Products> Products => context.Products;

        public void CreateProduct(Products p) { context.Add(p); context.SaveChanges(); }
        public void DeleteProduct(Products p) { context.Remove(p); context.SaveChanges(); }
        public void SaveProduct(Products p) { context.SaveChanges(); }
    }
}

