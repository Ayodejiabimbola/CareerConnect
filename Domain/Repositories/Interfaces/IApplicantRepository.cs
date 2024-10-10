namespace CareerConnect.Domain.Repositories.Interfaces;

public interface IApplicantRepository
{
    Task<IEnumerable<Applicant>> GetAllAsync(); 
    Task<Applicant> GetByIdAsync(int applicantId);
    Task AddAsync(Applicant applicant);
    Task UpdateAsync(Applicant applicant);
    Task DeleteAsync(Applicant applicant);
}
