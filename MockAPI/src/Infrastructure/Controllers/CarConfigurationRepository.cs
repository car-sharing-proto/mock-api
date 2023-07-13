using Core.Application.Interfaces;
using Core.Domain.Models;

namespace Core.Infrastructure.Controllers
{
    public class CarConfigurationRepository : ICarConfigurationRepository
    {
        void ICarConfigurationRepository.Add(CarConfiguration configuration)
        {
            throw new NotImplementedException();
        }

        CarConfiguration ICarConfigurationRepository.GetByID(int id)
        {
            throw new NotImplementedException();
        }

        void ICarConfigurationRepository.RemoveByID(int id)
        {
            throw new NotImplementedException();
        }
    }
}
