using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentCityPropertyConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // ***** City *****
            #region City

            // ***** 
            builder
           .Property(s => s.CityName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** City ***** \\
            #endregion
        }
    }
}