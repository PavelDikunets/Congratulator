using Congratulator.Db.Models;
using Microsoft.EntityFrameworkCore;

namespace Congratulator.Db
{
    public class PersonsDbRepository : IPersonsDbRepository
    {
        private readonly DatabaseContext _databaseContext;

        public PersonsDbRepository(DatabaseContext databaseContext)
        {
            _databaseContext = databaseContext;
        }

        public async Task<Person?> TryGetByIdAsync(int id)
        {
            return await _databaseContext.Persons.FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<List<Person>> GetAllAsync()
        {
            return await _databaseContext.Persons.ToListAsync();
        }

        public async Task AddAsync(Person person)
        {
            await _databaseContext.Persons.AddAsync(person);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(Person editedPerson)
        {
            var personDb = await TryGetByIdAsync(editedPerson.Id);
            _databaseContext.Persons.Remove(personDb!);
            await _databaseContext.AddAsync(editedPerson);
            await _databaseContext.SaveChangesAsync();
        }

        public async Task RemoveAsync(int id)
        {
            var person = await TryGetByIdAsync(id);
            _databaseContext.Persons.Remove(person!);
            await _databaseContext.SaveChangesAsync();
        }
    }
}
