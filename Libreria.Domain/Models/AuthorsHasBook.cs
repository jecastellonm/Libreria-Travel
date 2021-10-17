using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain.Models
{
  public class AuthorsHasBook
  {
    public int AuthorId { get; set; }
    public long BookIsbn { get; set; }

    public virtual Author Authors { get; set; }
    public virtual Book BooksIsbnNavigation { get; set; }
  }
}
