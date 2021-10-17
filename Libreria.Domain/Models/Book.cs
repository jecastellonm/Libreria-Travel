using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain.Models
{
  public class Book
  {
    public int IdBook { get; set; }
    public long Isbn { get; set; }
    public int EditorialId { get; set; }
    public string Title { get; set; }
    public string Synopsis { get; set; }
    public string NPages { get; set; }

    public virtual Editorial Editorials { get; set; }
    public virtual ICollection<AuthorsHasBook> AuthorsHasBooks { get; set; }
  }
}
