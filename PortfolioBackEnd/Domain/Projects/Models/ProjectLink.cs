using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.Projects.ValueObjects;

namespace PortfolioBackEnd.Domain.Projects.Models;

public class ProjectLink : Entity<ProjectLinkId>
{
    public ProjectId ProjectId { get; private set; }
    public string? DisplayText { get; private set; }
    public string? Link { get; private set; }
    public bool IsReleased { get; private set; }

    private ProjectLink(ProjectId projectId,
                        string?   displayText,
                        string?   link,
                        bool      isReleased)
    {
        ProjectId = projectId;
        DisplayText = displayText;
        Link = link;
        IsReleased = isReleased;
    }

    public static ProjectLink Create(ProjectId projectId,
                                     string?   displayText,
                                     string?   link,
                                     bool    isReleased)
    {
        if (!projectId.Value.HasValue)
        {
            throw new ArgumentNullException($"{nameof(ProjectLink)} - {nameof(projectId)}");
        }
        
        return new ProjectLink(projectId, displayText, link, isReleased);
    }
}