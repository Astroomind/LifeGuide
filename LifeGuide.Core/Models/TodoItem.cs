namespace LifeGuide.Core.Models;

public class TodoItem
{
    public int Id { get; set; }

    public required string Title { get; set; }

    public string? Notes { get; set; }

    public bool IsCompleted { get; set; }

    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    public DateTime? CompletedAt { get; set; }

    public DateTime? DueDate { get; set; }
}
