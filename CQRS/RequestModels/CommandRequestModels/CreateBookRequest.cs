using CQRS.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.RequestModels.CommandRequestModels
{
    public class CreateBookRequest : IRequest<CreateBookResponse>
    {
        public string Titulo { get; set; }
        public string Edicao { get; set; }
    }
}
