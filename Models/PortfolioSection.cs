namespace CrazyCV.Models;

public enum PortfolioSection
{
    About,
    Projects,
    Skills,
    Experience,
    Beyond,
    Contact
}

public static class PortfolioSectionRoute
{
    public static PortfolioSection Parse(string? value) =>
        value?.Trim().ToLowerInvariant() switch
        {
            "projects" => PortfolioSection.Projects,
            "skills" => PortfolioSection.Skills,
            "experience" => PortfolioSection.Experience,
            "beyond" => PortfolioSection.Beyond,
            "contact" => PortfolioSection.Contact,
            _ => PortfolioSection.About
        };

    public static string ToSlug(this PortfolioSection section) =>
        section switch
        {
            PortfolioSection.Projects => "projects",
            PortfolioSection.Skills => "skills",
            PortfolioSection.Experience => "experience",
            PortfolioSection.Beyond => "beyond",
            PortfolioSection.Contact => "contact",
            _ => "about"
        };
}
