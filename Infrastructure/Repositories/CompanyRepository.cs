using CareerConnect.Domain.Repositories.Interfaces;
using CareerConnect.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CareerConnect.Infrastructure.Repositories
{
    public class CompanyRepository : ICompanyRepository
    {
        private readonly CareerConnectDbContext _careerConnectDbContext;

        public CompanyRepository(CareerConnectDbContext careerConnectDbContext)
        {
            _careerConnectDbContext = careerConnectDbContext;
        }

        public async Task<IEnumerable<Company>> GetAllAsync()
        {
            return await _careerConnectDbContext.Companies.ToListAsync();
        }

        public async Task<Company> GetByIdAsync(int companyId) 
        {
            var company = await _careerConnectDbContext.Companies.FirstOrDefaultAsync(c => c.Id == companyId);
            if (company == null)
            {
                throw new NullReferenceException();
            }
            return company;
        }

        public async Task AddAsync(Company company) 
        {
            await _careerConnectDbContext.Companies.AddAsync(company);
            await _careerConnectDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Company company)
        {
            _careerConnectDbContext.Companies.Update(company);
            await _careerConnectDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Company company)
        {
            _careerConnectDbContext.Companies.Remove(company);
            await _careerConnectDbContext.SaveChangesAsync();
        }
    }
}