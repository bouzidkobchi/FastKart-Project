using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IManufactorRepository : IBasicRepository<Manufactor>
    {
        // Read :
        int Count();
        Dictionary<Manufactor, int> ProductPerManufactor();
        IEnumerable<Manufactor> GetAllManufactors();
        IEnumerable<string> GetAllManufactorNames();

        // Create :
        int AddForm(string ManufactorName);

        // Update :
        void UpdateForm(Manufactor Manufactor, string Name);
        void UpdateForm(string ManufactorName, string Name);

        // Delete :
        void DeleteForm(string ManufactorName);
        void DeleteForm(Manufactor Manufactor);
    }
}
