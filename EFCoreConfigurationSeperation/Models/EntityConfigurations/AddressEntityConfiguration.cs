using EFCoreConfigurationSeperation.Models.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EFCoreConfigurationSeperation.Models.EntityConfigurations
{
    public class AddressEntityConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);
            builder.Property(x => x.District).IsRequired().HasMaxLength(255);
            builder.HasMany(x => x.User).WithMany(x => x.Addresses);
        }
    }
}
