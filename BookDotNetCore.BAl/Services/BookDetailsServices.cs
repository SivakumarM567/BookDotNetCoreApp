using System;
using System.Collections.Generic;
using System.Text;
using BookDotNetCore.DAL.Repositories;
using BookDotNetCore.Entity;
namespace BookDotNetCore.BAL.Services
{ 
    public class BookDetailsServices
    {
        private IBookRepository _bookRepository;
        public BookDetailsServices(IBookRepository bookRepository)
        { 
            _bookRepository = bookRepository;
        }
        public string SaveBook(BookDetails bookDetails)
        {
            return _bookRepository.SaveBook(bookDetails);
        }
        public string DeleteBook(int BookId)
        {
            return _bookRepository.DeleteBook(BookId);
        }
        public BookDetails GetBook(int BookId)
        {
            return _bookRepository.GetBook(BookId);
        }
        public string UpdateBook(BookDetails bookDetails)
        {
            return _bookRepository.UpdateBook(bookDetails);
        }
        public List<BookDetails> GetAllBooks()
        {
            return _bookRepository.GetAllBooks();
        }
    }
}
