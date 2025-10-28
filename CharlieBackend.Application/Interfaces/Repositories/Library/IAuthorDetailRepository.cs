using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Interfaces.Repositories.Library
{
    public interface IAuthorDetailRepository
    {

        IQueryable<AuthorDetail> authorDetail { get; }

        Task<List<AuthorDetail>> GetListAsync();

        Task<AuthorDetail> GetByIdAsync(int authorDetailId);

        Task<int> InsertAsync(AuthorDetail authorDetail);

        Task UpdateAsync(AuthorDetail authorDetail);

        Task DeleteAsync(AuthorDetail authorDetail);
    }
}
