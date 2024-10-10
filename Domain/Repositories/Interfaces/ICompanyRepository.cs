
namespace CareerConnect.Domain.Repositories.Interfaces;
public interface ICompanyRepository
{
    Task<IEnumerable<Company>> GetAllAsync();
    Task<Company> GetByIdAsync(int companyId);
    Task AddAsync(Company company);
    Task UpdateAsync(Company company);
    Task DeleteAsync(Company company);
}
