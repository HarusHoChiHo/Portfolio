namespace PortfolioBackEnd.Domain.PersonalInfo.ValueObjects;

public record ContactInfoId
{
    public int? Value { get; }
    
    private ContactInfoId(int? value) => Value = value;

    public static ContactInfoId Of(int? value) => new (value);
}