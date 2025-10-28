using CharlieBackend.Application.Interfaces.Repositories;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CharlieBackend.Infrastructure.Repositories.Library.BookRepository;

namespace CharlieBackend.Infrastructure.Repositories.Library
{
    public class BookRepository : IBookRepository

    {
        private readonly IRepositoryAsync<Book> _repository;

        public BookRepository(IRepositoryAsync<Book> repository)
        {
            _repository = repository;
        }

        public IQueryable<Book> Book => _repository.Entities;

        public async Task DeleteAsync(Book book)
        {
            await _repository.DeleteAsync(book);
        }

        public async Task<Book> GetByIdAsync(int bookId)
        {
            return await _repository.Entities.Where(p => p.Id == bookId).FirstOrDefaultAsync();
        }

        public async Task<List<Book>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Book book)
        {
            await _repository.AddAsync(book);
            return book.Id;
        }

        public async Task UpdateAsync(Book book)
        {
            await _repository.UpdateAsync(book);
        }
    }
}
