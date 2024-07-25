using System;
using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Models
{
	public class Comment
	{
		[Key]
		public int Id { get; set; }
	}
}

