public interface IApplicantService
{
    Task<IEnumerable<Applicant>> GetAllApplicantsAsync();
    Task<Applicant> GetApplicantByIdAsync(int jobId);
    Task AddApplicantAsync(Applicant job);
    Task UpdateApplicantAsync(Applicant job);
    Task DeleteApplicantAsync(Applicant job);
}