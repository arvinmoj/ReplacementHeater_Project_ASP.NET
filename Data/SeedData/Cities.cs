using Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SeedData
{
    public class Cities : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // ***** City *****
            #region City

            // ***** 
            builder.HasData(new City
            {
                IdCity = Guid.Parse("16bcbb89-9dcf-4742-82eb-474013215322"),
                CityName = "تهران",
            });
            // ***** 

            // ***** 
            builder.HasData(new City
            {
                IdCity = Guid.Parse("a1d501b1-dbb0-478e-8b54-5aea1497bbfb"),
                CityName = "اصفهان",
            });
            // ***** 

            // ***** 
            builder.HasData(new City
            {
                IdCity = Guid.Parse("5b59b32a-ce68-406a-9eef-1390de1fff51"),
                CityName = "كرمان",
            });
            // ***** 

            // ***** City ***** \\
            #endregion
        }
    }
}