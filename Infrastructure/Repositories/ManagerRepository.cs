using CareerConnect.Domain.Repositories.Interfaces;
using CareerConnect.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CareerConnect.Infrastructure.Repositories
{
    public class ManagerRepository : IManagerRepository 
    {
        private readonly CareerConnectDbContext _careerConnectDbContext;

        public ManagerRepository(CareerConnectDbContext careerConnectDbContext)
        {
            _careerConnectDbContext = careerConnectDbContext;
        }

        public async Task<IEnumerable<Manager>> GetAllAsync()
        {
            return await _careerConnectDbContext.Managers.ToListAsync();
        }

        public async Task<Manager> GetByIdAsync(int managerId) 
        {
            var manager = await _careerConnectDbContext.Managers.FirstOrDefaultAsync(m => m.Id == managerId); 
            if (manager == null)
            {
                throw new NullReferenceException();
            }
            return manager;
        }

        public async Task AddAsync(Manager manager)
        {
            await _careerConnectDbContext.Managers.AddAsync(manager);
            await _careerConnectDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Manager manager)
        {
            _careerConnectDbContext.Managers.Update(manager);
            await _careerConnectDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Manager manager) 
        {
            _careerConnectDbContext.Managers.Remove(manager);
            await _careerConnectDbContext.SaveChangesAsync();
        }
    }
}