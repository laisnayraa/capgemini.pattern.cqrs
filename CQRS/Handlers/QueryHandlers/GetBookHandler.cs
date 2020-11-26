using CQRS.Interfaces.Repository;
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
    public class GetBookHandler : IRequestHandler<GetBookRequest, GetBookResponse>
    {
        private readonly ICreateBookRequestRepository _repository;

        public GetBookHandler(ICreateBookRequestRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetBookResponse> Handle(GetBookRequest request, CancellationToken cancellationToken)
        {
            var response = await _repository.GetById(request);
            GetBookResponse resp = new GetBookResponse()
            {
                Titulo = response.Titulo,
                Edicao = response.Edicao
            };

            return resp;
        }
    }
}
