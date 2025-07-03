namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Products> Products { get; }

        void SaveProduct(Product p);
        void CreateProduct(Product p); void DeleteProduct(Product p);
    }
}

