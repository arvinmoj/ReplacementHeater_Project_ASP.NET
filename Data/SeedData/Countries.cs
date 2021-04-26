using Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SeedData
{
    public class Countries : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> builder)
        {
            // ***** Countries *****
            #region Countries

            // *****
            builder.HasData(new Country
            {
                IdCountry = Guid.Parse("00bc82fd-6896-4cf2-9180-53b1ed4b2c69"),
                CountryName = "ایران" ,
            });
            // ***** 

            // ***** City ***** \\
            #endregion
        }
    }
}