using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentCountryPropertyConfig : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            // ***** Country *****
            #region Country

            // ***** 
            builder
           .Property(s => s.CountryName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** Country ***** \\
            #endregion
        }
    }
}