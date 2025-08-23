namespace PortfolioBackEnd.Domain.Abstraction;

public abstract class Aggregate<TId> : IAggregate<TId>
{
    private List<IDomainEvent> _domainEvents = new ();
    public TId Id { get; set; }
    public IReadOnlyList<IDomainEvent> DomainEvents => _domainEvents.AsReadOnly();

    public IDomainEvent[] ClearDomainEvents()
    {
        throw new NotImplementedException();
    }
}