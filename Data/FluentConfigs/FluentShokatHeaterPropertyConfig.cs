using Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.FluentConfigs
{
    public class FluentShokatHeaterPropertyConfig : IEntityTypeConfiguration<ShokatHeater>
    {
        public void Configure(EntityTypeBuilder<ShokatHeater> builder)
        {
            // ***** ShokatHeaters *****
            #region ShokatHeaters
            // *****
            builder
           .Property(s => s.HeaterSerialNumber)
           .IsRequired();
            // *****

            // *****
            builder
           .Property(s => s.ProductionDate)
           .IsRequired();
            // *****

            // ***** ShokatHeaters ***** \\
            #endregion
        }
    }
}