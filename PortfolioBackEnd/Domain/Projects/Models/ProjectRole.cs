using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.Projects.ValueObjects;

namespace PortfolioBackEnd.Domain.Projects.Models;

public class ProjectRole : Entity<ProjectRoleId>
{
    public ProjectId ProjectId { get; private set; }
    public string? RoleDescription { get; private set; }
    public bool IsReleased { get; private set; }

    private ProjectRole(ProjectId projectId,
                       string?   roleDescription,
                       bool      isReleased)
    {
        ProjectId = projectId;
        RoleDescription = roleDescription;
        IsReleased = isReleased;
    }

    public static ProjectRole Create(ProjectId projectId,
                                     string?   roleDescription,
                                     bool      isReleased)
    {
        if (!projectId.Value.HasValue)
        {
            throw new ArgumentNullException($"{nameof(ProjectRole)} - {nameof(projectId)}");
        }
        
        return new ProjectRole(projectId, roleDescription, isReleased);
    }
}