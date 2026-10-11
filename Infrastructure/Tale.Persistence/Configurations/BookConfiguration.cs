using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tale.Domain.Entities;

namespace Tale.Persistence.Confugirations
{
	public class BookConfiguration : IEntityTypeConfiguration<Book>
	{
		public void Configure(EntityTypeBuilder<Book> builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.ExternalId).IsRequired().HasMaxLength(100);
			builder.HasIndex(x => x.ExternalId).IsUnique();
			builder.Property(x => x.Title).IsRequired().HasMaxLength(500);
			builder.Property(x => x.Authors).HasMaxLength(100);
			builder.Property(x => x.CoverUrl).HasMaxLength(1000);
			builder.Property(x => x.Category).HasMaxLength(100);
			builder.Property(x => x.PublishedDate).HasMaxLength(20);
		}
	}
}
