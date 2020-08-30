using CleanArchitecture.Application.Persons.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Persons.Validators
{
    public class UpdatePersonCommandValidator : AbstractValidator<UpdatePersonCommand>
    {
        public UpdatePersonCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().GreaterThan(0);
            RuleFor(p => p.FirstName).NotEmpty().MinimumLength(2);
            RuleFor(p => p.LastName).NotEmpty().MinimumLength(2);
            RuleFor(p => p.Age).GreaterThan(0);
            
        }
    }
}
