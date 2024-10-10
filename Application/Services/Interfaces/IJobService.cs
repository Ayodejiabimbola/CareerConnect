using CareerConnect.Domain.Job;

public interface IJobService
{
    Task<IEnumerable<JobPosting>> GetAllJobsAsync();
    Task<JobPosting> GetJobByIdAsync(int jobId);
    Task AddJobAsync(JobPosting job);
    Task UpdateJobAsync(JobPosting job);
    Task DeleteJobAsync(JobPosting job);
}