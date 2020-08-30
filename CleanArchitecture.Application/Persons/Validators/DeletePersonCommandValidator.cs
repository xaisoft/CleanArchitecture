using CleanArchitecture.Application.Persons.Commands;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace CleanArchitecture.Application.Persons.Validators
{
    public class DeletePersonCommandValidator : AbstractValidator<DeletePersonCommand>
    {
        public DeletePersonCommandValidator()
        {
            RuleFor(p => p.Id).NotEmpty().GreaterThan(0);
        }
    }
}
