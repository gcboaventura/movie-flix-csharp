using System;
using AutoMapper;
using movie_flix.Data;
using movie_flix.Models;

namespace movie_flix.Services.Movie
{
	public class GetMovieByIdService
    {
        private readonly MovieDatabaseContext _context;

        public GetMovieByIdService(MovieDatabaseContext context)
        {
            _context = context;
        }

        public async Task<MovieModel?> GetMovie(int Id)
		{
            var movie = await _context.Movie.FindAsync(Id);

            return movie;
        }
	}
}