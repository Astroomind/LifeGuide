namespace LifeGuide.Core.Models;

public class TodoItem
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public string? Notes { get; set; }

    public bool IsCompleted => CompletedAt is not null;

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? CompletedAt { get; set; }

    public DateTime? DueDate { get; set; }


    public void MarkComplete()
    {
        if (IsCompleted) return;

        CompletedAt = DateTime.UtcNow;
    }

    public void MarkIncomplete()
    {
        CompletedAt = null;
    }
}
