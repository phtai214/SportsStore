namespace SportsStore.Models
{
    public interface IStoreRepository
    {
        IQueryable<Products> Products { get; }
    }
}

