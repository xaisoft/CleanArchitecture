using AutoMapper;
using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Persons.Queries;
using CleanArchitecture.Application.Persons.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Persons.Handlers
{
    public class GetPersonsQueryHandler : IRequestHandler<GetPersonsQuery, IList<PersonVm>>
    {
        private readonly IPersonRepository _personRepository;
        private readonly IMapper _mapper;
        public GetPersonsQueryHandler(IPersonRepository personRepository,IMapper mapper)
        {
            _personRepository = personRepository;
            _mapper = mapper;
        }

        public async Task<IList<PersonVm>> Handle(GetPersonsQuery request, CancellationToken cancellationToken)
        {
            var result = new List<PersonVm>();

            var persons = await _personRepository.GetAll();

            if(persons != null)
            {
                result = _mapper.Map<List<PersonVm>>(persons);
            }
            
            return result;
        }
    }
}
