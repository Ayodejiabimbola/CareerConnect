using CareerConnect.Domain.Repositories.Interfaces;

public class CompanyService : ICompanyService
{
    private readonly ICompanyRepository _companyRepository;

    public CompanyService(ICompanyRepository companyRepository)
    {
        _companyRepository = companyRepository;
    }

    public async Task AddCompanyAsync(Company company)
    {
        await _companyRepository.AddAsync(company);
    }

    public async Task DeleteCompanyAsync(Company company)
    {
        await _companyRepository.DeleteAsync(company);
    }

    public async Task<IEnumerable<Company>> GetAllCompaniesAsync()
    {
        return await _companyRepository.GetAllAsync();
    }

    public async Task<Company> GetCompanyByIdAsync(int companyId)
    {
        return await _companyRepository.GetByIdAsync(companyId);
    }

    public async Task UpdateCompanyAsync(Company company)
    {
        await _companyRepository.UpdateAsync(company);
    }
}