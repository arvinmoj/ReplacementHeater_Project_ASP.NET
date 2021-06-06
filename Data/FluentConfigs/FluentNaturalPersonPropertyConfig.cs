using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Models;

namespace Data.FluentConfigs
{
    public class FluentNaturalPersonPropertyConfig : IEntityTypeConfiguration<NaturalPerson>
    {
        public void Configure(EntityTypeBuilder<NaturalPerson> builder)
        {
            // ***** NaturalPerson *****
            #region NaturalPerson

            // *****
            builder
            .Property(s => s.UserNaturalPerson)
            .IsRequired();
            // *****

            // *****
            builder
           .Property(s => s.InstallerUserName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
            .Property(s => s.FullName)
            .IsRequired()
            .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.NationalCode)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
            .Property(s => s.EmailAddress)
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
           .Property(s => s.City)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.State)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.Address)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.InstallationLocation)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.GasometerType)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.GasometerNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.PersonNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.Attachment)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.PersonNumber)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // ***** NaturalPerson  ***** \\
            #endregion

        }
    }
}