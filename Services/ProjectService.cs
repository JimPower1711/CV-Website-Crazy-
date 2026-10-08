
using CrazyCV.Models;

namespace CrazyCV.Services;

public class ProjectService
{

    private readonly List<Project> _projects = new()
{
    new(
        "galactic-slicer",
        "Galactic Slicer",
        "A Star Wars-inspired platform for learning cybersecurity.",
        new List<string> { "C#", ".NET", "SQLite" },

        Challenge: "Make cybersecurity concepts easier to learn through interactive challenges.",

        MyContribution: "ASP.NET Core setup, database configuration, Entity Framework, validation, error handling and logging.",

        LessonsLearned: "Building structured .NET applications, working with databases and improving backend reliability.",

        ImagePath: "/images/projects/galactic-slicer.png"
    ),

    new(
        "rocket-league-ml",
        "Rocket League Skill Detection",
        "Machine learning model for classifying gameplay skills.",
        new List<string> { "Python", "Pandas", "Scikit-learn" },

        Challenge: "Recognize different Rocket League skills from gameplay data.",

        MyContribution: "Data preprocessing, feature engineering and training a Decision Tree classifier.",

        LessonsLearned: "Preparing time-series data, training classification models and evaluating predictions.",

        ImagePath: "/images/projects/rocketleague.png"
    )
};


    public IReadOnlyList<Project> GetAll()
    {
        return _projects;
    }

    public Project? GetById(string id)
    {
        return _projects.FirstOrDefault(p => p.Id == id);
    }
}
