using Libreria.Domain.Models;
using Libreria.InfraStructure;
using Libreria.InfraStructure.Contexts;
using Libreria.InfraStructure.Interfaces;
using Libreria.Services.Contracts;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Libreria.Services
{
  public class BookSevices : IBookServices
  {
    public BookSevices(IBooksInfraStructure booksInfrastructure, ILogger<BookSevices> logger)
    {
      _booksInfrastructure = booksInfrastructure;
      _logger = logger;
    }

    private readonly IBooksInfraStructure _booksInfrastructure;
    private readonly ILogger<BookSevices> _logger;

    /// <summary>
    /// Metodo para capturar un libro con su data relacionada por su ISBN
    /// </summary>
    /// <param name="bookIsbn"> </param>
    /// <returns name="libro"> </returns>
    public async Task<Libro> GetBookDataComponent(long? bookIsbn)
    {
      try
      {
        var libro = await _booksInfrastructure.GetBookDataComponent(bookIsbn);
        if (libro == null)
        {
          return null;
        }
        return libro;
      }
      catch (Exception ex)
      {
        _logger.LogError($"Error en {nameof(GetBook)}: " + ex.Message);
        return null;
      }
      //throw new NotImplementedException();
    }

    /// <summary>
    /// Metodo para capturar todos los libros con su data relacionada
    /// </summary>
    /// <param name=""> </param>
    /// <returns name="libros"> </returns>
    public async Task<IList<Libro>> GetAll()
    {
      try
      {
        var libros = await _booksInfrastructure.GetAll();
        if (libros == null)
        {
          return null;
        }
        return libros;
      }
      catch (Exception exception)
      {
        return null;
      }
      //throw new NotImplementedException();
    }

    /// <summary>
    /// Metodo para capturar un libro por su ISBN
    /// </summary>
    /// <param name=""> </param>
    /// <returns name="libros"> </returns>
    public async Task<Book> GetBook(int bookId)
    {
      try
      {
        var result = await _booksInfrastructure.GetBook(bookId);
        if (result == null)
        {
          return null;
        }
        return result;
      }
      catch (Exception exception)
      {
        return null;
      }
      //throw new NotImplementedException();
    }

  }
}
