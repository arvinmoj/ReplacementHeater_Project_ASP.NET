using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.FluentConfigs
{
    public class FluentReplacementHeatePropertyConfig : IEntityTypeConfiguration<ReplacementHeater>
    {
        public void Configure(EntityTypeBuilder<ReplacementHeater> builder)
        {
            // ***** ReplacementHeaters *****
            #region ReplacementHeaters


            // *****
            builder
            .Property(s => s.UserLegalPerson)
            .HasColumnType("bit");
            // *****

            // *****
            builder
            .Property(s => s.UserNaturalPerson)
            .HasColumnType("bit");
            // *****

            // *****
            builder
           .Property(s => s.HeaterInstalledType)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.NameCEO)
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.FullName)
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.HeaterScrapType)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.Model)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.Capacity)
           .IsRequired();
            // *****

            // *****
            builder
           .Property(s => s.HeaterScrapSerialNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.HeaterInstalledSerialNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.InstallationDate)
           .IsRequired();
            // *****

            // *****
            builder
           .Property(s => s.InstallationTime)
           .IsRequired();
            // *****

            // ***** ReplacementHeaters ***** \\
            #endregion

        }
    }
}