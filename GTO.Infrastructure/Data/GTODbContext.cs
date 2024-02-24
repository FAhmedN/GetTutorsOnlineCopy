using GTO.EntityModel.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTO.Infrastructure.Data;

public class GTODbContext : DbContext
{
    public GTODbContext(DbContextOptions<GTODbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<SubjectName>().HasData(
               new SubjectName() { Id = 1, SubName = "Learning Environment" },
               new SubjectName() { Id = 2, SubName = "Physics" },
               new SubjectName() { Id = 3, SubName = "Chemistry" },
               new SubjectName() { Id = 4, SubName = "Biology" },
               new SubjectName() { Id = 5, SubName = "English" },
               new SubjectName() { Id = 6, SubName = "ELA" },
               new SubjectName() { Id = 7, SubName = "Reading" },
               new SubjectName() { Id = 8, SubName = "Mathematics" },
               new SubjectName() { Id = 9, SubName = "Behavior and Work Habit Evaluation" },
               new SubjectName() { Id = 10, SubName = "Attendance" });

        builder.Entity<Region>().HasData(
            new Region() { Id = 1, Name = "USA" },
            new Region() { Id = 2, Name = "Canada" },
            new Region() { Id = 3, Name = "UK" },
            new Region() { Id = 4, Name = "New Zealand" },
            new Region() { Id = 5, Name = "Australia" },
            new Region() { Id = 6, Name = "India" },
            new Region() { Id = 7, Name = "KSA" });

        builder.Entity<DayName>().HasData(
            new DayName() { Id = 1, Name = "Monday" },
            new DayName() { Id = 2, Name = "Tuesday" },
            new DayName() { Id = 3, Name = "Wednesday" },
            new DayName() { Id = 4, Name = "Thursday" },
            new DayName() { Id = 5, Name = "Friday" },
            new DayName() { Id = 6, Name = "Saturday" },
            new DayName() { Id = 7, Name = "Sunday" });

        builder.Entity<RatingItem>().HasData(
            new RatingItem() { Id = 1, Name = "Excellent", Value = 3, ShortName = "E", Description = "NA" },
            new RatingItem() { Id = 2, Name = "Satisfactory", Value = 2, ShortName = "S", Description = "NA" },
            new RatingItem() { Id = 3, Name = "Needs Improvement", Value = 1, ShortName = "NI", Description = "NA" });

        base.OnModelCreating(builder);
    }

    public DbSet<Assessment> Assessments { get; set; }
    public DbSet<AssessmentMonth> AssessmentsMonth { get; set; }
    public DbSet<Coordinator> Coordinators { get; set; }
    public DbSet<DayName> WeekDays { get; set; }
    public DbSet<Designation> Designations { get; set; }
    public DbSet<ELevel> Classes { get; set; }
    public DbSet<EvaluationTweak> Tweaks { get; set; }
    public DbSet<Manager> Managers { get; set; }
    public DbSet<Parent> Parents { get; set; }
    public DbSet<RatingItem> RatingItems { get; set; }
    public DbSet<Region> Regions { get; set; }
    public DbSet<ReportHead> RptHeads { get; set; }
    public DbSet<ReportItem> RptDetails { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<SubjectAllocation> Scheduling { get; set; }
    public DbSet<SubjectEvaluation> Evaluations { get; set; }
    public DbSet<SubjectName> Subjects { get; set; }
    public DbSet<Teacher> Teachers { get; set; }


}
