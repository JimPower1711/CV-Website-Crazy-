
using CrazyCV.Models;

namespace CrazyCV.Services;

public class PersonalInterestService
{
    private readonly List<PersonalInterest> _interests = new()
    {
        new(
            "training",
            "Training",
            "◆",
            "The drive to improve.",
            "For me, training is about more than building strength. I enjoy setting goals, challenging myself and seeing what consistency can achieve over time."
        ),

        new(
            "gaming",
            "Gaming",
            "⌘",
            "More than just a game.",
            "Gaming brings together creativity, competition and problem solving. I enjoy exploring new worlds, discovering mechanics and challenging myself."
        ),

        new(
            "superheroes",
            "Superheroes",
            "✦",
            "The power of hope.",
            "What fascinates me about superheroes is more than their abilities. Characters like Superman represent hope, responsibility and the choice to do what's right."
        )
    };

    public IReadOnlyList<PersonalInterest> GetAll()
    {
        return _interests;
    }
}
