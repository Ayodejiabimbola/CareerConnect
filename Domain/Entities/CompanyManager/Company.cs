using CareerConnect.Domain.Job;

public class Company : BaseEntity
{
    public string CompanyName { get; set; } = default!;
    public string CompanyAddress { get; set; } = default!;
    public string CompanyOverview { get; set; } = default!;
    public ICollection<JobPosting> Jobs { get; set; } = [];
}