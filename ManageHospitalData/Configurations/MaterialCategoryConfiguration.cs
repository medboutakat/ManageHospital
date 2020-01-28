using ManageHospitalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace ManageHospitalData .Configurations
{
    public class MaterialCategoryConfiguration : IEntityTypeConfiguration<MaterialCategory>
    {
        public void Configure(EntityTypeBuilder<MaterialCategory> builder)
        {

            builder.Property(e => e.Id).HasColumnName("Id");

            builder.Property(e => e.Name)
                .IsRequired()
                .HasMaxLength(15);

            //builder.Property(e => e.Description).HasColumnType("ntext");

            //builder.Property(e => e.Picture).HasColumnType("image");
        }
    }
}
