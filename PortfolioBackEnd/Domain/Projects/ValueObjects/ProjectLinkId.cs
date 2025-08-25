namespace PortfolioBackEnd.Domain.Projects.ValueObjects;

public record ProjectLinkId
{
    public int? Value { get; }
    
    private ProjectLinkId(int? value) => Value = value;

    public static ProjectLinkId Of(int? value) => new ProjectLinkId(value);
}