using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Application.Interfaces.Repositories;
using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CharlieBackend.Infrastructure.Repositories.Library
{
    public class BookDetailRepository : IBookDetailRepository
    {
        private readonly IRepositoryAsync<BookDetail> _repository;

        public BookDetailRepository(IRepositoryAsync<BookDetail> repository)
        {
            _repository = repository;
        }

        public IQueryable<BookDetail> bookDetail => _repository.Entities;

        public async Task DeleteAsync(BookDetail bookDetail)
        {
            await _repository.DeleteAsync(bookDetail);
        }

        public async Task<BookDetail> GetByIdAsync(int bookDetailId)
        {
            return await _repository.Entities.Where(p => p.Id == bookDetailId).FirstOrDefaultAsync();
        }

        public async Task<List<BookDetail>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(BookDetail bookDetail)
        {
            await _repository.AddAsync(bookDetail);
            return bookDetail.Id;
        }

        public async Task UpdateAsync(BookDetail bookDetail)
        {
            await _repository.UpdateAsync(bookDetail);
        }
    }
}
