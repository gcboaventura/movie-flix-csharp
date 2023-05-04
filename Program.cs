using movie_flix.Data;
using movie_flix.Services;
using movie_flix.Services.Movie;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Connection string database
var connectionString = builder.Configuration.GetConnectionString("MovieConnection");

// Connection database
builder.Services.AddDbContext<MovieDatabaseContext>(options => options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

// Automapper configutation
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddScoped<AddMovieService>();
builder.Services.AddScoped<GetMovieByIdService>();
builder.Services.AddScoped<UpdateMovieService>();
builder.Services.AddScoped<DeleteMovieService>();
builder.Services.AddScoped<GetAllMovieService>();

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

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();