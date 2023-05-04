using System;
using movie_flix.Models;
using Microsoft.AspNetCore.Mvc;
using movie_flix.Services.Movie;

namespace movie_flix.Controllers;

[ApiController]
[Route("get-all-movie")]

public class GetAllMovieController : ControllerBase
{
	private readonly GetAllMovieService _getAllMovieService;

    public GetAllMovieController(GetAllMovieService getAllMovieService)
    {
        _getAllMovieService = getAllMovieService;
    }

    [HttpGet]
	public async Task<List<MovieModel>> GetAllMovie([FromQuery] int? skip = 0, [FromQuery] int? take = 10, [FromQuery] string? search = null)
	{
        var movieList = await _getAllMovieService.GetAllMovie(skip, take, search);

        return movieList;
    }
}