namespace PortfolioBackEnd.Domain.Projects.ValueObjects;

public record ProjectId
{
    public int? Value { get; }
    
    private ProjectId(int? value) => Value = value;

    public static ProjectId Of(int? value) => new ProjectId(value);
}