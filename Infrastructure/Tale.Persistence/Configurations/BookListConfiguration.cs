using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tale.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tale.Persistence.Identity;

namespace Tale.Persistence.Configurations
{
	public class BookListConfiguration : IEntityTypeConfiguration<BookList>
	{
		public void Configure(EntityTypeBuilder<BookList>builder)
		{
			builder.HasKey(x => x.Id);
			builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
			builder.Property(x => x.UserId).IsRequired();
			builder.HasIndex(x => new { x.Id, x.Name }).IsUnique();

			// Domain Identity'yi bilmesin diye ilişkiyi burada kuruyoruz
			builder.HasOne<AppUser>().WithMany().HasForeignKey(x => x.UserId).OnDelete(DeleteBehavior.Cascade);

			builder.HasMany(x => x.bookListItems).WithOne(i => i.BookList).HasForeignKey(i=> i.BookListId).OnDelete(DeleteBehavior.Cascade);
		}
	}
}
