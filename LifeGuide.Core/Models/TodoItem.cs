using System;
namespace LifeGuide.Core.Models;

public class Class1
{
		public int Id { get; set; } = 0;

	    required public string Title { get; set; }
	     
	    public string? Notes { get; set; }

	    public bool IsCompleted { get; set; } = true;

	    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

	    public DateTime? CompletedAt { get; set; }

	    public DateTime? DueDate { get; set; }
}
