namespace PortfolioBackEnd.Domain.Projects.ValueObjects;

public record ProjectRoleId
{
    public int? Value { get; }
    
    private ProjectRoleId(int? value) => Value = value;
    
    public static ProjectRoleId Of(int? value) => new ProjectRoleId(value);
}