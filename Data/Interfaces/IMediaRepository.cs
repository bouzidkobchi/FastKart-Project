using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IMediaRepository : IBasicRepository<Media>
    {
        void delete(int mediaId);
    }
}
