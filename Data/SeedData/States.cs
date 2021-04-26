using Models;
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.SeedData
{
    public class States : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            // ***** State *****
            #region State

            // ***** 
            builder.HasData(new State
            {
                IdState = Guid.NewGuid(),
                StateName = "بم",
            });
            // ***** 

            // ***** 
            builder.HasData(new State
            {
                IdState = Guid.NewGuid(),
                StateName = "ايمانشهر",
            });
            // ***** 

            // ***** 
            builder.HasData(new State
            {
                IdState = Guid.NewGuid(),
                StateName = "البرز",
            });
            // ***** 

            // ***** State ***** \\
            #endregion
        }
    }
}