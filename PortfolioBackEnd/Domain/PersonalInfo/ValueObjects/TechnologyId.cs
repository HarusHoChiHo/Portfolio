namespace PortfolioBackEnd.Domain.PersonalInfo.ValueObjects;

public record TechnologyId
{
    public int? Value { get; }
    
    private TechnologyId(int? value) => Value = value;

    public static TechnologyId Of(int? value) => new (value);
}