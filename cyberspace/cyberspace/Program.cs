using Microsoft.Extensions.FileSystemGlobbing.Internal.PatternContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using cyberspace.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<cyberspaceContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("cyberspaceContext") ?? throw new InvalidOperationException("Connection string 'cyberspaceContext' not found.")));

// Add services to the container.

builder.Services.AddControllersWithViews();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}"
);

app.Run();
