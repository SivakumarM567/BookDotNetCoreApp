using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookDotNetCore.BAL.Services;
using BookDotNetCore.Entity;

namespace BookDotNetCore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookDetailsController : ControllerBase
    {
        private BookDetailsServices _bookDetailsServices;
        public BookDetailsController(BookDetailsServices bookDetailsServices)
        {
            _bookDetailsServices = bookDetailsServices;
        }
        [HttpPost]
        public IActionResult SaveBook(BookDetails bookDetails)
        {
            return Ok(_bookDetailsServices.SaveBook(bookDetails));
        }
        [HttpGet]
        public IActionResult GetBook(int bookId)
        {
            return Ok(_bookDetailsServices.GetBook(bookId));
        }
        [HttpDelete]
        public IActionResult DeleteBook(int bookId)
        {
            return Ok(_bookDetailsServices.DeleteBook(bookId));
        }
        [HttpPost]
        public IActionResult UpdateBook(BookDetails bookDetails)
        {
            return Ok(_bookDetailsServices.UpdateBook(bookDetails));
        }
        [HttpGet]
        public IActionResult GetAllBooks()
        {
            return Ok(_bookDetailsServices.GetAllBooks());
        }
    }
}
