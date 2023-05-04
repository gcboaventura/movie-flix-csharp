using System;
using AutoMapper;
using movie_flix.Data.DTO;
using movie_flix.Models;

namespace movie_flix.Profiles;

public class MovieProfile : Profile
{
    public MovieProfile()
    {
        CreateMap<MovieDTO, MovieModel>();
    }
}

