using MockApi.Domain.Models;

namespace MockApi.Application.Interfaces
{
    public interface IRepository
    {
        void Add(CarConfiguration configuration);
    }
}
