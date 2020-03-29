using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Repository.Config
{
    public class AddressGeolocalization : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.HasKey(add => add.Id);
            builder.HasOne(add => add.GeolocalizationAddress).WithMany().HasForeignKey(add => add.IdGeolocalization);

            builder.Property(add => add.Road).IsRequired(true).HasMaxLength(80).HasColumnType("VARCHAR");
            builder.Property(add => add.Neighborhood).IsRequired(true).HasMaxLength(40).HasColumnType("VARCHAR");
            builder.Property(add => add.Number).IsRequired(true).HasMaxLength(11).HasColumnType("INTEGER");
            builder.Property(add => add.Complement).IsRequired(false).HasMaxLength(11).HasColumnType("INTEGER");
            builder.Property(add => add.City).IsRequired(true).HasMaxLength(60).HasColumnType("VARCHAR");
            builder.Property(add => add.Country).IsRequired(true).HasMaxLength(100).HasColumnType("VARCHAR");
            builder.Property(add => add.Cep).IsRequired(true).HasMaxLength(8).HasColumnType("INTEGER");
            builder.Property(add => add.Reference).IsRequired(false).HasMaxLength(60).HasColumnType("VARCHAR");
        }
    }
}