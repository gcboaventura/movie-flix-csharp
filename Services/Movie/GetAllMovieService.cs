using System;
using System.Linq;
using System.Xml.Linq;
using movie_flix.Data;
using movie_flix.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace movie_flix.Services.Movie
{
	public class GetAllMovieService
	{
		private readonly MovieDatabaseContext _context;

        public GetAllMovieService(MovieDatabaseContext context)
        {
            _context = context;
        }

        public async Task<List<MovieModel>>GetAllMovie(int? skip = 0, int? take = 10, string? search = null)
		{
            var query = _context.Movie.AsQueryable();

            if (!string.IsNullOrEmpty(search))
            {
                query = query.Where(m => m.Title.Contains(search));
            }

            query = query.Skip((int)skip).Take((int)take);

            return await query.ToListAsync();

        }
    }
}