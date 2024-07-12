using Xunit;
using LendingLibraryInterview.Data.Entities;
using LendingLibraryInterview.Core.src.Controllers;
using LendingLibraryInterview.Api.Services;
using Moq;
using Microsoft.AspNetCore.Mvc;
using NuGet.Frameworks;

namespace LendingLibraryInterview.Tests.Controllers
{
    public class BookControllerTests
    {
        private readonly BooksController _controller;
        private readonly Mock<IBookService> _mockBookService;

        public BookControllerTests()
        {

        }

        [Fact]
        public async void SearchBooksByAuthor_ReturnsOk_WhenBookIsFound()
        {
            // Arrange
            var author = "Test Author";
            _mockBookService.Setup(service => service.SearchBooksByAuthorAsync(author)).ReturnsAsync((List<Book>)null);

            // Act
            var result = await _controller.SearchBooksByAuthorAsync(author);

            // Assert
            Assert.IsType<OkResult>(result);
        }

    }
}   