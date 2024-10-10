public interface ICompanyService
{
    Task<IEnumerable<Company>> GetAllCompaniesAsync();
    Task<Company> GetCompanyByIdAsync(int companyId);
    Task AddCompanyAsync(Company company);
    Task UpdateCompanyAsync(Company company);
    Task DeleteCompanyAsync(Company company);
}