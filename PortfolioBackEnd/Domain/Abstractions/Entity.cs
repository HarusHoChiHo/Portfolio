namespace PortfolioBackEnd.Domain.Abstraction;

public abstract class Entity<T> : IEntity<T>
{

    public T Id { get; set; }
}