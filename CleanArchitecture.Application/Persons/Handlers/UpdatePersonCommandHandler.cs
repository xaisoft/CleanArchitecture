using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Persons.Commands;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Persons.Handlers
{
    public class UpdatePersonCommandHandler : IRequestHandler<UpdatePersonCommand, int>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public UpdatePersonCommandHandler(IPersonRepository personRepository, IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(UpdatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = _mapper.Map<Person>(request);

            var result = await _personRepository.Update(person);

            return result;
        }
    }
}
