
using Microsoft.EntityFrameworkCore;
using System;

namespace REST_BOT.Models
{
    public class DayPlannerContext : DbContext
    {
   
        public DayPlannerContext(DbContextOptions<DayPlannerContext> options)
        : base(options)
        {
        }

        public DbSet<DayPlanner> planners { get; set; } = null!;
    }
}
