using FastKart.Data.Entities;

namespace FastKart.Data.Interfaces
{
    public interface IBrandRepository
    {
        // Read :
        int Count();
        IEnumerable<Product> GetProductsPaginate(int Page , int PerPage);
        IEnumerable<Product> GetProductsPaginate(int Page , int PerPage , Brand Brand);
        IEnumerable<Product> GetProductsPaginate(int Page , int PerPage , int BrandId);
        Dictionary<Brand, int> ProductPerBrand();

        // Create :
        int AddNewBrand(string BrandName); // return -1 if the brandName exists

        // Delete :
        void DeleteBrand(Brand brand);
        void DeleteBrand(string brandName);


    }
}
