using System;
using movie_flix.Models;
using Microsoft.AspNetCore.Mvc;
using movie_flix.Services.Movie;

namespace movie_flix.Controllers.Movie;

[ApiController]
[Route("get-movie-by-id")]

public class GetMovieByIdController : ControllerBase
{
    private readonly GetMovieByIdService _getMovieService;

    public GetMovieByIdController(GetMovieByIdService getMovieService)
    {
        _getMovieService = getMovieService;
    }

    [HttpGet("{id}")]
    public async Task<MovieModel?> GetMovie([FromRoute] int Id)
    {
        var movie = await _getMovieService.GetMovie(Id);

        return movie;
    }
}