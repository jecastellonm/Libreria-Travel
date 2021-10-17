using System;
using System.Collections.Generic;

#nullable disable

namespace Libreria.InfraStructure.Contexts
{
    public partial class AutoresHasLibro
    {
        public int AutoresId { get; set; }
        public long LibrosIsbn { get; set; }

        public virtual Autore Autores { get; set; }
        public virtual Libro LibrosIsbnNavigation { get; set; }
    }
}
