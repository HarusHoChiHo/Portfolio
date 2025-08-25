using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.Projects.ValueObjects;
using PortfolioBackEnd.Domain.User.ValueObjects;

namespace PortfolioBackEnd.Domain.Projects.Models;

public class Project : Entity<ProjectId>
{

    public UserId UserId { get; private set; }
    public string Name { get; private set; }
    public string? Description { get; private set; }
    public string? Details { get; private set; }
    public int Order { get; private set; }
    public bool IsReleased { get; private set; }

    public IReadOnlyCollection<ProjectRole> ProjectRoles => _projectRoles.AsReadOnly();
    public IReadOnlyCollection<ProjectLink> ProjectLinks => _projectLinks.AsReadOnly();
    public IReadOnlyCollection<ProjectImage> ProjectImages => _projectImages.AsReadOnly();
    public IReadOnlyCollection<ProjectSkill> ProjectSkills => _projectSkills.AsReadOnly();

    private List<ProjectRole> _projectRoles = new();

    private List<ProjectLink> _projectLinks = new();

    private List<ProjectImage> _projectImages = new();

    private List<ProjectSkill> _projectSkills = new();

    private Project(UserId  userId,
                    string  name,
                    string? description,
                    string? details,
                    int     order,
                    bool    isReleased)
    {
        UserId = userId;
        Name = name;
        Description = description;
        Details = details;
        Order = order;
        IsReleased = isReleased;
    }

    public static Project Create(UserId  userId,
                                 string  name,
                                 string? description,
                                 string? details,
                                 int     order,
                                 bool    isReleased)
    {
        ArgumentNullException.ThrowIfNull(userId.Value);
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentOutOfRangeException.ThrowIfLessThan(order,
                                                    1);

        return new Project(userId,
                           name,
                           description,
                           details,
                           order,
                           isReleased);
    }

   //TODO: Add add ProjectRole, ProjectLink, ProjectImage, ProjectSkill
    
    public void Update(string  name,
                       string? description,
                       string? details,
                       int     order,
                       bool    isReleased)
    {
        Name = name;
        Description = description;
        Details = details;
        Order = order;
        IsReleased = isReleased;
    }
}