namespace CareerConnect.Domain.Job;
public class JobPosting : BaseEntity
{
    public string JobTitle { get; set; } = default!;
    public string JobDescription { get; set; } = default!;
    public string EmploymentType { get; set; } = default!;
    public string? Image { get; set; } = default!;
    public string SalaryRange { get; set; } = default!;
    public string WorkPlace { get; set; } = default!;
}