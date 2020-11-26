﻿using CQRS.Handlers.CommandHandlers;
using CQRS.RequestModels.CommandRequestModels;
using CQRS.ResponseModels.CommandResponseModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IMediator _mediator;
        public BookController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("getbook")]
        public IActionResult Get([FromQuery] CreateBookRequest command)
        {
            var response = _mediator.Send(command);
            return Ok(response);
        }

        [HttpPost]
        public IActionResult Create([FromBody]CreateBookRequest command)
        {
            var response = _mediator.Send(command);
            return Ok(response);
        }
    }
}
