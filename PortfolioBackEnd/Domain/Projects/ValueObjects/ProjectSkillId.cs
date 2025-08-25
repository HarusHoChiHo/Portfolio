namespace PortfolioBackEnd.Domain.Projects.ValueObjects;

public record ProjectSkillId
{
    public int? Value { get; }
    
    private ProjectSkillId(int? value) => Value = value;

    public static ProjectSkillId Of(int? value) => new ProjectSkillId(value);
}