using System;
using System.ComponentModel.DataAnnotations;

namespace movie_flix.Data.DTO;

public class MovieDTO
{
    [Required]
    [MaxLength(100)]
    public string Title { get; set; } = "";

    [Required]
    [StringLength(50)]
    public string Gender { get; set; } = "";

    [Required]
    [Range(70, 600)]
    public int Duration { get; set; }
}

