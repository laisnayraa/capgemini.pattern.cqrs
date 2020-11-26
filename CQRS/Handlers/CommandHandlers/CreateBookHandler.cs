using CQRS.RequestModels.CommandRequestModels;
using CQRS.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CQRS.Handlers.CommandHandlers
{
    public class CreateBookHandler : IRequestHandler<CreateBookRequest, CreateBookResponse>
    {
        public Task<CreateBookResponse> Handle(CreateBookRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateBookResponse
            {
                Id = Guid.NewGuid(),
                Titulo = "Domain-Driven Design: Tackling Complexity in the Heart of Software ",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}
