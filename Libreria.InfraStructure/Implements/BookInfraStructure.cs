using Libreria.Domain.Models;
using Libreria.InfraStructure.Contexts;
using Libreria.InfraStructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria.InfraStructure.Implements
{
  public class BookInfraStructure : IBooksInfraStructure
  {
    private readonly LibreriaContext _context;
    private readonly ILogger<BookInfraStructure> _logger;

    public BookInfraStructure(LibreriaContext context, ILogger<BookInfraStructure> logger)
    {
      this._context = context;
      _logger = logger;
    }

    public Libro Libro { get; set; }
    public IList<Libro> Libros { get; set; }

    /// <summary>
    /// Metodo para capturar todos libros con su data relacionada
    /// </summary>
    /// <param name=""> </param>
    /// <returns name="Libros"> </returns>
    public async Task<IList<Libro>> GetAll()
    {
      try
      {
        Libros = await _context.Libros
          .Include(l => l.Editoriales).ToListAsync();
        return Libros;
      }
      catch (Exception ex)
      {
        _logger.LogError($"Error en {nameof(GetAll)}: " + ex.Message);
      }
      return null;
      //throw new NotImplementedException();
    }


    /// <summary>
    /// Metodo para capturar un libro con su data relacionada por su ISBN
    /// </summary>
    /// <param name="bookIsbn"> </param>
    /// <returns name="Libro"> </returns>
    public async Task<Libro> GetBookDataComponent(long? bookIsbn)
    {
      try
      {
        if (bookIsbn == null)
        {
          return null;
        }
        Libro = await _context.Libros
            .Where(l => l.Isbn == bookIsbn)
            .Include(l => l.AutoresHasLibros)
              .ThenInclude(l => l.Autores)
            .Include(l => l.Editoriales).FirstOrDefaultAsync(m => m.Isbn == bookIsbn);
        if (Libro == null)
        {
          return null;
        }
        return Libro;
      }
      catch (Exception ex)
      {
        _logger.LogError($"Error en {nameof(GetBook)}: " + ex.Message);
      }
      return null;
      //throw new NotImplementedException();
    }

    /// <summary>
    /// Metodo para capturar un libro por su ISBN
    /// </summary>
    /// <param name="bookId"> </param>
    /// <returns name="Book"> </returns>
    public async Task<Book> GetBook(int bookId)
    {
      try
      {
        var book = await _context.FindAsync<Book>(Convert.ToInt32(bookId));
        if (book == null)
          return null;
        return book;
      }
      catch (Exception ex)
      {
        _logger.LogError($"Error en {nameof(GetBook)}: " + ex.Message);
      }
      return null;
      //throw new NotImplementedException();
    }


  }
}
