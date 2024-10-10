using CareeeConnect.Domain.Repositories.Interfaces;
using CareerConnect.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace CareeeConnect.Infrastructure.Repositories;

public class ApplicantRepository : IApplicantRepository
{
    private readonly CareerConnectDbContext _careerConnectDbContext;
    public ApplicantRepository(CareerConnectDbContext careerConnectDbContext)
    {
        _careerConnectDbContext = careerConnectDbContext;
    }
    public async Task<IEnumerable<Applicant>> GetAllAsync()
    {
        return await _careerConnectDbContext.Applicants.ToListAsync();
    }

    public async Task<Applicant> GetByIdAsync(int applicantId)
    {
        var applicant = await _careerConnectDbContext.Applicants.FirstOrDefaultAsync(a => a.Id == applicantId);
        if (applicant == null)
        {
            throw new NullReferenceException();
        }
        return applicant;
    }

    public async Task AddAsync(Applicant applicant)
    {
        await _careerConnectDbContext.Applicants.AddAsync(applicant);
        await _careerConnectDbContext.SaveChangesAsync();
    }

    public async Task UpdateAsync(Applicant applicant)
    {
        _careerConnectDbContext.Applicants.Update(applicant);
        await _careerConnectDbContext.SaveChangesAsync();
    }

    public async Task DeleteAsync(Applicant applicant)
    {
        _careerConnectDbContext.Applicants.Remove(applicant);
        await _careerConnectDbContext.SaveChangesAsync();
    }
}