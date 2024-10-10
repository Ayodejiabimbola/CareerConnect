public class ApplicationUser : BaseEntity
{
    public string Email { get; set; } = default!;
    public string PassWord { get; set; } = default!;
    public string UserType { get; set; } = default!;
}
