using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Quiz.Models
{
    public class QuestionsDbContext : DbContext
    {
        public QuestionsDbContext(DbContextOptions<QuestionsDbContext> opt) : base(opt) { }

        public DbSet<Question> Questions { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Question>().HasData(new Question() { Id = System.Guid.NewGuid(), Text = "How many fingers do person have?", Correct = "20", Incorrect = "10" });
            modelBuilder.Entity<Question>().HasData(new Question() { Id = System.Guid.NewGuid(), Text = "What's the temperature of Sun?", Correct = "about 5500°C", Incorrect = "about 7893°C" });
            modelBuilder.Entity<Question>().HasData(new Question() { Id = System.Guid.NewGuid(), Text = "What CPU means?", Correct = "Central Processing Unit", Incorrect = "Control Processing Utility" });
        }
    }
}
