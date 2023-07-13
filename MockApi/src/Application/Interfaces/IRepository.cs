using Core.Domain.Models;

namespace Core.Application.Interfaces
{
    public interface IRepository
    {
        void Add(CarConfiguration configuration);
    }
}
