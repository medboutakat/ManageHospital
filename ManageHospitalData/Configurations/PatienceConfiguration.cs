using ManageHospitalData.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ManageHospitalData.Configurations
{
    public class PatienceConfiguration : IEntityTypeConfiguration<Patience>
    {
        public void Configure(EntityTypeBuilder<Patience> builder)
        {
            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.FirstName).HasMaxLength(60);

            builder.Property(e => e.LastName).HasMaxLength(60); 
        }
    }
}