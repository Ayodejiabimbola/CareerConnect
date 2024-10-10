using CareerConnect.Domain.Job;
using CareerConnect.Domain.Repositories.Interfaces;
using CareerConnect.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
namespace CareerConnect.Infrastructure.Repositories;
public class JobRepository : IJobRepository
{
    private readonly CareerConnectDbContext _careerConnectDbContext;
    public JobRepository(CareerConnectDbContext careerConnectDbContext)
    {
        _careerConnectDbContext = careerConnectDbContext;
    }
    public async Task<IEnumerable<JobPosting>> GetAllAsync()
    {
        return await _careerConnectDbContext.JobPostings.ToListAsync();
    }

    public async Task<JobPosting> GetByIdAsync(int jobId)
    {
        var job = await _careerConnectDbContext.JobPostings.FirstOrDefaultAsync(j => j.Id == jobId);
        if (job == null)
        {
            throw new NullReferenceException();
        }
        return job;
    }

    public async Task AddAsync(JobPosting job)
    {
        await _careerConnectDbContext.JobPostings.AddAsync(job);
        await _careerConnectDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(JobPosting job)
    {
        _careerConnectDbContext.JobPostings.Update(job);
        await _careerConnectDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(JobPosting job)
    {
        _careerConnectDbContext.JobPostings.Remove(job);
        await _careerConnectDbContext.SaveChangesAsync();
    }
}
