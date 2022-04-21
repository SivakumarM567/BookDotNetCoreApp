using System;
using System.Collections.Generic;
using System.Text;
using BookDotNetCore.Entity;

namespace BookDotNetCore.DAL.Repositories
{
    public interface IBookRepository
    {
        string SaveBook(BookDetails bookDetails);
        string UpdateBook(BookDetails bookDetails);
        string DeleteBook(int BookId);
        BookDetails GetBook(int BookId);
        List<BookDetails> GetALlBooks();
    }
}
