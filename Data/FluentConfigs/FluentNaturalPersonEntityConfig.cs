using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentNaturalPersonEntityConfig : IEntityTypeConfiguration<NaturalPerson>
    {
        public void Configure(EntityTypeBuilder<NaturalPerson> builder)
        {
            // ***** NaturalPerson *****
            #region NaturalPerson

            // ***** 
            builder
                .HasOne<Models.Installer>(s => s.Installer)
                .WithMany(g => g.NaturalPeople);
            // ***** 

            // ***** NaturalPerson ***** \\
            #endregion
        }
    }
}