using FastKart.Data.Entities;
using FastKart.Data.Interfaces.Shared;

namespace FastKart.Data.Interfaces
{
    public interface IPaymentRepository : IBasicRepository<paymentMethod>
    {
        IEnumerable<string> GetPaymentNames();
    }
}
