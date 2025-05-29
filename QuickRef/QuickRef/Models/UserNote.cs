#nullable enable
namespace QuickRef.Models;

public class UserNote(string title, string content)
{
    public string Title { get; set; } = title;

    public string Content { get; set; } = content;

    public DateTime Created { get; set; } = DateTime.Now;

    // Tags
}
