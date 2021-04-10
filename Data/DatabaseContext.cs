using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Data
{
    public class DatabaseContext : IdentityDbContext
    {
        public DatabaseContext() : base()
        {
        }

        //public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        //{
        //    Database.EnsureCreated();
        //}

        /// <summary>
        /// Using Migrations!
        /// </summary>
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {
        }

        // DbSet
        #region DbSet

        // ***** City *****
        public DbSet<Models.City> Cities { get; set; }
        // *****

        // ***** State *****
        public DbSet<Models.State> States { get; set; }
        // *****

        // ***** Country *****
        public DbSet<Models.Country> Countries { get; set; }
        // *****

        // ***** Installers *****
        public DbSet<Models.Installer> Installers { get; set; }
        // *****

        // ***** LegalPeople *****
        public DbSet<Models.LegalPerson> LegalPeople { get; set; }
        // *****

        // ***** ShokatHeaters *****
        public DbSet<Models.ShokatHeater> ShokatHeaters { get; set; }
        // *****

        // ***** NaturalPeople *****
        public DbSet<Models.NaturalPerson> NaturalPeople { get; set; }
        // *****

        // ***** ReplacementHeaters *****
        public DbSet<Models.ReplacementHeater> ReplacementHeaters { get; set; }
        // *****
        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Property Configuration
            #region Property Configuration

            // ***** City *****
            #region City

            // ***** 
            modelBuilder.Entity<Models.City>()
           .Property(s => s.CityName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** City ***** \\
            #endregion

            // ***** State *****
            #region State

            // ***** 
            modelBuilder.Entity<Models.State>()
           .Property(s => s.StateName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** State ***** \\
            #endregion

            // ***** Country *****
            #region Country

            // ***** 
            modelBuilder.Entity<Models.Country>()
           .Property(s => s.CountryName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** Country ***** \\
            #endregion

            // ***** Installers *****
            #region Installers

            // *****
            modelBuilder.Entity<Models.Installer>()
           .Property(s => s.FullName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.Installer>()
           .Property(s => s.InstallerUserName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.Installer>()
           .Property(s => s.UserNumber)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.Installer>()
           .Property(s => s.NationalCode)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.Installer>()
            .Property(s => s.PhoneNumber)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.Installer>()
            .Property(s => s.MobileNumber)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.Installer>()
           .Property(s => s.Address)
           .IsRequired()
           .HasMaxLength(128);

            // ***** Installers ***** \\
            #endregion

            // ***** LegalPerson  *****
            #region LegalPerson

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.InstallerUserName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.CompanyName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.NameCEO)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
            .Property(s => s.EmailAddress)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.PhoneNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.City)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.State)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.Region)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.Address)
           .IsRequired()
           .HasMaxLength(256);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.NationalCode)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.RegistrationNumber)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.EconomicCode)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.RecipientName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.InstallationLocation)
           .IsRequired()
           .HasMaxLength(128);

            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.GasometerType)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.GasometerNumber)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.PersonNumber)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.LegalPerson>()
           .Property(s => s.Attachment)
           .IsRequired();
            // *****

            // ***** LegalPerson  ***** \\
            #endregion

            // ***** ShokatHeaters *****
            #region ShokatHeaters
            // *****
            modelBuilder.Entity<Models.ShokatHeater>()
           .Property(s => s.HeaterSerialNumber)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.ShokatHeater>()
           .Property(s => s.ProductionDate)
           .IsRequired();
            // *****

            // ***** ShokatHeaters ***** \\
            #endregion

            // ***** NaturalPerson *****
            #region NaturalPerson

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.InstallerUserName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
            .Property(s => s.FullName)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.NationalCode)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
            .Property(s => s.EmailAddress)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.PhoneNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.MobileNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.City)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.State)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.Region)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.Address)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.InstallationLocation)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.GasometerType)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.GasometerNumber)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.PersonNumber)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.Attachment)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.NaturalPerson>()
           .Property(s => s.PersonNumber)
           .IsRequired();
            // *****

            // ***** NaturalPerson  ***** \\
            #endregion

            // ***** ReplacementHeaters *****
            #region ReplacementHeaters

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.HeaterInstalledType)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.NameCEO)
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.FullName)
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.HeaterScrapType)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.Model)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.Capacity)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.HeaterScrapSerialNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.HeaterInstalledSerialNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.InstallationDate)
           .IsRequired();
            // *****

            // *****
            modelBuilder.Entity<Models.ReplacementHeater>()
           .Property(s => s.InstallationTime)
           .IsRequired();
            // *****

            // ***** ReplacementHeaters ***** \\
            #endregion

            // Property Configuration \\
            #endregion

            // Entity Configuration
            #region Entity Configuration

            // ***** City *****
            #region City
            modelBuilder.Entity<Models.City>()
              .HasOne<Models.Country>(s => s.Country)
              .WithMany(g => g.Cities);
            // ***** City ***** \\
            #endregion

            // ***** State *****
            #region State
            modelBuilder.Entity<Models.State>()
              .HasOne<Models.City>(s => s.City)
              .WithMany(g => g.States);
            // ***** State ***** \\
            #endregion

            // ***** LegalPerson *****
            #region LegalPerson
            modelBuilder.Entity<Models.LegalPerson>()
                .HasOne<Models.Installer>(s => s.Installer)
                .WithMany(g => g.LegalPeople);

            // ***** LegalPerson ***** \\
            #endregion

            // ***** NaturalPerson *****
            #region NaturalPerson
            modelBuilder.Entity<Models.NaturalPerson>()
                .HasOne<Models.Installer>(s => s.Installer)
                .WithMany(g => g.NaturalPeople);

            // ***** NaturalPerson ***** \\
            #endregion
            // ***** ShokatHeater  *****
            #region ShokatHeater
            #endregion

            // ***** ReplacementHeater  *****

            // ***** LegalPerson *****
            #region ReplacementHeater
            modelBuilder.Entity<Models.ReplacementHeater>()
            .HasOne<Models.LegalPerson>(s => s.LegalPerson)
            .WithMany(g => g.ReplacementHeaters);
            // *****

            // ***** NaturalPerson *****
            modelBuilder.Entity<Models.ReplacementHeater>()
            .HasOne<Models.NaturalPerson>(s => s.NaturalPerson)
            .WithMany(g => g.ReplacementHeaters);
            // *****

            // ***** ReplacementHeater  ***** \\
            #endregion

            // Entity Configuration \\
            #endregion
        }
    }
}