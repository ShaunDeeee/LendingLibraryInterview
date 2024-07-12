using LendingLibraryInterview.Api.Services;
using LendingLibraryInterview.Data;
using LendingLibraryInterview.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LendingLibraryInterview.Core.src.Services
{
    public class BookService : IBookService
    {
        //context
        private readonly SQLiteDbContext _context;
        public BookService(SQLiteDbContext context) 
        {
            _context = context;
        }

        public Task AddBookAsync(string title, string author)
        {
            throw new NotImplementedException();
        }

        public Task BorrowBookAsync(int bookId)
        {
            throw new NotImplementedException();
        }

        public Task ReturnBookAsync(int bookId)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Book>> SearchBooksByAuthorAsync(string author)
        {
            return await _context.Books
                .Where(x => x.Author.Contains(author))
                .ToListAsync();
        }

        public Task<List<Book>> SearchBooksByIsbnAsync(string author)
        {
            throw new NotImplementedException();
        }
    }
}
