using CleanArchitecture.Application.Persons.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Persons.Validators
{
    public class CreatePersonCommandValidator :AbstractValidator<CreatePersonCommand>
    {
        
        public CreatePersonCommandValidator()
        {
            RuleFor(v => v.FirstName).NotEmpty().MinimumLength(2);
            RuleFor(v => v.LastName).NotEmpty().MinimumLength(2);
            RuleFor(v => v.DateOfBirth).LessThan(DateTime.Now);
            
        }
    }
}
