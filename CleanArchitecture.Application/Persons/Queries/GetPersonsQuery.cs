using CleanArchitecture.Application.Persons.ViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Persons.Queries
{
    public class GetPersonsQuery : IRequest<IList<PersonVm>>
    {
    }
}
