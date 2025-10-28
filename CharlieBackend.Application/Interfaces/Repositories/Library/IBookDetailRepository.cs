using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Interfaces.Repositories.Library
{
    public interface IBookDetailRepository
    {
        IQueryable<BookDetail> bookDetail { get; }

        Task<List<BookDetail>> GetListAsync();

        Task<BookDetail> GetByIdAsync(int bookDetailId);

        Task<int> InsertAsync(BookDetail bookDetail);

        Task UpdateAsync(BookDetail bookDetail);

        Task DeleteAsync(BookDetail bookDetail);
    }
}
