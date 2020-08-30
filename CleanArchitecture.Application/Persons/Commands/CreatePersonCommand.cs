using MediatR;
using System;

namespace CleanArchitecture.Application.Persons.Commands
{
    public class CreatePersonCommand : IRequest<int>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public DateTime DateOfBirth { get; set; }
    }
}
