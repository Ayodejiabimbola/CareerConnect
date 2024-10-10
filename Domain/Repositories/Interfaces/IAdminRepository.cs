
namespace CareerConnect.Domain.Repositories.Interfaces;
public interface IAdminRepository
{
    Task<IEnumerable<Admin>> GetAllAsync();
    Task<Admin> GetByIdAsync(int adminId);
    Task CreateAsync(Admin admin);
    Task UpdateAsync(Admin admin);
    Task DeleteAsync(Admin admin);
}
