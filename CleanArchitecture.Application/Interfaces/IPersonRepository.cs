using CleanArchitecture.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Application.Interfaces
{
    public interface IPersonRepository
    {
        Task<int> Add(Person person);

        Task<Person> Get(int id);

        Task<IEnumerable<Person>> GetAll();

        Task<int> Delete(int id);

        Task<int> Update(Person id);
    }
}
