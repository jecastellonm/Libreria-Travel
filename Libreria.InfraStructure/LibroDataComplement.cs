using Libreria.InfraStructure.Contexts;
using System;
using System.Collections.Generic;

namespace Libreria.InfraStructure
{
  public class LibroDataComplement
  {
    public Libro Libros { get; set; }
    public IEnumerable<Autore> Autoress { get; set; }
    public Editoriale Editoriales { get; set; }
  }
}
