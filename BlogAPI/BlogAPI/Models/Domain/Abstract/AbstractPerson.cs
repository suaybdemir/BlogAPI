using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using BlogAPI.Models.Domain.Concrete;

namespace BlogAPI.Models.Domain.Abstract
{
    public abstract class AbstractPerson
    {
        [Key]
        public string Id { get; set; } = "";

        [StringLength(100)]
        public string? FullName { get; set; }

        public DateTime RegistrationDate { get; set; } = DateTime.Now;

        public List<Post>? BlogPosts { get; set; } 

        //public List<string>? FavouriteBooks { get; set; }
        [ForeignKey(nameof(Id))]
        public ApplicationUser? ApplicationUser { get; set; }

    }
}
