using CQRS.ResponseModels.CommandResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.RequestModels.CommandRequestModels
{
    public class GetBookRequest : IRequest<GetBookResponse>
    {
        public int Id { get; set; }
    }
}
