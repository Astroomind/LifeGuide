using System;
using System.Collections.Generic;
using System.Text;


namespace LifeGuide.Data
{
    public class LifeGuideDbContext : DbContext
    {
        DbContextOptions<LifeGuideDbContext> options : base(options)
            public DbSet<TodoItem> TodoItems => Set<TodoItems>();
    }
}
