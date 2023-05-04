using System;
using AutoMapper;
using movie_flix.Data;
using movie_flix.Models;
using movie_flix.Data.DTO;

namespace movie_flix.Services;

public class AddMovieService
{

    private readonly MovieDatabaseContext _context;
    private readonly IMapper _mapper;


    public AddMovieService(MovieDatabaseContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<MovieModel> AddMovie(MovieDTO movieDTO)
    {
        MovieModel movie = _mapper.Map<MovieModel>(movieDTO);

        _context.Movie.Add(movie);

        await _context.SaveChangesAsync();

        return movie;
    }
}