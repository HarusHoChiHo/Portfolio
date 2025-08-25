using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.PersonalInfo.ValueObjects;

namespace PortfolioBackEnd.Domain.PersonalInfo.Models;

public class Technology : Entity<TechnologyId>
{
    public string Name { get; private set; }
    public string Category { get; private set; }

    internal Technology(TechnologyId id,
                        string       name,
                        string       category)
    {
        Id = id;
        Name = name;
        Category = category;
    }
}