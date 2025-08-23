namespace PortfolioBackEnd.Domain.Abstraction;

public interface IAggregate<T> : IEntity<T>
{
    public IReadOnlyList<IDomainEvent> DomainEvents { get; }

    public IDomainEvent[] ClearDomainEvents();
}