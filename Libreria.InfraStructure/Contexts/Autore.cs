using System;
using System.Collections.Generic;

#nullable disable

namespace Libreria.InfraStructure.Contexts
{
  public partial class Autore
  {
    public Autore()
    {
      AutoresHasLibros = new HashSet<AutoresHasLibro>();
    }

    public int IdAutores { get; set; }
    public string Nombre { get; set; }
    public string Apellidos { get; set; }
    public string NombreCompleto { get { return Nombre + " " + Apellidos; } }

    public virtual ICollection<AutoresHasLibro> AutoresHasLibros { get; set; }
  }
}
