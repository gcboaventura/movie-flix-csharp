using System;
using movie_flix.Models;
using movie_flix.Data.DTO;
using movie_flix.Services;
using Microsoft.AspNetCore.Mvc;
using movie_flix.Services.Movie;

namespace movie_flix.Controllers;

[ApiController]
[Route("update-movie")]

public class UpdateMovieController : ControllerBase
{
    private readonly GetMovieByIdService _getMovieByIdService;
    private readonly UpdateMovieService _updateMovieService;

    public UpdateMovieController(GetMovieByIdService getMovieByIdService, UpdateMovieService updateMovieService)
    {
        _getMovieByIdService = getMovieByIdService;
        _updateMovieService = updateMovieService;
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> UpdateMovie([FromRoute] int Id, [FromBody] MovieDTO movieDTO)
    {
        var findMovie = await _getMovieByIdService.GetMovie(Id);

        if (findMovie == null) return NotFound();

        var updatedMovie = await _updateMovieService.UpdateMovie(movieDTO, findMovie);

        return Ok(updatedMovie);
    }
}