using BookDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using BookDotNetCore.DAL.Data;

namespace BookDotNetCore.DAL.Repositories
{
    public class BookRepository : IBookRepository
    {
        private BookDbContext _dbContext;
        public BookRepository(BookDbContext bookDbContext)
        {
            _dbContext = bookDbContext;
        }
        public string DeleteBook(int BookId)
        {
            BookDetails book = _dbContext.bookDetails.Find(BookId);
            _dbContext.bookDetails.Remove(book);
            _dbContext.SaveChanges();
            return "Deleted";
        }
        public List<BookDetails> GetALlBooks()
        {
            return new List<BookDetails>();
        }
        public BookDetails GetBook(int BookId)
        {
            BookDetails book = _dbContext.bookDetails.Find(BookId);
            return book;
        }
        public string SaveBook(BookDetails bookDetails)
        {
            _dbContext.bookDetails.Add(bookDetails);
            _dbContext.SaveChanges();
            return "Saved";
        }
        public string UpdateBook(BookDetails bookDetails)
        {
            return "Updated";
        }
    }
}