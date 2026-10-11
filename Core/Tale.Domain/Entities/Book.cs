using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tale.Domain.Entities
{
	public class Book
	{
		public int Id { get; set; }

		public string ExternalId { get; set; } = null!;

		public string Title { get; set; } = null!;

		public string Authors { get; set; } = null!;

		public string? Description { get; set; }

		public string? CoverUrl { get; set; }

		public string? Category { get; set; }

		public int? PageCount { get; set; }

		public string PublishedDate { get; set; } = null!;

		public ICollection<BookListItem> bookListItems { get; set; }
	}
}
