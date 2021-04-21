using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentStateEntityConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            // ***** State *****
            #region State

            // ***** 
            builder
            .HasOne<Models.City>(s => s.City)
            .WithMany(g => g.States);
            // ***** 

            // ***** State ***** \\
            #endregion
        }
    }
}