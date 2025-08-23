using MediatR;

namespace PortfolioBackEnd.Domain.Abstraction;

public interface IDomainEvent : INotification
{
    Guid Id => new Guid();
    
    public DateTime OccurredOn => new DateTime();
    
    public string EventType => GetType().AssemblyQualifiedName;
}