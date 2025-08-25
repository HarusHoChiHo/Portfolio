using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.User.ValueObjects;
using PortfolioBackEnd.Domain.Experience.ValueObjects;

namespace PortfolioBackEnd.Domain.Experience.Models;

public class Experience : Entity<ExperienceId>
{
    public UserId UserId { get; private set; }
    public string JobTitle { get; private set; }
    public string CompanyName { get; private set; }
    public string Duration { get; private set; }
    public bool IsReleased { get; private set; }

    private Experience(UserId userId,
                       string jobTitle,
                       string companyName,
                       string duration,
                       bool   isReleased)
    {
        UserId = userId;
        JobTitle = jobTitle;
        CompanyName = companyName;
        Duration = duration;
        IsReleased = isReleased;
    }

    public static Experience Create(UserId userId,
                                    string jobTitle,
                                    string companyName,
                                    string duration,
                                    bool   isReleased)
    {
        ArgumentNullException.ThrowIfNull(userId.Value);
        ArgumentException.ThrowIfNullOrEmpty(jobTitle);
        ArgumentNullException.ThrowIfNull(companyName);
        ArgumentNullException.ThrowIfNull(duration);

        return new Experience(userId,
                              jobTitle,
                              companyName,
                              duration,
                              isReleased);
    }

    public void Update(string jobTitle,
                       string companyName,
                       string duration,
                       bool   isReleased)
    {
        JobTitle = jobTitle;
        CompanyName = companyName;
        Duration = duration;
        IsReleased = isReleased;
    }
}