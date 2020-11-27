using CQRS.Interfaces.Repository;
using CQRS.Models;
using CQRS.RequestModels.CommandRequestModels;
using CQRS.ResponseModels.CommandResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Repository
{
    public class CreateBookRequestRepository : ICreateBookRequestRepository
    {
        private readonly DataBaseContext _context;

        public CreateBookRequestRepository(DataBaseContext context)
        {
            _context = context;
        }

        public void Create(Book book)
        {
            _context.Add(book);
            _context.SaveChanges();
        }

        public async Task<Book> GetById(GetBookRequest bookRequest)
        {
            return await Task.FromResult(_context.Set<Book>().Find(bookRequest.Id));
        }
    }
}
