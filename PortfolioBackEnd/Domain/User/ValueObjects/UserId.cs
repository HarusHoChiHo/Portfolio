namespace PortfolioBackEnd.Domain.User.ValueObjects;

public record UserId
{
    public int? Value { get; }
    
    private UserId(int? value) => Value = value;

    public static UserId Of(int? value) => new UserId(value);
}