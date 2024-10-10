public interface IManagerService
{
    Task<IEnumerable<Manager>> GetAllManagersAsync();
    Task<Manager> GetManagerByIdAsync(int managerId);
    Task AddManagerAsync(Manager manager);
    Task UpdateManagerAsync(Manager manager);
    Task DeleteManagerAsync(Manager manager);
}