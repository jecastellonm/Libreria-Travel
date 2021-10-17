using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Domain.Models
{
  public class Editorial
  {
    public int IdEditorial { get; set; }
    public string Name { get; set; }
    public string HeadQuarters { get; set; }

    public virtual ICollection<Book> Books { get; set; }
  }
}
