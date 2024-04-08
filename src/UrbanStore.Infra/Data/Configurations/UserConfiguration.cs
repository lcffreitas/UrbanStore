using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UrbanStore.Domain.Model;

namespace UrbanStore.Infra.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(30);
            builder.Property(x => x.Email)
                .IsRequired();
            builder.Property(x => x.Password)
                .IsRequired();
            builder.Property(x => x.PhoneNumber)
                .IsRequired();
            builder.Property(x => x.BirthDate)
                .IsRequired();
            builder.Property(x => x.Cpf)
                .IsRequired()
                .HasMaxLength(11);
        }
    }
}