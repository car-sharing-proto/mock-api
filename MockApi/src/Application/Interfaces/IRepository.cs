using Core.Domain.Models;

namespace Core.src.Application.Interfaces
{
    public interface IRepository
    {
        void Add(CarConfiguration configuration);
    }
}
