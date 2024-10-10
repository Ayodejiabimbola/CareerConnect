using CareerConnect.Domain.Repositories.Interfaces;

public class ManagerService : IManagerService
{
    private readonly IManagerRepository _managerRepository;

    public ManagerService(IManagerRepository managerRepository)
    {
        _managerRepository = managerRepository;
    }

    public async Task AddManagerAsync(Manager manager)
    {
        await _managerRepository.AddAsync(manager);
    }

    public async Task DeleteManagerAsync(Manager manager)
    {
        await _managerRepository.DeleteAsync(manager);
    }

    public async Task<IEnumerable<Manager>> GetAllManagersAsync()
    {
        return await _managerRepository.GetAllAsync();
    }

    public async Task<Manager> GetManagerByIdAsync(int managerId)
    {
        return await _managerRepository.GetByIdAsync(managerId);
    }

    public async Task UpdateManagerAsync(Manager manager)
    {
        await _managerRepository.UpdateAsync(manager);
    }
}