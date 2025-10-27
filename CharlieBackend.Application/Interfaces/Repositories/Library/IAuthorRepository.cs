using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Interfaces.Repositories.Library
{
    public interface IAuthorRepository
    {

        IQueryable<Author> author { get; }

        Task<List<Author>> GetListAsync();

        Task<Author> GetByIdAsync(int authorId);

        Task<int> InsertAsync(Author author);

        Task UpdateAsync(Author author);

        Task DeleteAsync(Author author);
    }
}
