using System;
using movie_flix.Models;
using movie_flix.Data.DTO;
using movie_flix.Services;
using Microsoft.AspNetCore.Mvc;

namespace movie_flix.Controllers;

[ApiController]
[Route("post-movie")]

public class PostMovieController : ControllerBase
{
    private AddMovieService _addMovieService;

    public PostMovieController(AddMovieService addMovieService)
    {
        _addMovieService = addMovieService;
    }

    [HttpPost]
    public async Task<IActionResult> PostMovie([FromBody] MovieDTO movieDTO)
    {
        MovieModel insertMovie = await _addMovieService.AddMovie(movieDTO);

        if (insertMovie == null) return BadRequest();

        return Ok(insertMovie);
    }
}