using System;
using AutoMapper;
using movie_flix.Data;
using movie_flix.Models;
using movie_flix.Data.DTO;
using Microsoft.AspNetCore.Mvc;

namespace movie_flix.Services;

public class UpdateMovieService
{
    private readonly MovieDatabaseContext _context;
    private readonly IMapper _mapper;

    public UpdateMovieService(MovieDatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<MovieModel?> UpdateMovie(MovieDTO movieDTO, MovieModel movie)
	{
        var updatedMovie = _mapper.Map(movieDTO, movie);

        _context.Movie.Update(updatedMovie);

        await _context.SaveChangesAsync();

        return updatedMovie;
	}
}