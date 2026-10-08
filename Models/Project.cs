
namespace CrazyCV.Models;

public record Project(
    string Id,
    string Title,
    string Description,
    List<string> Technologies,
    string? GitHubUrl = null,
    string? Challenge = null,
    string? MyContribution = null,
    string? LessonsLearned = null
);
