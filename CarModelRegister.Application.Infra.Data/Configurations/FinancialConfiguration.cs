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
    public class FinancialConfiguration : IEntityTypeConfiguration<Financial>
    {
       
       public void Configure(EntityTypeBuilder<Financial> builder)
        {
            builder.ToTable(name: nameof(Financial));
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                .HasMaxLength(36)
                .ValueGeneratedNever()
                .IsRequired();

            builder.Property(x => x.Name).HasMaxLength(250).IsRequired();
            builder.Property(x => x.SecondName).IsRequired();
            builder.Property(x => x.Document).IsRequired();
            builder.Property(x => x.Email).IsRequired();
            builder.Property(x => x.Age).IsRequired();
            
        }
    }
}
