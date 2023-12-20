using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Retail.DAL;
public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {

        // Primary Key
        builder.HasKey(p => p.ID);


        // Properties
        builder.Property(p => p.NAME)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(p => p.DESCRIPTION)
            .HasMaxLength(1000);

        builder.Property(p => p.PRICE)
            .HasColumnType("decimal(18,2)")
            .IsRequired();

        builder.Property(p => p.QTY)
            .IsRequired();

        builder.Property(p => p.PIC)
           .HasColumnType("NVARCHAR(MAX)");


        // Foreign Key Relationship
        builder.HasOne(p => p.CATEGORY)
            .WithMany(c => c.PRODUCTS)
            .HasForeignKey(p => p.CATEGORY_ID)
        // Use the appropriate delete behavior instead of the defult one  "ON DELETE CASCADE"
            .OnDelete(DeleteBehavior.Restrict);

        // Since name searches are the most popular, we create "non-clustered" indexes here to be faster in searching
        builder.HasIndex(p => p.NAME).IsUnique();
    }


}

