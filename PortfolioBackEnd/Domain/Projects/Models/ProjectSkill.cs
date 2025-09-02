using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.Projects.ValueObjects;

namespace PortfolioBackEnd.Domain.Projects.Models;

public class ProjectSkill : Entity<ProjectSkill>
{
    public ProjectId ProjectId { get; private set; }
    public string Name { get; private set; }
    public string Category { get; private set; }

    private ProjectSkill(ProjectId projectId,
                         string    name,
                         string    category)
    {
        ProjectId = projectId;
        Name = name;
        Category = category;
    }

    public static ProjectSkill Of(ProjectId projectId,
                                  string    name,
                                  string    category)
    {
        ArgumentException.ThrowIfNullOrEmpty(name);
        ArgumentException.ThrowIfNullOrEmpty(category);
        ArgumentNullException.ThrowIfNull(projectId.Value, nameof(projectId));

        return new ProjectSkill(projectId,
                                name,
                                category);
    }

}