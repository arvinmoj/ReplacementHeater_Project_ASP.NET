using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentLegalPersonPropertyConfig : IEntityTypeConfiguration<LegalPerson>
    {
        public void Configure(EntityTypeBuilder<LegalPerson> builder)
        {
            // ***** LegalPerson  *****
            #region LegalPerson

            // *****
            builder
           .Property(s => s.InstallerUserName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.CompanyName)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.NameCEO)
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
           .Property(s => s.Region)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.Address)
           .IsRequired()
           .HasMaxLength(256);
            // *****

            // *****
            builder
           .Property(s => s.NationalCode)
           .IsRequired()
           .HasMaxLength(128);
            // *****

            // *****
            builder
           .Property(s => s.RegistrationNumber)
           .IsRequired();
            // *****

            // *****
            builder
           .Property(s => s.EconomicCode)
           .IsRequired();
            // *****

            // *****
            builder
           .Property(s => s.RecipientName)
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
           .IsRequired();
            // *****

            // *****
            builder
           .Property(s => s.PersonNumber)
           .IsRequired();
            // *****

            // *****
        //     builder
        //    .Property(s => s.Attachment)
        //    .IsRequired();
            // *****

            // ***** LegalPerson  ***** \\
            #endregion

        }
    }
}