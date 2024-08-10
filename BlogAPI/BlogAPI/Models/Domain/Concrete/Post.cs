using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BlogAPI.Models.Domain.Concrete
{
    public class Post
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string AuthorId { get; set; }


        [StringLength(200)]
        public string Title { get; set; }

        public DateTime PublishDate { get; set; } = DateTime.Now;

        [StringLength(200000)]
        public string Text { get; set; }

        [JsonIgnore]
        public List<Comment>? Comments { get; set; }

        [JsonIgnore]
        [ForeignKey(nameof(AuthorId))]
        public Member? Author { get; set; }


    }
}

