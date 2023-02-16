using Congratulator.Db.Models;

namespace Congratulator.Db
{
    public interface IPersonsDbRepository
    {
        Task<List<Person>> GetAllAsync();

        Task<Person?> TryGetByIdAsync(int id);

        Task AddAsync(Person person);

        Task UpdateAsync(Person editedPerson);
        Task RemoveAsync(int id);
    }
}
