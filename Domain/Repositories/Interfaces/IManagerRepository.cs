
namespace CareerConnect.Domain.Repositories.Interfaces;
public interface IManagerRepository
{
    Task<IEnumerable<Manager>> GetAllAsync();
    Task<Manager> GetByIdAsync(int managerId);
    Task AddAsync(Manager manager);
    Task UpdateAsync(Manager manager);
    Task DeleteAsync(Manager manager);
}
