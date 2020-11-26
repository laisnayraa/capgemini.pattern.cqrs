using CQRS.Models;
using CQRS.RequestModels.CommandRequestModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Interfaces.Repository
{
    public interface ICreateBookRequestRepository
    {
        Task<Book> GetById(GetBookRequest bookRequest);
        void Create(Book book);
    }
}
