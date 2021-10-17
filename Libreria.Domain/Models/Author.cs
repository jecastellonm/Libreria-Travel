using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain.Models
{
  public class Author
  {
    public int IdAuthor { get; set; }
    public string Name { get; set; }
    public string LastName { get; set; }
    public string FullName { get { return Name + " " + LastName; } }
    public virtual ICollection<AuthorsHasBook> AuthorsHasBook { get; set; }
  }
}
