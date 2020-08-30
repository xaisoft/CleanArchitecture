using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Persons.Commands;
using CleanArchitecture.Domain.Entities;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Persons.Handlers
{
    public class CreatePersonCommandHandler : IRequestHandler<CreatePersonCommand, int>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public CreatePersonCommandHandler(IPersonRepository personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }
        public async Task<int> Handle(CreatePersonCommand request, CancellationToken cancellationToken)
        {
            var person = _mapper.Map<Person>(request);

            var result = await _personRepository.Add(person);
            return result;
        }
    }
}
