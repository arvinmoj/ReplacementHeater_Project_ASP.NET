using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentLegalPersonEntityConfig : IEntityTypeConfiguration<LegalPerson>
    {
        public void Configure(EntityTypeBuilder<LegalPerson> builder)
        {
            // ***** LegalPerson *****
            #region LegalPerson

            // *****
            builder
            .HasOne<Models.Installer>(s => s.Installer)
            .WithMany(g => g.LegalPeople);
            // *****

            // ***** LegalPerson ***** \\
            #endregion
        }
    }
}