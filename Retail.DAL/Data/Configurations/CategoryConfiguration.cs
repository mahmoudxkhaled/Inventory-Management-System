using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Retail.DAL;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        // Primary Key
        builder.HasKey(c => c.ID);

        // Properties
        builder.Property(c => c.NAME)
            .IsRequired()
            .HasMaxLength(255);

        builder.Property(c => c.DESCRIPTION)
            .HasMaxLength(1000);

        // Navigation Property
        builder.HasMany(c => c.PRODUCTS)
            .WithOne(p => p.CATEGORY)
            .HasForeignKey(p => p.CATEGORY_ID)
        // Use the appropriate delete behavior instead of the defult one  "ON DELETE CASCADE"
            .OnDelete(DeleteBehavior.Restrict);

        // Since name searches are the most popular, we create "non-clustered" indexes here to be faster in searching
        builder.HasIndex(c => c.NAME).IsUnique();

    }

}
