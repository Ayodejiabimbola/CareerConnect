using System.Reflection;
using CareerConnect.Domain.Job;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CareerConnect.Infrastructure.Context;
public class CareerConnectDbContext(DbContextOptions<CareerConnectDbContext> options) : IdentityDbContext(options)
{
    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

    public DbSet<JobPosting> JobPostings { get; set; }
    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Company> Companies { get; set; }
}
