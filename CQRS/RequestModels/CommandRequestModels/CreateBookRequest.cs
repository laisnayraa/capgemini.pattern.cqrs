﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.RequestModels.CommandRequestModels
{
    public class CreateBookRequest : IRequest<string>
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
    }
}
