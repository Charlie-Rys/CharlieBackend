using CharlieBackend.Application.Interfaces.Repositories;
using CharlieBackend.Application.Interfaces.Repositories.Library;
using CharlieBackend.Domain.Entities.Library;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Infrastructure.Repositories.Library
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly IRepositoryAsync<Author> _repository;

        public AuthorRepository(IRepositoryAsync<Author> repository)
        {
            _repository = repository;
        }

        public IQueryable<Author> author => _repository.Entities;

        public async Task DeleteAsync(Author author)
        {
            await _repository.DeleteAsync(author);
        }

        public async Task<Author> GetByIdAsync(int authorId)
        {
            return await _repository.Entities.Where(p => p.Id == authorId).FirstOrDefaultAsync();
        }

        public async Task<List<Author>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(Author author)
        {
            await _repository.AddAsync(author);
            return author.Id;
        }

        public async Task UpdateAsync(Author author)
        {
            await _repository.UpdateAsync(author);
        }
    }
}
