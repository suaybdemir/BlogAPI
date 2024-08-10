using Microsoft.AspNetCore.Identity;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace BlogAPI.Models.Domain.Concrete
{
    public class ApplicationUser : IdentityUser
    {
        
        public long? IdNumber { get; set; }
        public string Name { get; set; } = "";
        public string? MiddleName { get; set; }
        public string? FamilyName { get; set; }
        public string Address { get; set; } = "";
        public bool Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime RegisterDate { get; set; } = DateTime.Now;
        public byte Status { get; set; }

        [Range(0, 30000)]
        public int? NumberOfPosts { get; set; } = 0;

        [NotMapped]
        public string? Password { get; set; }

        [NotMapped]
        [Compare(nameof(Password))]
        public string? ConfirmPassword { get; set; }

        //public List<string>? FavouritePosts { get; set; }


    }
}

