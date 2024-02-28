using CarModelRegister.Application.Domain.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarModelRegister.Application.Infra.Data.Configurations
{
    public class CarConfiguration : IEntityTypeConfiguration<Car>
    {
        public void Configure(EntityTypeBuilder<Car> builder)
        {
            builder.ToTable(name: nameof(Car));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasMaxLength(36)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Model).HasMaxLength(250).IsRequired();
            builder.Property(x => x.Color).IsRequired();
            builder.Property(x => x.Type).IsRequired();
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Description).IsRequired();



        }
    }
}
