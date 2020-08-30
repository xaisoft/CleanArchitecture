using AutoMapper;
using CleanArchitecture.Application.Persons.Commands;
using CleanArchitecture.Application.Persons.ViewModels;
using CleanArchitecture.Domain.Entities;

namespace CleanArchitecture.Application.Persons.MappingProfiles
{
    public class PersonMappingProfile : Profile
    {
        public PersonMappingProfile()
        {
            CreateMap<Person, PersonVm>();

            CreateMap<PersonVm, Person>();

            CreateMap<CreatePersonCommand, Person>();

            CreateMap<UpdatePersonCommand, Person>();
        }
    }
}
