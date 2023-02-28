using Microsoft.EntityFrameworkCore;
using WebApplication4.DataContext;
using WebApplication4.Models;

namespace WebApplication4.Services;

public class PersonService : IPersonService
{
    private readonly PersonContext _context;

    public PersonService(PersonContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Person>> GetAllAsync()
    {
        return await _context.Persons.ToListAsync();
    }

    public async Task<Person> GetByIdAsync(int id)
    {
        return await _context.Persons.FirstAsync(p => p.PersonId == id);
    }

    public async Task<Person> CreateAsync(Person person)
    {
        await _context.Persons.AddAsync(person);
        await _context.SaveChangesAsync();
        return person;
    }

    public async Task<Person> UpdateAsync(int id, Person person)
    {
        var p = await GetByIdAsync(id);
        p.FirstName = person.FirstName;
        p.LastName = person.LastName;
        p.Email = person.Email;

        await _context.SaveChangesAsync();

        return p;
    }

    public async Task DeleteAsync(int id)
    {
        var p = await GetByIdAsync(id);
        _context.Persons.Remove(p);
        await _context.SaveChangesAsync();
    }
}