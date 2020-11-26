using CQRS.Interfaces.Repository;
using CQRS.Models;
using CQRS.RequestModels.CommandRequestModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handlers.CommandHandlers
{
    public class CreateBookHandler : IRequestHandler<CreateBookRequest, string>
    {
        private readonly ICreateBookRequestRepository _repository;

        public CreateBookHandler(ICreateBookRequestRepository repository)
        {
            _repository = repository;
        }

        public Task<string> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            Book book = new Book()
            {
                Titulo = request.Titulo,
                Edicao = request.Edicao
            };

            _repository.Create(book);

            return Task.FromResult("Livro inserido com sucesso!");
        }
    }
}
