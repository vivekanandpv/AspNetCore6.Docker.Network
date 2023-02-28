using WebApplication4.Models;

namespace WebApplication4.Services;

public interface IPersonService
{
    Task<IEnumerable<Person>> GetAllAsync();
    Task<Person> GetByIdAsync(int id);
    Task<Person> CreateAsync(Person person);
    Task<Person> UpdateAsync(int id, Person person);
    Task DeleteAsync(int id);
}