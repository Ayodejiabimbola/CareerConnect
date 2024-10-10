public class Manager : BaseEntity
{
    public string FirstName {get; set;} = default!;
    public string LastName {get; set;} = default!;
    public Company CompanyName {get;} = default!;
}