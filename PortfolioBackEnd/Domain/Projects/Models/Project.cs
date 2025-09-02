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
    
    public void AddProjectRole(ProjectRole projectRole)
    {
        ArgumentNullException.ThrowIfNull(projectRole.ProjectId);
        _projectRoles.Add(projectRole);
    }

    public void AddProjectLink(ProjectLink projectLink)
    {
        ArgumentNullException.ThrowIfNull(projectLink.ProjectId);
        _projectLinks.Add(projectLink);
    }

    public void AddProjectImage(ProjectImage projectImage)
    {
        ArgumentNullException.ThrowIfNull(projectImage.ProjectId);
        _projectImages.Add(projectImage);
    }

    public void UpdateProjectRole(ProjectRole projectRole)
    {
        ArgumentNullException.ThrowIfNull(projectRole.ProjectId);
        ArgumentNullException.ThrowIfNull(projectRole.Id);
        var role = _projectRoles.SingleOrDefault(x => x.Id == projectRole.Id);

        if (role is not null)
        {
            _projectRoles.Remove(role);
            _projectRoles.Add(projectRole);
        }
    }

    public void UpdateProjectLink(ProjectLink projectLink)
    {
        ArgumentNullException.ThrowIfNull(projectLink.ProjectId);
        var link = _projectLinks.SingleOrDefault(x => x.Id == projectLink.Id);

        if (link is not null)
        {
            _projectLinks.Remove(link);
            _projectLinks.Add(projectLink);
        }
    }

    public void UpdateProjectImage(ProjectImage projectImage)
    {
        ArgumentNullException.ThrowIfNull(projectImage.ProjectId);
        ArgumentNullException.ThrowIfNull(projectImage.Id);
        
        var image = _projectImages.SingleOrDefault(x => x.Id == projectImage.Id);
        
        if (image is not null)
        {
            _projectImages.Remove(image);
            _projectImages.Add(projectImage);
        }
    }

    public void RemoveProjectRole(ProjectRoleId projectRoleId)
    {
        ArgumentNullException.ThrowIfNull(projectRoleId);
        
        var role = _projectRoles.SingleOrDefault(x => x.Id == projectRoleId);

        if (role is not null)
        {
            _projectRoles.Remove(role);
        }
    }

    public void RemoveProjectLink(ProjectLinkId projectLinkId)
    {
        ArgumentNullException.ThrowIfNull(projectLinkId);
        
        var link = _projectLinks.SingleOrDefault(x => x.Id == projectLinkId);

        if (link is not null)
        {
            _projectLinks.Remove(link);
        }
    }

    public void RemoveProjectImage(ProjectImageId projectImageId)
    {
        ArgumentNullException.ThrowIfNull(projectImageId);
        
        var image = _projectImages.SingleOrDefault(x => x.Id == projectImageId);

        if (image is not null)
        {
            _projectImages.Remove(image);
        }
    }
}