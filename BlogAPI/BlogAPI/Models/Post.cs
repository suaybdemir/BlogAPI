using System;
using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Models
{
	public class Post
	{
		[Key]
		public int Id { get; set; }
	}
}

