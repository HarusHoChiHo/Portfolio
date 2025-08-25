using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.PersonalInfo.ValueObjects;
using PortfolioBackEnd.Domain.User.ValueObjects;

namespace PortfolioBackEnd.Domain.PersonalInfo.Models;

public class PersonalInfo : Aggregate<PersonalInfoId>
{
    private readonly List<ContactInfo> _contactInfos = new();

    public IReadOnlyList<ContactInfo> ContactInfos => _contactInfos.AsReadOnly();

    private readonly List<Technology> _technologies = new();

    public IReadOnlyList<Technology> Technologies => _technologies.AsReadOnly();

    public UserId UserId { get; private set; } = default;

    public string? Biography { get; private set; } = default;

    private PersonalInfo(
        PersonalInfoId id,
        UserId         userId,
        string?        biography)
    {
        Id = id;
        UserId = userId;
        Biography = biography;
    }

    public static PersonalInfo Create(PersonalInfoId id,
                                      UserId         userId,
                                      string?        biography)
    {
        var personalInfo = new PersonalInfo(id, userId, biography);
        
        return personalInfo;
    }

    public void AddContactInfo(ContactInfo contactInfo)
    {
        if (!contactInfo.Id.Value.HasValue)
        {
            throw new ArgumentNullException(nameof(contactInfo));
        }

        _contactInfos.Add(contactInfo);
    }

    public void AddTechnology(Technology technology)
    {
        if (!technology.Id.Value.HasValue)
        {
            throw new ArgumentNullException(nameof(technology.Id));
        }

        _technologies.Add(technology);
    }

    public void RemoveContactInfo(ContactInfoId contactInfoId)
    {
        if (!contactInfoId.Value.HasValue)
        {
            throw new ArgumentNullException(nameof(contactInfoId));
        }

        var contactInfo = _contactInfos.FirstOrDefault(x => x.Id.Value == contactInfoId.Value);

        if (contactInfo is not null)
        {
            _contactInfos.Remove(contactInfo);
        }
        
    }

    public void RemoveTechnology(TechnologyId technologyId)
    {
        if (!technologyId.Value.HasValue)
        {
            throw new ArgumentNullException(nameof(technologyId));
        }

        var technology = _technologies.FirstOrDefault(x => x.Id.Value == technologyId.Value);

        if (technology is not null)
        {
            _technologies.Remove(technology);
        }
    }
}