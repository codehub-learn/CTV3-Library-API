using CTV3_Day5.DTOs;
using CTV3_Day5.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CTV3_Day5.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private IBookService service;

        public BookController(IBookService service)
        {
            this.service = service;
        }

        [HttpGet]
        public async Task<ActionResult<List<BookDto>>> Get()
        {
            List<BookDto> dto = await service.GetAllBooks();
            if (dto is null) return NotFound("The book id is invalid or has been removed");
            return Ok(dto);
        }

        [HttpGet, Route("{id}")]
        public async Task<ActionResult<BookDto>> Get(int id)
        {
            var dto = await service.GetBook(id);
            if (dto is null) return NotFound("The book Id is invalid or the book has been removed");
            return Ok(dto);
        }

     }
}
