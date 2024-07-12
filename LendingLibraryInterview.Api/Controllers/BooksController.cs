using LendingLibraryInterview.Api.Services;
using LendingLibraryInterview.Data.Entities;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibraryInterview.Core.src.Controllers
{
    public class BooksController
    {
        private readonly IBookService _bookService;

        public BooksController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public async Task<ActionResult<List<Book>>> SearchBooksByAuthorAsync(string author)
        {
            var books = await _bookService.SearchBooksByAuthorAsync(author);
            if (books == null)
            {
                //return Results.NotFound();
            }
            return books;
        }
    }
}
