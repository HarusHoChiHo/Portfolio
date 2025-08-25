namespace PortfolioBackEnd.Domain.Experience.ValueObjects;

public record ExperienceId
{
    public int? Value { get; }
    
    private ExperienceId(int? value) => Value = value;

    public static ExperienceId Of(int? value) => new ExperienceId(value);
}