using CareerConnect.Domain.Job;
using CareerConnect.Domain.Repositories.Interfaces;

public class JobService(IJobRepository jobRepository) : IJobService
{
    private readonly IJobRepository _jobRepository = jobRepository;

    public async Task AddJobAsync(JobPosting job)
    {
        await _jobRepository.AddAsync(job);
    }

    public async Task DeleteJobAsync(JobPosting job)
    {
        await _jobRepository.DeleteAsync(job);
    }

    public async Task<IEnumerable<JobPosting>> GetAllJobsAsync()
    {
        return await _jobRepository.GetAllAsync();
    }

    public async Task<JobPosting> GetJobByIdAsync(int jobId)
    {
        return await _jobRepository.GetByIdAsync(jobId);
    }

    public async Task UpdateJobAsync(JobPosting job)
    {
        await _jobRepository.UpdateAsync(job);
    }
}