namespace PortfolioBackEnd.Domain.User.ValueObjects;

public record Password
{
    public string Value { get; }
    
    public Password(string value) => Value = value;

    public static Password Of(string value)
    {
        ArgumentNullException.ThrowIfNullOrWhiteSpace(value);
        ArgumentNullException.ThrowIfNullOrEmpty(value);

        return new Password(value);
    }
    
}