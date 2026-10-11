using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Tale.Domain.Entities;

namespace Tale.Persistence.Configurations
{
	public  class BookListItemConfiguration : IEntityTypeConfiguration<BookListItem>
	{
		public void Configure(EntityTypeBuilder<BookListItem> builder)
		{
			builder.HasKey(x => x.Id);
			builder.HasIndex(x => new {x.BookListId, x.BookId}).IsUnique();
			builder.HasOne(x => x.Book).WithMany().HasForeignKey(x => x.BookId).OnDelete(DeleteBehavior.Restrict);

		}
	}
}
