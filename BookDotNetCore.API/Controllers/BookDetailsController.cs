using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookDotNetCore.BAl.Services;
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
        public IActionResult GetBook(int BookId)
        {
            return Ok(_bookDetailsServices.GetBook(BookId));
        }
        [HttpDelete]
        public IActionResult DeleteBook(int BookId)
        {
            return Ok(_bookDetailsServices.DeleteBook(BookId));
        }
    }
}
