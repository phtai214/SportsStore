namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Products> Products { get; }

        void SaveProduct(Products p);
        void CreateProduct(Products p);
        void DeleteProduct(Products p);
    }
}

