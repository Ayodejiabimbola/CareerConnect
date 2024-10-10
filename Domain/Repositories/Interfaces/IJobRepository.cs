using CareerConnect.Domain.Job;

namespace CareerConnect.Domain.Repositories.Interfaces;
public interface IJobRepository
{
    Task<IEnumerable<JobPosting>> GetAllAsync();
    Task<JobPosting> GetByIdAsync(int jobId);
    Task AddAsync(JobPosting job);
    Task UpdateAsync(JobPosting job);
    Task DeleteAsync(JobPosting job);
}
