namespace PortfolioBackEnd.Domain.User.ValueObjects;

public record Password
{
    public string Value { get; }
    
    private Password(string value) => Value = value;

    public static Password Of(string value)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(value);
        ArgumentException.ThrowIfNullOrEmpty(value);

        return new Password(value);
    }
    
}