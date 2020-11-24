using BooksStore_API2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BooksStore_API2.Contracts
{
    public interface IBookRepository: IRepositoryBase<Book>
    {
        public Task<string> GetImageFileName(int id);
    }
}
