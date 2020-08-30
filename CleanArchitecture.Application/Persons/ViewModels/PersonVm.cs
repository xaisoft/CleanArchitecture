using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArchitecture.Application.Persons.ViewModels
{
    public class PersonVm
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }

        public int Age { get; set; }
    }
}
