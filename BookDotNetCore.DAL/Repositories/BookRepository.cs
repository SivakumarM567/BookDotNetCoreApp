using BookDotNetCore.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using BookDotNetCore.DAL.Data;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
            if (book != null)
            {
                _dbContext.bookDetails.Remove(book);
                _dbContext.SaveChanges();
            }
            return "Deleted";
        }
        public List<BookDetails> GetAllBooks()
        {
            List<BookDetails> bookDetailsList = _dbContext.bookDetails.ToList();
            return bookDetailsList;
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
            _dbContext.Entry(bookDetails).State = EntityState.Modified;
            _dbContext.SaveChanges();
            return "Updated";
        }
    }
}