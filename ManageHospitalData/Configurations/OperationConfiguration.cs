using ManageHospitalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders; 

namespace ManageHospitalData.Configurations
{
    public class OperationConfiguration : IEntityTypeConfiguration<Operation>
    {
        public void Configure(EntityTypeBuilder<Operation> builder)
        {

            //builder.HasKey(e => e.Id)
            //             .IsClustered(false);

            //builder.Property(e => e.Id)
            //    .HasColumnName("Id")
            //    .HasMaxLength(20)
            //    .ValueGeneratedNever();

            //builder.Property(e => e.RegionId).HasColumnName("RegionID");

            //builder.Property(e => e.TerritoryDescription)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //builder.HasOne(d => d.Region)
            //    .WithMany(p => p.Territories)
            //    .HasForeignKey(d => d.RegionId)
            //    .OnDelete(DeleteBehavior.ClientSetNull)
            //    .HasConstraintName("FK_Territories_Region");

             

            //builder.HasOne(d => d.Customer).WithMany(p => p.Orders).HasForeignKey(d => d.CustomerId)
            //.HasConstraintName("FK_Orders_Customers");

            //builder.HasOne(d => d.Employee).WithMany(p => p.Orders).HasForeignKey(d => d.CustomerId)
            //                .HasConstraintName("FK_Orders_Employees");
            
        }
    }
}
