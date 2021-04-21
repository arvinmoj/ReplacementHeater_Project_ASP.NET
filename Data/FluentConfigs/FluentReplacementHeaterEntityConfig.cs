using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentReplacementHeaterEntityConfig : IEntityTypeConfiguration<ReplacementHeater>
    {
        public void Configure(EntityTypeBuilder<ReplacementHeater> builder)
        {
            // ***** ReplacementHeater  *****
            #region ReplacementHeater

            // ***** LegalPerson *****
            builder
            .HasOne<Models.LegalPerson>(s => s.LegalPerson)
            .WithMany(g => g.ReplacementHeaters);
            // *****

            // ***** NaturalPerson *****
            builder
            .HasOne<Models.NaturalPerson>(s => s.NaturalPerson)
            .WithMany(g => g.ReplacementHeaters);
            // *****

            // ***** ReplacementHeater  ***** \\
            #endregion
        }
    }
}