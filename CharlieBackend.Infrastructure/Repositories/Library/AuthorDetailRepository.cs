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

    public class AuthorDetailRepository : IAuthorDetailRepository
    {
        private readonly IRepositoryAsync<AuthorDetail> _repository;

        public AuthorDetailRepository(IRepositoryAsync<AuthorDetail> repository)
        {
            _repository = repository;
        }

        public IQueryable<AuthorDetail> authorDetail => _repository.Entities;

        public async Task DeleteAsync(AuthorDetail authorDetail)
        {
            await _repository.DeleteAsync(authorDetail);
        }

        public async Task<AuthorDetail> GetByIdAsync(int authorDetailId)
        {
            return await _repository.Entities.Where(p => p.Id == authorDetailId).FirstOrDefaultAsync();
        }

        public async Task<List<AuthorDetail>> GetListAsync()
        {
            return await _repository.Entities.ToListAsync();
        }

        public async Task<int> InsertAsync(AuthorDetail authorDetail)
        {
            await _repository.AddAsync(authorDetail);
            return authorDetail.Id;
        }

        public async Task UpdateAsync(AuthorDetail authorDetail)
        {
            await _repository.UpdateAsync(authorDetail);
        }
    }
}
