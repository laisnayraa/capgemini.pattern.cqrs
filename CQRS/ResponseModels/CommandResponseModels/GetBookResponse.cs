﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.ResponseModels.CommandResponseModels
{
    public class GetBookResponse
    {
        public Guid Id { get; set; }
        public string Titulo { get; set; }
        public string Edicao { get; set; }
    }
}
