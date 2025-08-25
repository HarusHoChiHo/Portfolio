namespace PortfolioBackEnd.Domain.Projects.ValueObjects;

public record ProjectImageId
{
    public int? Value { get; }
    
    private ProjectImageId(int? value) => Value = value;

    public static ProjectImageId Of(int? value) => new ProjectImageId(value);
}