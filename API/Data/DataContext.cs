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
        public DbSet<Offer> Offre { get; set; }
        public DbSet<Salary> Salary { get; set; }
        public DbSet<Penalty> Penalty { get; set; }
        public DbSet<Terms> Terms { get; set; }
        public DbSet<TauxHorraire> TimeLimit { get; set; }
        public DbSet<Language> Language { get; set; }
        public DbSet<ProgramingLanguage> ProgramingLanguage { get; set; }
        public DbSet<OfferProgramingLanguages> OffreLanguagesComputer { get; set; }
        public DbSet<OfferLanguages> OffreLanguagesSpeak { get; set; }
        
    }
}