using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;

namespace WebApplication4.DataContext;

public class PersonContext : DbContext
{
    public PersonContext(DbContextOptions<PersonContext> options) : base(options)
    {
        
    }

    public DbSet<Person> Persons { get; set; }
}