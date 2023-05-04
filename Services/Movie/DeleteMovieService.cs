using System;
using movie_flix.Data;
using movie_flix.Models;

namespace movie_flix.Services.Movie
{
	public class DeleteMovieService
	{
		private readonly MovieDatabaseContext _context;

        public DeleteMovieService(MovieDatabaseContext context)
        {
            _context = context;
        }

        public async Task DeleteMovie(MovieModel movie)
		{
			_context.Movie.Remove(movie);

			await _context.SaveChangesAsync();

			return;
		}
	}
}

