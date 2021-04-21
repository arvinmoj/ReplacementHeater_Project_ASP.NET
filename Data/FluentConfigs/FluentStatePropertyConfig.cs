using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentStatePropertyConfig : IEntityTypeConfiguration<State>
    {
        public void Configure(EntityTypeBuilder<State> builder)
        {
            // ***** State *****
            #region State

            // ***** 
            builder
           .Property(s => s.StateName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** State ***** \\
            #endregion
        }
    }
}