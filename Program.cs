using JaveragesLibrary.Services.Features.Mangas;
using JaveragesLibrary.Infrastructure.Repositories;
using JaveragesLibrary.Services.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using JaveragesLibrary.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

var Configuration = builder.Configuration;

// Add services to the container.
builder.Services.AddScoped<MangaService>();
builder.Services.AddTransient<MangaRepository>();

//builder.Services.AddSingleton<MangaService>();

builder.Services.AddControllers();
builder.Services.AddDbContext<JaveragesLibraryDbContext>(
    options => {
        options.UseSqlServer(Configuration.GetConnectionString("gemDevelopment"));
    }
);

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(ResponseMappingProfile).Assembly);

var app = builder.Build();

// Configure the HTTP request pipeline.
// if (app.Environment.IsDevelopment())
// {
    app.UseSwagger();
    app.UseSwaggerUI();
// }

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();