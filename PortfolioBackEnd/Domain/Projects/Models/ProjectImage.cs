using PortfolioBackEnd.Domain.Abstraction;
using PortfolioBackEnd.Domain.Projects.ValueObjects;

namespace PortfolioBackEnd.Domain.Projects.Models;

public class ProjectImage : Entity<ProjectImageId>
{
    public ProjectId ProjectId { get; private set; }
    public string ImageUrl { get; private set; }
    public string? ImageDescription { get; private set; }
    public string? ImageTitle { get; private set; }

    private ProjectImage(ProjectId projectId,
                         string    imageUrl,
                         string?   imageDescription,
                         string?   imageTitle)
    {
        ProjectId = projectId;
        ImageUrl = imageUrl;
        ImageDescription = imageDescription;
        ImageTitle = imageTitle;
    }

    public static ProjectImage Of(ProjectId projectId,
                                  string    imageUrl,
                                  string?   imageDescription,
                                  string?   imageTitle)
    {
        ArgumentException.ThrowIfNullOrEmpty(nameof(imageUrl));

        if (!projectId.Value.HasValue)
        {
            throw new ArgumentNullException($"{nameof(ProjectImage)} - {nameof(projectId)}");
        }
        
        return new ProjectImage(projectId, imageUrl, imageDescription, imageTitle);
    }
}