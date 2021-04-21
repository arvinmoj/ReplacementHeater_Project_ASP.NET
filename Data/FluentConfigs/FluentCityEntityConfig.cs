using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentCityEntityConfig : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // ***** City *****
            #region City
            
            // *****
            builder
              .HasOne<Models.Country>(s => s.Country)
              .WithMany(g => g.Cities);
            // ***** 

            // ***** City ***** \\
            #endregion
        }
    }
}