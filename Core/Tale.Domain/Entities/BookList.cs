using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tale.Domain.Entities
{
	public class BookList
	{
		public int Id { get; set; }

		public string UserId { get; set; } = null!;

		public string Name { get; set; } = null!;

		public bool IsDefault { get; set; }

		public DateTime CreatedAt { get; set; }

		public ICollection<BookListItem> bookListItems { get; set; }
	}
}
