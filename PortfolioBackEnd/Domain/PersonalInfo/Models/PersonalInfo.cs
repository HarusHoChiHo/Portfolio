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
        PersonalInfo personalInfo = new PersonalInfo(id, userId, biography);
        
        return personalInfo;
    }

    public void AddContactInfo(ContactInfo contactInfo)
    {
        ArgumentNullException.ThrowIfNull(contactInfo.Id.Value);
        _contactInfos.Add(contactInfo);
    }

    public void AddTechnology(Technology technology)
    {
        ArgumentNullException.ThrowIfNull(technology.Id.Value);
        _technologies.Add(technology);
    }

    public void RemoveContactInfo(ContactInfoId contactInfoId)
    {
        ArgumentNullException.ThrowIfNull(contactInfoId.Value);
        ContactInfo? contactInfo = _contactInfos.FirstOrDefault(x => x.Id.Value == contactInfoId.Value);

        if (contactInfo is not null)
        {
            _contactInfos.Remove(contactInfo);
        }
        
    }

    public void RemoveTechnology(TechnologyId technologyId)
    {
        ArgumentNullException.ThrowIfNull(technologyId.Value);
        Technology? technology = _technologies.FirstOrDefault(x => x.Id.Value == technologyId.Value);

        if (technology is not null)
        {
            _technologies.Remove(technology);
        }
    }
}