using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Application.Persons.Commands;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Persons.Handlers
{
    public class DeletePersonCommandHandler : IRequestHandler<DeletePersonCommand, int>
    {
        private readonly IPersonRepository _personRepository;
        public DeletePersonCommandHandler(IPersonRepository personRepository)
        {
            _personRepository = personRepository;;
        }
        public async Task<int> Handle(DeletePersonCommand request, CancellationToken cancellationToken)
        {
            var result = await _personRepository.Delete(request.Id);

            return result;
        }
    }
}
