namespace PortfolioBackEnd.Domain.PersonalInfo.ValueObjects;

public record PersonalInfoId
{
    public int? Value { get; }
    
    private PersonalInfoId(int? value) => Value = value;
    
    public static PersonalInfoId Of(int? value) => new (value);
}