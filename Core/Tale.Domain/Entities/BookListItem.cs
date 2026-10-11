using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tale.Domain.Entities
{
	public class BookListItem
	{
		public int Id { get; set; }

		public int BookListId { get; set; }  // ---foreign key

		public BookList BookList { get; set; } = null!; // ----navigation property

		public int BookId { get; set; }  //----foreign key
		public Book Book { get; set; } = null!; //----navigation property


		public DateTime AddedAt { get; set; } = DateTime.UtcNow;
	}
}
