using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

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
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentCityPropertyConfig());
            // *****
            // ***** City ***** \\
            #endregion

            // ***** State *****
            #region State
            // ***** 
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentStatePropertyConfig());
            // *****
            // ***** State ***** \\
            #endregion

            // ***** Country *****
            #region Country
            // ***** 
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentCountryPropertyConfig());
            // *****
            // ***** Country ***** \\
            #endregion

            // ***** Installers *****
            #region Installers
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentInstallerPropertyConfig());
            // *****
            // ***** Installers ***** \\
            #endregion

            // ***** LegalPerson  *****
            #region LegalPerson
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentLegalPersonPropertyConfig());
            // *****
            // ***** LegalPerson ***** \\
            #endregion

            // ***** ShokatHeater  *****
            #region ShokatHeater
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentShokatHeaterPropertyConfig());
            // *****
            // ***** ShokatHeater ***** \\
            #endregion

            // ***** NaturalPerson *****
            #region NaturalPerson
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentNaturalPersonPropertyConfig());
            // *****
            // ***** NaturalPerson  ***** \\
            #endregion

            // ***** ReplacementHeaters *****
            #region ReplacementHeaters
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentReplacementHeatePropertyConfig());
            // *****
            // ***** ReplacementHeaters ***** \\
            #endregion

            // Property Configuration \\
            #endregion

            // Entity Configuration
            #region Entity Configuration

            // ***** City *****
            #region City
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentCityEntityConfig());
            // *****
            // ***** City ***** \\
            #endregion

            // ***** State *****
            #region State
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentStateEntityConfig());
            // *****
            // ***** State ***** \\
            #endregion

            // ***** LegalPerson *****
            #region LegalPerson
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentLegalPersonEntityConfig());
            // *****
            // ***** LegalPerson ***** \\
            #endregion

            // ***** NaturalPerson *****
            #region NaturalPerson
            // *****
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentNaturalPersonEntityConfig());
            // *****
            // ***** NaturalPerson ***** \\
            #endregion

            // ***** ShokatHeater  *****
            #region ShokatHeater
            // *****
            // *****
            // ***** ShokatHeater  ***** \\
            #endregion

            // ***** ReplacementHeater  *****
            #region ReplacementHeater
            // ***** 
            modelBuilder.ApplyConfiguration(new FluentConfigs.FluentReplacementHeaterEntityConfig());
            // *****
            // ***** ReplacementHeater  ***** \\
            #endregion

            // Entity Configuration \\
            #endregion
        }
    }
}