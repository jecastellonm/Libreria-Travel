using Libreria.Domain.Models;
using Libreria.InfraStructure;
using Libreria.InfraStructure.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.Services.Contracts
{
  public interface IBookServices
  {
    Task<IList<Libro>> GetAll();
    Task<Book> GetBook(int bookId);
    Task<Libro> GetBookDataComponent(long? bookId);
  }
}
