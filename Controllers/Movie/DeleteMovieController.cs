using System;
using movie_flix.Models;
using Microsoft.AspNetCore.Mvc;
using movie_flix.Services.Movie;

namespace movie_flix.Controllers;

[ApiController]
[Route("delete-movie")]

public class DeleteMovieController : ControllerBase
{
	private readonly GetMovieByIdService _getMovieByIdService;
    private readonly DeleteMovieService _deleteMovieService;

    public DeleteMovieController(GetMovieByIdService getMovieById, DeleteMovieService deleteMovie)
    {
        _getMovieByIdService = getMovieById;
        _deleteMovieService = deleteMovie;
    }

    [HttpDelete("{id}")]
	public async Task<IActionResult> DeleteMovie([FromRoute] int id)
	{
        var findMovie = await _getMovieByIdService.GetMovie(id);

        if (findMovie == null) return NotFound();

        await _deleteMovieService.DeleteMovie(findMovie);

        return NoContent();
	}
}