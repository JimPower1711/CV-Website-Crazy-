
namespace CrazyCV.Models;

public record Skill(
    string Symbol,
    string Name,
    string Description,
    string Category,
    string? ProjectName = null,
    string? ProjectId = null
);
