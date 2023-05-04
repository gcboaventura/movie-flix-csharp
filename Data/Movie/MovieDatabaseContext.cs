using System;
using Microsoft.EntityFrameworkCore;
using movie_flix.Models;

namespace movie_flix.Data;

public class MovieDatabaseContext : DbContext
{
    public MovieDatabaseContext(DbContextOptions<MovieDatabaseContext> options) : base(options)
    {
    }

    public DbSet<MovieModel> Movie { get; set; }
}