using GlobalStore.Data 
using Microsft.EntityFrameworkCore
using Microsft.EntityFrameworkCore.Sqlite;

var builder = WebApplication.CreateBuilder(args);

//Add Services to container

builder.Services.AddControllers();
builder.Services.AddDbContext<StoreContext>(options => options.UseSqlite("Data Source=..//Registrar.sqlite", b => b.MigrationsAssembly("GlobalStore.Api"))
);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

