using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Persons.Commands
{
    public class DeletePersonCommand : IRequest<int>
    {
        public int Id { get; set; }
    }
}
