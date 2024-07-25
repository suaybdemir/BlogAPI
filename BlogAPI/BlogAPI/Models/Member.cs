using System;
using System.ComponentModel.DataAnnotations;

namespace BlogAPI.Models
{
	public class Member
	{
		[Key]
		public int Id { get; set; }
	}
}

