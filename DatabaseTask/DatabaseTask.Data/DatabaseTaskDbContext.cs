﻿using DatabaseTask.Core.Domain;
using Microsoft.EntityFrameworkCore;


namespace DatabaseTask.Data
{
    public class DatabaseTaskDbContext : DbContext
    {
        public DatabaseTaskDbContext(DbContextOptions<DatabaseTaskDbContext> options)
            : base(options) { }

        // näide, kuidas teha, kui lisate domaini alla ühe objekti
        // migratsioonid peavad tulema siia libary-sse e TARge20.Data alla.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<Absence> Absences { get; set; }
        public DbSet<Child> Childs { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Hint> Hints { get; set; }
        public DbSet<Profession> Professions { get; set; }
        public DbSet<WorkingHistory> WorkingHistories { get; set; }
    }
}
