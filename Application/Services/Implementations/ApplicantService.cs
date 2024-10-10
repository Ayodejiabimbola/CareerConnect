using CareerConnect.Domain.Repositories.Interfaces;

public class ApplicantService(IApplicantRepository applicantRepository) : IApplicantService
{
    private readonly IApplicantRepository _applicantRepository = applicantRepository;

    public async Task AddApplicantAsync(Applicant applicant)
    {
        await _applicantRepository.AddAsync(applicant);
    }

    public async Task DeleteApplicantAsync(Applicant applicant)
    {
        await _applicantRepository.DeleteAsync(applicant);
    }

    public async Task<IEnumerable<Applicant>> GetAllApplicantsAsync()
    {
        return await _applicantRepository.GetAllAsync();
    }

    public async Task<Applicant> GetApplicantByIdAsync(int jobId)
    {
        return await _applicantRepository.GetByIdAsync(jobId);
    }

    public async Task UpdateApplicantAsync(Applicant applicant)
    {
        await _applicantRepository.UpdateAsync(applicant);
    }
}