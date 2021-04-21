using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentInstallerPropertyConfig : IEntityTypeConfiguration<Installer>
    {
        public void Configure(EntityTypeBuilder<Installer> builder)
        {
            // ***** Installers *****
            #region Installers

            // *****
            builder
            .Property(s => s.FullName)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            builder
            .Property(s => s.InstallerUserName)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            builder
            .Property(s => s.UserNumber)
            .IsRequired();
            // *****

            // *****
            builder
            .Property(s => s.NationalCode)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            builder
             .Property(s => s.PhoneNumber)
             .IsRequired()
             .HasMaxLength(128);
            // *****

            // *****
            builder
             .Property(s => s.MobileNumber)
             .IsRequired()
             .HasMaxLength(128);
            // *****

            // *****
            builder
            .Property(s => s.Address)
            .IsRequired()
            .HasMaxLength(128);

            // ***** Installers ***** \\
            #endregion
        }
    }
}