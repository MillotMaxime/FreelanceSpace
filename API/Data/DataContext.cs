using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<AppUser> Users { get; set; }
        public DbSet<Freelance> Freelance { get; set; }
        public DbSet<Business> Business { get; set; }
        public DbSet<Offre> Offre { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<SalaryPenalty> SalaryPenalty { get; set; }
        public DbSet<Terms> Terms { get; set; }
        public DbSet<TimeLimit> TimeLimit { get; set; }
        public DbSet<LanguageSpeak> LanguageSpeak { get; set; }
        public DbSet<ComputerLanguage> ComputerLanguage { get; set; }
        public DbSet<OffreLanguagesComputer> OffreLanguagesComputer { get; set; }
        public DbSet<OffreLanguagesSpeak> OffreLanguagesSpeak { get; set; }
        
    }
}