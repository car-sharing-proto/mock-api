using Core.Domain.Models;

namespace Core.Application.Interfaces
{
    public interface ICarConfigurationRepository
    {
        void Add(CarConfiguration configuration);
        void RemoveByID(int id);
        CarConfiguration GetByID(int id);
    }
}
