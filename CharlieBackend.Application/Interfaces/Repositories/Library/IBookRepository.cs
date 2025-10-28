using CharlieBackend.Domain.Entities.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharlieBackend.Application.Interfaces.Repositories.Library
{
    public interface IBookRepository
    {
        
            IQueryable<Book> Book { get; }

            Task<List<Book>> GetListAsync();

            Task<Book> GetByIdAsync(int bookId);

            Task<int> InsertAsync(Book book);

            Task UpdateAsync(Book book);

            Task DeleteAsync(Book book);
        
    }
}
