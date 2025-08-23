using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.PersonalInfo.ValueObjects;

namespace PortfolioBackEnd.Domain.PersonalInfo.Models;

public class ContactInfo : Entity<ContactInfoId>
{
    public ContactInfoId Id { get; private set; }
    public PersonalInfoId PersonalInfoId { get; private set; }
    public string? DisplayText { get; private set; }
    public string? Link { get; private set; }
    public string Category { get; private set; }
    public bool IsReleased { get; private set; }

    internal ContactInfo(ContactInfoId  id,
                         PersonalInfoId personalInfoId,
                         string?        displayText,
                         string?        link,
                         string         category,
                         bool           isReleased)
    {
        Id = id;
        PersonalInfoId = personalInfoId;
        DisplayText = displayText;
        Link = link;
        Category = category;
        IsReleased = isReleased;
    }
    
}