using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IBrandRepository : IBasicRepository<Brand>
    {
        IEnumerable<Product>? GetProductsPaginate(int Page , int PageSize , Brand Brand);
        IEnumerable<Product>? GetProductsPaginate(int Page , int PageSize , int BrandId);
    }
}
