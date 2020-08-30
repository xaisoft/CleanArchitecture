using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CleanArchitecture.Application.Persons.Commands;
using CleanArchitecture.Application.Persons.Queries;
using CleanArchitecture.Application.Persons.ViewModels;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ApiController
    {

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreatePersonCommand createPersonCommand)
        {
            return await Mediator.Send(createPersonCommand);
        }

        [HttpGet]
        public async Task<IList<PersonVm>> Get()
        {
            return await Mediator.Send(new GetPersonsQuery());
        }

        [HttpPut]
        public async Task<ActionResult<int>> Update(UpdatePersonCommand updatePersonCommand)
        {
            return await Mediator.Send(updatePersonCommand);
        }

        [HttpDelete]
        public async Task<ActionResult<int>> Delete(DeletePersonCommand deletePersonCommand)
        {
            return await Mediator.Send(deletePersonCommand);
        }
    }
}
