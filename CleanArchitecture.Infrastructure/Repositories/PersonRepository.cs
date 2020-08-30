using CleanArchitecture.Application.Interfaces;
using CleanArchitecture.Domain.Entities;
using Dapper;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace CleanArchitecture.Infrastructure.Repositories
{
    public class PersonRepository : IPersonRepository
    {
        private readonly IConfiguration _configuration;
        public PersonRepository(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public async Task<int> Add(Person person)
        {
            var sql = @"INSERT INTO Persons (FirstName,LastName,DateOfBirth,Age) VALUES (@FirstName,@LastName,@DateOfBirth,@Age);
                        SELECT CAST(SCOPE_IDENTITY() as int)";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = await connection.QueryAsync<int>(sql, person);

                return result.Single();
            }
        }

        public async Task<int> Delete(int id)
        {
            var sql = @"DELETE FROM Persons
                        WHERE Id = @id";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = await connection.ExecuteAsync(sql, new { id });

                return result;
            }
        }

        public async Task<Person> Get(int id)
        {
            var sql = @"SELECT * FROM Persons
                        WHERE Id = @id";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = await connection.QueryFirstOrDefaultAsync<Person>(sql, new { id });
                return result;
            }
        }

        public async Task<IEnumerable<Person>> GetAll()
        {
            var sql = @"SELECT * FROM Persons";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = await connection.QueryAsync<Person>(sql);

                return result;
            }
        }

        public async Task<int> Update(Person person)
        {
            var sql = @"UPDATE Persons
                        SET FirstName = @firstName,
                            LastName = @lastName,
                            Age = @age,
                            DateOfBirth = @dateOfBirth
                        WHERE Id = @id";

            using (var connection = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                var result = await connection.ExecuteAsync(sql, person);

                return result;
            }
        }
    }
}
