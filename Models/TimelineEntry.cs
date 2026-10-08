
namespace CrazyCV.Models;

public enum EntryType
{
    Education,
    Work
}

public record TimelineEntry(
    string Id,
    string Title,
    string Organization,
    string Period,
    string Description,
    EntryType Type,
    bool Featured = false
);
