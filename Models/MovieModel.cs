using System;
using System.ComponentModel.DataAnnotations;

namespace movie_flix.Models
{
	public class MovieModel
	{
		[Key]
		[Required]
		public int Id { get; set; }

		[Required]
		[MaxLength(100)]
		public string Title { get; set; } = "";

		[Required]
		[MaxLength(50)]
		public string Gender { get; set; } = "";

		[Required]
		[Range(70,600)]
		public int Duration { get; set; }
	}
}