using Microsoft.EntityFrameworkCore;
using WebApplication4.DataContext;
using WebApplication4.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddDbContext<PersonContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetValue<string>("CONNECTION_STRING"));
});
builder.Services.AddScoped<IPersonService, PersonService>();

var app = builder.Build();

app.MapControllers();

app.Run();